Imports System.Threading

'-------------------------------------------------------------
'| 
'| TODO :
'|      현재 결과를 무엇으로 보여줄지 모르겠음. 고민해봐야지
'|      트리뷰로 작성하는 것으로 결론 지음.
'|      성공 실패 기타 등으로
'| 
'| 
'| 
'| 
'-------------------------------------------------------------


Public Class newMain
    Private Sub SearchAdobe_Click(sender As Object, e As EventArgs) Handles SearchAdobe.Click

        Using fld As New FolderBrowserDialog
            With fld
                If (My.Computer.FileSystem.DirectoryExists($"{My.Computer.FileSystem.SpecialDirectories.ProgramFiles}\Adobe")) Then
                    .SelectedPath = $"{My.Computer.FileSystem.SpecialDirectories.ProgramFiles}\Adobe"
                End If

                If (.ShowDialog = DialogResult.OK) Then
                    If Not AdobeList.Items.Contains(.SelectedPath) Then
                        AdobeList.Items.Add(.SelectedPath)
                    End If
                End If

            End With
        End Using
    End Sub

    Dim presetFileThread As Thread = Nothing
    Private Sub AdobeList_SelectedValueChanged(sender As Object, e As EventArgs) Handles AdobeList.SelectedValueChanged
        With AdobeList
            Static Dim idx As Integer = -1

            If idx = AdobeList.SelectedIndex Then
                Exit Sub
            End If

            idx = AdobeList.SelectedIndex

            If idx < 0 Or .Items.Count < idx + 1 Then
                Exit Sub
            End If

            If My.Computer.FileSystem.DirectoryExists($"{ .Items(idx)}\Support Files\Presets") Then
                ControlPanel.Enabled = True
                TaskLabel.ForeColor = Color.Blue
                TaskLabel.Text = $"프리셋 폴더를 찾았습니다."
            Else
                ControlPanel.Enabled = False
                TaskLabel.ForeColor = Color.Red
                TaskLabel.Text = $"프리셋 폴더를 찾지 못했습니다. 항목을 다시 확인해주세요."
            End If

        End With
    End Sub
    Structure ModifyFileFunc
        Dim src As String
        Dim makeLog As Boolean
        Dim copyErrorFile As Boolean
    End Structure
    Private Sub Btn_ModifyName_Click(sender As Object, e As EventArgs) Handles Btn_ModifyName.Click
        If presetFileThread IsNot Nothing Then
            MsgBox("파일 교정이 진행중입니다.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("파일명 교정을 진행합니다.", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "교정 진행") = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        With AdobeList
            Dim idx As Integer = .SelectedIndex

            If idx < 0 Or .Items.Count < idx + 1 Then
                MsgBox("목록을 다시 선택해주세요.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If presetFileThread IsNot Nothing Then
                presetFileThread.Abort()
            End If

            presetFileThread = New Thread(AddressOf ModifyFileName)

            presetFileThread.Start(New ModifyFileFunc With {.src = $"{ AdobeList.Items(idx)}\Support Files\Presets", .makeLog = CheckBox1.Checked, .copyErrorFile = CheckBox2.Checked})

        End With
    End Sub

    Private Sub ModifyFileName(ByVal setting As ModifyFileFunc) 'REM TODO
        CtrlEnabledSet(Btn_ModifyName, False)
        mainTaskAlert("교정 작업을 초기화중입니다.")
        Dim hans As New HangulVB
        Dim src As String = setting.src
        Dim makeLog As Boolean = setting.makeLog
        Dim copyErr As Boolean = setting.copyErrorFile

        For Each path As String In My.Computer.FileSystem.GetFiles(src, FileIO.SearchOption.SearchAllSubDirectories, "*.ffx")
            Dim fInfo As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(path)

            Dim nameData As List(Of HangulVB.charData) = hans.CreateStruct(fInfo.Name)
            If hans.IsHangul(nameData) Then
                Dim newNameData As String = hans.StructToStr(hans.Combine(nameData))
                If path = Replace(path, fInfo.Name, newNameData) Then
                    'REM 변경 불가
                    'REM 동일한 파일 명

                    Continue For
                End If
                Try
                    If Not My.Computer.FileSystem.FileExists(path) Then

                    End If
                    My.Computer.FileSystem.RenameFile(path, $"{newNameData}{fInfo.Extension}")
                    'REM 변경 성공

                Catch ex As Exception

                End Try

            End If




        Next

        mainTaskAlert("교정이 완료되었습니다. 세부 항목은 오른쪽 트리뷰에서 확인할 수 있습니다.")
        CtrlEnabledSet(Btn_ModifyName, True)
        presetFileThread = Nothing 'REM 스레드 종료 확인
    End Sub



    Delegate Function D_GetTreeData(ByVal trev As TreeView) As TreeNodeCollection
    Private Function GetTreeData(ByVal trev As TreeView) As TreeNodeCollection

        If trev.InvokeRequired Then
            Return trev.Invoke(New D_GetTreeData(AddressOf GetTreeData), New Object() {trev})
        Else
            Return trev.Nodes
        End If

    End Function

    Delegate Sub D_CtrlEnabledSet(ByVal Ctrl As Control, ByVal enable As Boolean)
    Private Sub CtrlEnabledSet(ByVal ctrl As Control, ByVal enable As Boolean)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New D_CtrlEnabledSet(AddressOf CtrlEnabledSet), New Object() {ctrl, enable})
        Else
            ctrl.Enabled = enable
        End If
    End Sub


    Delegate Sub D_AppendTree(ByVal location As String, ByVal value As String, ByVal bfValue As String)
    Private Sub AppendTree(ByVal location As String, ByVal value As String, ByVal bfValue As String)
        If TreeView2.InvokeRequired Then
            TreeView2.Invoke(New D_AppendTree(AddressOf AppendTree), New Object() {location, value, bfValue})
        Else
            Dim tnd As TreeNodeCollection = TreeView2.Nodes
            Dim nd As TreeNode = Nothing
            Dim folder As List(Of String) = Split(Mid(location, 2), "\").ToList()

            For i As Integer = 0 To folder.Count - 1
                Dim k As Integer
                For k = 0 To tnd.Count - 1
                    If $"{folder(i)}" = tnd.Item(k).Text Then
                        nd = tnd.Item(k)
                        Exit For
                    End If
                Next
                If k = tnd.Count Then
                    nd = New TreeNode With {
                        .Text = $"{folder(i)}",
                        .Name = folder(i)
                    }
                    tnd.Add(nd)
                End If
                tnd = nd.Nodes

            Next

            nd = New TreeNode With {
                .Text = value,
                .Name = value
            }

            tnd.Add(nd)
        End If
    End Sub

    Private Sub 폴더열기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 폴더열기ToolStripMenuItem.Click
        Dim idx As Integer = AdobeList.SelectedIndex
        If idx < 0 Or AdobeList.Items.Count < idx + 1 Then
            Exit Sub
        End If

        Process.Start($"{AdobeList.Items(idx)}")

    End Sub

    Private Sub 항목삭제ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 항목삭제ToolStripMenuItem.Click
        Dim idx As Integer = AdobeList.SelectedIndex
        If idx < 0 Or AdobeList.Items.Count < idx + 1 Then
            Exit Sub
        End If

        AdobeList.Items.RemoveAt(idx)

    End Sub
    Dim searchThread As Thread = Nothing
    Private Sub 자동검색ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 자동검색ToolStripMenuItem.Click

        If searchThread Is Nothing Then
            MainTaskLabel.Text = $"자동 검색을 백그라운드에서 실행합니다."
            searchThread = New Thread(AddressOf FindProgram) With {
                .Name = $"folder-finder"
            }
            searchThread.Start()
        Else
            mainTaskAlert("이미 작업이 진행중입니다.")
        End If

    End Sub

    'REM Adobe Series에서 After Effect 설치 위치를 레지스트리에서 검색합니다.
    Private Sub FindProgram()
        Dim regTree As Microsoft.Win32.RegistryKey =
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
        For Each str As String In regTree.GetSubKeyNames
            Dim reg As Microsoft.Win32.RegistryKey = regTree.OpenSubKey(str, False)
            Dim regValList As List(Of String) = reg.GetValueNames().ToList

            If regValList.Contains("DisplayName") Then
                If reg.GetValue("DisplayName") Like "Adobe After Effect *" Then
                    If regValList.Contains("InstallLocation") Then
                        Dim loc As String = reg.GetValue("InstallLocation")
                        AppendLocationInList($"{loc}")
                    End If
                End If
            End If

            reg.Close()
        Next
        regTree.Close()

        mainTaskAlert("검색을 완료했습니다.")
        searchThread = Nothing  'REM 스레드 종료시 확인을 위해 작성
    End Sub

    'REM 서브 스레드에서 메인 스레드로 MainTaskLabel 값 변경을 요청
    Delegate Sub D_mainTaskAlert(ByVal msg As String)
    Private Sub mainTaskAlert(Optional ByVal msg As String = Nothing)
        If Me.InvokeRequired Then
            Me.Invoke(New D_mainTaskAlert(AddressOf mainTaskAlert), New Object() {msg})
        Else
            MainTaskLabel.Text = msg
        End If
    End Sub

    'REM 찾은 값을 리스트에 추가하기 위한 Delegate
    Delegate Sub D_AppendLocationInList(ByVal loc As String)
    Private Sub AppendLocationInList(ByVal loc As String)
        If AdobeList.InvokeRequired Then
            AdobeList.Invoke(New D_AppendLocationInList(AddressOf AppendLocationInList), New Object() {loc})
        Else
            AdobeList.Items.Add(loc)
        End If
    End Sub

    <Obsolete>
    Private Sub NewMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'REM 메인 스레드 접근시 문제 해결을 위해 메인 스레드가
        'REM 종료되기 전에 서브 스레드 상태를 점검하여
        'REM 서브스레드부터 삭제함
        If presetFileThread IsNot Nothing AndAlso presetFileThread.IsAlive Then
            presetFileThread.Suspend()

        End If
        If searchThread IsNot Nothing AndAlso searchThread.IsAlive Then
            searchThread.Suspend()

        End If


        If presetFileThread IsNot Nothing Or searchThread IsNot Nothing Then
            If MsgBox("작업을 중단하고 프로그램을 닫습니다.", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "알림") = MsgBoxResult.Ok Then
                If presetFileThread IsNot Nothing Then
                    If presetFileThread.IsAlive Then
                        presetFileThread.Resume()
                        presetFileThread.Abort()
                        presetFileThread = Nothing
                    End If
                End If

                If searchThread IsNot Nothing Then
                    If searchThread.IsAlive Then
                        searchThread.Resume()
                        searchThread.Abort()
                        searchThread = Nothing
                    End If
                End If

            Else
                e.Cancel = True
                If searchThread IsNot Nothing AndAlso searchThread.IsAlive Then
                    searchThread.Resume()

                End If
                If presetFileThread IsNot Nothing AndAlso presetFileThread.IsAlive Then
                    presetFileThread.Resume()
                End If

            End If
        End If


    End Sub

End Class
Imports System.Threading

'-------------------------------------------------------------
'| 
'| TODO :
'|      현재 결과를 무엇으로 보여줄지 모르겠음. 고민해봐야지
'| 
'| 
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
            Dim idx As Integer = .SelectedIndex
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

    Private Sub ModifyFileName(ByVal setting As ModifyFileFunc) '' TODO
        mainTaskAlert("파일을 찾고 있습니다.")
        Dim src As String = setting.src
        Dim makeLog As Boolean = setting.makeLog
        Dim copyErr As Boolean = setting.copyErrorFile

        If My.Computer.FileSystem.DirectoryExists(src) Then
            Dim hans As New HangulVB
            For Each path As String In My.Computer.FileSystem.GetFiles(src, FileIO.SearchOption.SearchAllSubDirectories, "*.ffx")
                Dim fInfo As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(path)
                Dim nameData As List(Of HangulVB.charData) = hans.CreateStruct(fInfo.Name)
                Dim newNameData As String = hans.StructToStr(hans.Combine(nameData))

                RichTbxSet($"{fInfo.Directory.Name}\{fInfo.Name}{fInfo.Extension} >> { _
                    w}  {fInfo.Directory.Name}\{newNameData}{fInfo.Extension}{w}")

            Next
        End If

        presetFileThread = Nothing 'REM 스레드 종료 확인
    End Sub

    Delegate Sub D_RichTbxSet(ByVal str As String, ByVal append As Boolean)
    Private Sub RichTbxSet(ByVal str As String, Optional append As Boolean = True)
        With rtb
            If .InvokeRequired Then
                .Invoke(New D_RichTbxSet(AddressOf RichTbxSet), New Object() {str, append})
            Else
                If append Then
                    rtb.Text &= str
                Else
                    rtb.Text = str
                End If
            End If
        End With
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
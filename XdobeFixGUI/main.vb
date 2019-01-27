Public Class main
    Private Sub btnFindLoc_Click(sender As Object, e As EventArgs) Handles btnFindLoc.Click
        Dim loc As String = FuncGetFolderLoc()

        If (My.Computer.FileSystem.DirectoryExists(loc)) Then
            TargetLoc.Text = loc
            If (My.Computer.FileSystem.DirectoryExists($"{loc}\Support Files\Presets")) Then
                TargetLoc.Text = $"{loc}\Support Files\Presets".Replace("\\", "\")

                With LblPresetsFld
                    .Text = $"프리셋 폴더를 찾았습니다. 다음 작업으로 진행이 가능합니다."
                    .ForeColor = FuncGetColor(True)
                End With
                btnFindLoc.Enabled = False
                tabContainer.Enabled = True

            Else
                With LblPresetsFld
                    .Text = $"프리셋 폴더를 찾을 수 없습니다, 다시 시도해주세요."
                    .ForeColor = FuncGetColor(False)
                End With
            End If
        Else
            If Not (loc = Nothing) Then
                With LblPresetsFld
                    .Text = $"존재하지 않는 폴더를 경로로 지정하셨습니다."
                    .ForeColor = FuncGetColor(False)
                End With

            End If
        End If

    End Sub

    Private Sub btnNameRevise_Click(sender As Object, e As EventArgs) Handles btnNameRevise.Click
        Dim hans As New HangulVB
        rtbCorrectRevise.Clear()
        For Each pos As String In My.Computer.FileSystem.GetFiles(TargetLoc.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            Dim file As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(pos)
            Dim fileName As String = FuncGetFileName(file.Name, file.Extension)
            Dim nameData As List(Of HangulVB.charData) = hans.CreateStruct(fileName)
            If (hans.IsHangul(nameData)) Then
                Dim newNameData As String = hans.StructToStr(hans.Combine(nameData))
                If pos = Replace(pos, fileName, newNameData) Then
                    rtbUncorrectRevise.Text &= $"{Replace(file.Directory.ToString, TargetLoc.Text, "")}\{newNameData}{file.Extension} 수정 필요 없음{w}"
                    rtbUncorrectRevise.SelectionStart = rtbUncorrectRevise.TextLength
                    rtbUncorrectRevise.ScrollToCaret()
                    rtbUncorrectRevise.Refresh()
                    Continue For
                End If
                Try
                    My.Computer.FileSystem.RenameFile(pos, $"{newNameData}{file.Extension}")
                    rtbCorrectRevise.Text &= $"{Replace(file.Directory.ToString, TargetLoc.Text, "")}\{newNameData}{file.Extension} 수정 완료 {w}"
                    rtbCorrectRevise.SelectionStart = rtbCorrectRevise.TextLength
                    rtbCorrectRevise.ScrollToCaret()
                    rtbCorrectRevise.Refresh()
                Catch ex As Exception

                    newNameData = fileName
                    rtbUncorrectRevise.Text &= $"{ex.Message}{w}"
                    rtbUncorrectRevise.SelectionStart = rtbUncorrectRevise.TextLength
                    rtbUncorrectRevise.ScrollToCaret()
                    rtbUncorrectRevise.Refresh()
                End Try

            Else

            End If
        Next

        MsgBox("작업이 완료되었습니다.", MessageBoxIcon.Information)
    End Sub

    Private Sub LnkBuilder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkBuilder.LinkClicked
        Process.Start($"{LnkBuilder.Text}?withXdobeFixPrg")
    End Sub
End Class

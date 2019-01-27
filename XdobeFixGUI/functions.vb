Imports System.Security.Permissions
Module functions

#Region "icon"

    ''' <summary>
    ''' from : http://checktechno.blogspot.com/2013/06/how-convert-bmp-to-icon-in-vbnet.html
    ''' </summary>
    ''' <returns></returns>

    <SecurityPermissionAttribute(SecurityAction.LinkDemand,
                                 Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Function GetHicon() As IntPtr

    End Function

    Public Function FuncBitmapToIco(ByVal target As Bitmap) As Icon
        Dim ico As Icon

        Dim hico As IntPtr
        hico = target.GetHicon()
        ico = System.Drawing.Icon.FromHandle(hico)
        Return ico
    End Function

#End Region


#Region "file & folder"

    Public Function FuncGetFolderLoc() As String
        Dim loc As String = Nothing

        Using fldBrowser As New FolderBrowserDialog
            With fldBrowser
                If (My.Computer.FileSystem.DirectoryExists($"{My.Computer.FileSystem.SpecialDirectories.ProgramFiles}\Adobe")) Then
                    .SelectedPath = $"{My.Computer.FileSystem.SpecialDirectories.ProgramFiles}\Adobe"

                End If

                If (.ShowDialog = DialogResult.OK) Then
                    loc = .SelectedPath
                End If
            End With
        End Using

        Return loc
    End Function

    Public Function FuncGetFileName(ByVal FullSrc As String, ByVal Extension As String) As String
        Return Mid(FullSrc, 1, InStr(FullSrc, Extension) - 1)
    End Function

#End Region

    Public Function FuncGetColor(ByVal success As Boolean) As Color
        If (success) Then
            Return Color.Blue
        End If
        Return Color.Red
    End Function

End Module

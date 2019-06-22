Module Initliaize

    Public Const w As String = Chr(13)

    Public Sub Initialization()

        Dim prgIco As Icon = FuncBitmapToIco(My.Resources.icon)
        'Program Icon
        With My.Forms.newMain
            .Text = My.Application.Info.Title
            .Icon = prgIco

            With .SearchAdobe
                .Text = "찾기"

            End With

            With .TaskLabel
                .ForeColor = Color.Green
                .Text = $"오른쪽 찾기를 통해 폴더를 추가한 뒤, 원하는 목록을 선택하면 아래 메뉴가 활성화됩니다."
            End With

            With .ControlPanel
                .Enabled = False
            End With


        End With

        With My.Forms.main
            .Text = My.Application.Info.Title
            '.Size = New Size(900, 600)
            .Icon = prgIco

            With .TargetLoc
                .ReadOnly = True
                .Text = $"Adobe AE CC 제품이 설치된 위치를 선택해주세요. ...\Adobe\Adobe After Effect CC 2018"
                .SelectionStart = .Text.Length
            End With

            With .LblPresetsFld
                .Text = $"아래 작업을 시작하기 전 위 작업을 진행해주세요."
                .ForeColor = FuncGetColor(False)
            End With

            With .tabContainer
                .Enabled = False
            End With

            With .rtbCorrectRevise
                .Text = $"작업을 시작하면 성공한 내역은 이곳에, 실패한 내역은 아래에 기록됩니다."
                .ReadOnly = True
            End With

            With .rtbUncorrectRevise
                .Text = Nothing
                .ReadOnly = True
            End With

            With .LblNameReviseTask
                .Text = Nothing

            End With

            With .LblNotice
                .Text = $"어도비 애프터 이펙트의 프리셋 문제를 해결하기 위한 프로그램입니다{w _
                        }http://pang2h.tistory.com/ 에서 정식으로 다운로드하실 수 있습니다{w _
                        } 프로그램 관련 문의는 제작자 블로그의 다운로드 포스트에 댓글로 해주세요"
            End With

            With .LnkBuilder
                .Text = $"https://pang2h.tistory.com/pages/XdobeFixSeries"

            End With

            With .Label4
                .Location = New Point(.Parent.Width / 2 - .Width / 2, .Parent.Height / 2 - .Height / 2)
                .Text = $"한영 변환 기능은 XdobeFixSwitch 프로그램으로 분리되었습니다.{w}다음에서 찾을 수 있습니다. {w}{w}https://pang2h.tistory.com/pages/XdobeFixSeries"
                .Tag = "https://pang2h.tistory.com/pages/XdobeFixSeries"
                .Cursor = Cursors.Hand
            End With

        End With

    End Sub

End Module

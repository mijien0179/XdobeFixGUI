﻿Module Initliaize

    Public Const w As String = Chr(13)

    Public Sub Initialization()

        Dim prgIco As Icon = FuncBitmapToIco(My.Resources.icon)
        'Program Icon
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
                .Text = $"https://pang2h.tistory.com/pages/XdobeFix"

            End With

        End With

    End Sub

End Module

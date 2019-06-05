<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabContainer = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblNameReviseTask = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbCorrectRevise = New System.Windows.Forms.RichTextBox()
        Me.rtbUncorrectRevise = New System.Windows.Forms.RichTextBox()
        Me.btnNameRevise = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnFindLoc = New System.Windows.Forms.Button()
        Me.TargetLoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPresetsFld = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNotice = New System.Windows.Forms.Label()
        Me.LnkBuilder = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabContainer.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabContainer
        '
        Me.tabContainer.Controls.Add(Me.TabPage1)
        Me.tabContainer.Controls.Add(Me.TabPage2)
        Me.tabContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabContainer.Location = New System.Drawing.Point(0, 89)
        Me.tabContainer.Name = "tabContainer"
        Me.tabContainer.SelectedIndex = 0
        Me.tabContainer.Size = New System.Drawing.Size(559, 362)
        Me.tabContainer.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblNameReviseTask)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.btnNameRevise)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(551, 336)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "한글 이름 교정"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblNameReviseTask
        '
        Me.LblNameReviseTask.Location = New System.Drawing.Point(4, 298)
        Me.LblNameReviseTask.Name = "LblNameReviseTask"
        Me.LblNameReviseTask.Size = New System.Drawing.Size(419, 32)
        Me.LblNameReviseTask.TabIndex = 2
        Me.LblNameReviseTask.Text = "LblNameReviseTask"
        Me.LblNameReviseTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.703911!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.29609!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rtbCorrectRevise, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rtbUncorrectRevise, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.04895!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.95105!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(537, 286)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 145)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "완료"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 141)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "실패"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbCorrectRevise
        '
        Me.rtbCorrectRevise.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbCorrectRevise.Location = New System.Drawing.Point(39, 3)
        Me.rtbCorrectRevise.Name = "rtbCorrectRevise"
        Me.rtbCorrectRevise.Size = New System.Drawing.Size(495, 139)
        Me.rtbCorrectRevise.TabIndex = 2
        Me.rtbCorrectRevise.Text = ""
        '
        'rtbUncorrectRevise
        '
        Me.rtbUncorrectRevise.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbUncorrectRevise.Location = New System.Drawing.Point(39, 148)
        Me.rtbUncorrectRevise.Name = "rtbUncorrectRevise"
        Me.rtbUncorrectRevise.Size = New System.Drawing.Size(495, 135)
        Me.rtbUncorrectRevise.TabIndex = 3
        Me.rtbUncorrectRevise.Text = ""
        '
        'btnNameRevise
        '
        Me.btnNameRevise.Location = New System.Drawing.Point(429, 298)
        Me.btnNameRevise.Name = "btnNameRevise"
        Me.btnNameRevise.Size = New System.Drawing.Size(116, 32)
        Me.btnNameRevise.TabIndex = 0
        Me.btnNameRevise.Text = "이름 교정하기"
        Me.btnNameRevise.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(551, 336)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "프리셋 한/영 전환"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnFindLoc
        '
        Me.btnFindLoc.Location = New System.Drawing.Point(433, 51)
        Me.btnFindLoc.Name = "btnFindLoc"
        Me.btnFindLoc.Size = New System.Drawing.Size(116, 32)
        Me.btnFindLoc.TabIndex = 2
        Me.btnFindLoc.Text = "위치 검색"
        Me.btnFindLoc.UseVisualStyleBackColor = True
        '
        'TargetLoc
        '
        Me.TargetLoc.Location = New System.Drawing.Point(14, 24)
        Me.TargetLoc.Name = "TargetLoc"
        Me.TargetLoc.Size = New System.Drawing.Size(535, 21)
        Me.TargetLoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "대상 위치(어도비 애프터이펙트 설치 위치)"
        '
        'LblPresetsFld
        '
        Me.LblPresetsFld.AutoEllipsis = True
        Me.LblPresetsFld.Location = New System.Drawing.Point(12, 51)
        Me.LblPresetsFld.Name = "LblPresetsFld"
        Me.LblPresetsFld.Size = New System.Drawing.Size(415, 32)
        Me.LblPresetsFld.TabIndex = 4
        Me.LblPresetsFld.Text = "LblPresetsFld"
        Me.LblPresetsFld.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblPresetsFld)
        Me.Panel1.Controls.Add(Me.tabContainer)
        Me.Panel1.Controls.Add(Me.TargetLoc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnFindLoc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 451)
        Me.Panel1.TabIndex = 5
        '
        'LblNotice
        '
        Me.LblNotice.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblNotice.Location = New System.Drawing.Point(0, 451)
        Me.LblNotice.Name = "LblNotice"
        Me.LblNotice.Size = New System.Drawing.Size(559, 41)
        Me.LblNotice.TabIndex = 6
        Me.LblNotice.Text = "LblNotice"
        Me.LblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LnkBuilder
        '
        Me.LnkBuilder.AutoSize = True
        Me.LnkBuilder.Location = New System.Drawing.Point(12, 502)
        Me.LnkBuilder.Name = "LnkBuilder"
        Me.LnkBuilder.Size = New System.Drawing.Size(64, 12)
        Me.LnkBuilder.TabIndex = 7
        Me.LnkBuilder.TabStop = True
        Me.LnkBuilder.Text = "LnkBuilder"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(30, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 183)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 524)
        Me.Controls.Add(Me.LnkBuilder)
        Me.Controls.Add(Me.LblNotice)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.tabContainer.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabContainer As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnFindLoc As Button
    Friend WithEvents TargetLoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPresetsFld As Label
    Friend WithEvents btnNameRevise As Button
    Friend WithEvents LblNameReviseTask As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rtbCorrectRevise As RichTextBox
    Friend WithEvents rtbUncorrectRevise As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblNotice As Label
    Friend WithEvents LnkBuilder As LinkLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newMain
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
        Me.components = New System.ComponentModel.Container()
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.Btn_ModifyName = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SelectorPanel = New System.Windows.Forms.Panel()
        Me.TaskLabel = New System.Windows.Forms.Label()
        Me.AdobeList = New System.Windows.Forms.ListBox()
        Me.CMS_AdobeList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.폴더열기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.항목삭제ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchAdobe = New System.Windows.Forms.Button()
        Me.CMS_Search = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.자동검색ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MainTaskLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ControlPanel.SuspendLayout()
        Me.SelectorPanel.SuspendLayout()
        Me.CMS_AdobeList.SuspendLayout()
        Me.CMS_Search.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.rtb)
        Me.ControlPanel.Controls.Add(Me.Btn_ModifyName)
        Me.ControlPanel.Controls.Add(Me.Label1)
        Me.ControlPanel.Controls.Add(Me.CheckBox2)
        Me.ControlPanel.Controls.Add(Me.CheckBox1)
        Me.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlPanel.Location = New System.Drawing.Point(0, 107)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(784, 234)
        Me.ControlPanel.TabIndex = 1
        '
        'rtb
        '
        Me.rtb.Location = New System.Drawing.Point(12, 31)
        Me.rtb.Name = "rtb"
        Me.rtb.ReadOnly = True
        Me.rtb.Size = New System.Drawing.Size(627, 190)
        Me.rtb.TabIndex = 10
        Me.rtb.Text = ""
        '
        'Btn_ModifyName
        '
        Me.Btn_ModifyName.Location = New System.Drawing.Point(645, 179)
        Me.Btn_ModifyName.Name = "Btn_ModifyName"
        Me.Btn_ModifyName.Size = New System.Drawing.Size(127, 42)
        Me.Btn_ModifyName.TabIndex = 9
        Me.Btn_ModifyName.Text = "교정"
        Me.Btn_ModifyName.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "이름 교정"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(645, 55)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "에러 파일 복사"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(645, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 16)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "로그 작성"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SelectorPanel
        '
        Me.SelectorPanel.Controls.Add(Me.TaskLabel)
        Me.SelectorPanel.Controls.Add(Me.AdobeList)
        Me.SelectorPanel.Controls.Add(Me.SearchAdobe)
        Me.SelectorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SelectorPanel.Location = New System.Drawing.Point(0, 0)
        Me.SelectorPanel.Name = "SelectorPanel"
        Me.SelectorPanel.Size = New System.Drawing.Size(784, 107)
        Me.SelectorPanel.TabIndex = 0
        '
        'TaskLabel
        '
        Me.TaskLabel.Location = New System.Drawing.Point(12, 79)
        Me.TaskLabel.Name = "TaskLabel"
        Me.TaskLabel.Size = New System.Drawing.Size(760, 25)
        Me.TaskLabel.TabIndex = 2
        Me.TaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdobeList
        '
        Me.AdobeList.ContextMenuStrip = Me.CMS_AdobeList
        Me.AdobeList.Font = New System.Drawing.Font("맑은 고딕", 11.0!)
        Me.AdobeList.FormattingEnabled = True
        Me.AdobeList.ItemHeight = 20
        Me.AdobeList.Location = New System.Drawing.Point(12, 12)
        Me.AdobeList.Name = "AdobeList"
        Me.AdobeList.Size = New System.Drawing.Size(653, 64)
        Me.AdobeList.TabIndex = 1
        '
        'CMS_AdobeList
        '
        Me.CMS_AdobeList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.폴더열기ToolStripMenuItem, Me.항목삭제ToolStripMenuItem})
        Me.CMS_AdobeList.Name = "CMS_AdobeList"
        Me.CMS_AdobeList.Size = New System.Drawing.Size(127, 48)
        '
        '폴더열기ToolStripMenuItem
        '
        Me.폴더열기ToolStripMenuItem.Name = "폴더열기ToolStripMenuItem"
        Me.폴더열기ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.폴더열기ToolStripMenuItem.Text = "폴더 열기"
        '
        '항목삭제ToolStripMenuItem
        '
        Me.항목삭제ToolStripMenuItem.Name = "항목삭제ToolStripMenuItem"
        Me.항목삭제ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.항목삭제ToolStripMenuItem.Text = "항목 삭제"
        '
        'SearchAdobe
        '
        Me.SearchAdobe.ContextMenuStrip = Me.CMS_Search
        Me.SearchAdobe.Location = New System.Drawing.Point(671, 12)
        Me.SearchAdobe.Name = "SearchAdobe"
        Me.SearchAdobe.Size = New System.Drawing.Size(101, 64)
        Me.SearchAdobe.TabIndex = 0
        Me.SearchAdobe.Text = "Search"
        Me.SearchAdobe.UseVisualStyleBackColor = True
        '
        'CMS_Search
        '
        Me.CMS_Search.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.자동검색ToolStripMenuItem})
        Me.CMS_Search.Name = "CMS_Search"
        Me.CMS_Search.Size = New System.Drawing.Size(127, 26)
        '
        '자동검색ToolStripMenuItem
        '
        Me.자동검색ToolStripMenuItem.Name = "자동검색ToolStripMenuItem"
        Me.자동검색ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.자동검색ToolStripMenuItem.Text = "자동 검색"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainTaskLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 341)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MainTaskLabel
        '
        Me.MainTaskLabel.Name = "MainTaskLabel"
        Me.MainTaskLabel.Size = New System.Drawing.Size(71, 17)
        Me.MainTaskLabel.Text = "                "
        '
        'newMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 363)
        Me.Controls.Add(Me.ControlPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SelectorPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newMain"
        Me.Text = "newMain"
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        Me.SelectorPanel.ResumeLayout(False)
        Me.CMS_AdobeList.ResumeLayout(False)
        Me.CMS_Search.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlPanel As Panel
    Friend WithEvents SelectorPanel As Panel
    Friend WithEvents SearchAdobe As Button
    Friend WithEvents CMS_Search As ContextMenuStrip
    Friend WithEvents 자동검색ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdobeList As ListBox
    Friend WithEvents TaskLabel As Label
    Friend WithEvents CMS_AdobeList As ContextMenuStrip
    Friend WithEvents 폴더열기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 항목삭제ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MainTaskLabel As ToolStripStatusLabel
    Friend WithEvents Btn_ModifyName As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents rtb As RichTextBox
End Class

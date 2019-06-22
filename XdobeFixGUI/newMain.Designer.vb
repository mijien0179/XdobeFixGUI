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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("성공")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("파일 없음")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("권한 없음")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("동일 파일명")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("알 수 없음")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("실패", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("변경 없음")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("기타", New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.도움말ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ControlPanel.SuspendLayout()
        Me.SelectorPanel.SuspendLayout()
        Me.CMS_AdobeList.SuspendLayout()
        Me.CMS_Search.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.SplitContainer1)
        Me.ControlPanel.Controls.Add(Me.Btn_ModifyName)
        Me.ControlPanel.Controls.Add(Me.Label1)
        Me.ControlPanel.Controls.Add(Me.CheckBox2)
        Me.ControlPanel.Controls.Add(Me.CheckBox1)
        Me.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlPanel.Location = New System.Drawing.Point(0, 131)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(784, 433)
        Me.ControlPanel.TabIndex = 1
        '
        'TreeView2
        '
        Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView2.Location = New System.Drawing.Point(0, 0)
        Me.TreeView2.Name = "TreeView2"
        TreeNode1.Name = "SuccessNode"
        TreeNode1.Text = "성공"
        TreeNode2.Name = "NoFileNode"
        TreeNode2.Text = "파일 없음"
        TreeNode3.Name = "UnauthorizeNode"
        TreeNode3.Text = "권한 없음"
        TreeNode4.Name = "SmeFleNameNode"
        TreeNode4.Text = "동일 파일명"
        TreeNode5.Name = "etcErrorNode"
        TreeNode5.Text = "알 수 없음"
        TreeNode6.Name = "FailNode"
        TreeNode6.Text = "실패"
        TreeNode7.Name = "NoChangeNode"
        TreeNode7.Text = "변경 없음"
        TreeNode8.Name = "etcNode"
        TreeNode8.Text = "기타"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode6, TreeNode8})
        Me.TreeView2.Size = New System.Drawing.Size(456, 350)
        Me.TreeView2.TabIndex = 0
        '
        'Btn_ModifyName
        '
        Me.Btn_ModifyName.Location = New System.Drawing.Point(645, 387)
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
        Me.CheckBox2.Location = New System.Drawing.Point(17, 409)
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
        Me.CheckBox1.Location = New System.Drawing.Point(17, 387)
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
        Me.SelectorPanel.Location = New System.Drawing.Point(0, 24)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 564)
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.도움말ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '도움말ToolStripMenuItem
        '
        Me.도움말ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.정보ToolStripMenuItem})
        Me.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem"
        Me.도움말ToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.도움말ToolStripMenuItem.Text = "도움말"
        '
        '정보ToolStripMenuItem
        '
        Me.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem"
        Me.정보ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.정보ToolStripMenuItem.Text = "정보"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(17, 31)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(755, 350)
        Me.SplitContainer1.SplitterDistance = 456
        Me.SplitContainer1.TabIndex = 10
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(295, 350)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'newMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 586)
        Me.Controls.Add(Me.ControlPanel)
        Me.Controls.Add(Me.SelectorPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "newMain"
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        Me.SelectorPanel.ResumeLayout(False)
        Me.CMS_AdobeList.ResumeLayout(False)
        Me.CMS_Search.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 도움말ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 정보ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RichTextBox1 As RichTextBox
End Class

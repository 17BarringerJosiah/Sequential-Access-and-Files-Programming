<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblMembers = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.Location = New System.Drawing.Point(282, 142)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(258, 147)
        Me.lstMembers.TabIndex = 0
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(395, 326)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(100, 20)
        Me.txtCount.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.SortToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateFileToolStripMenuItem, Me.AddMemberToolStripMenuItem, Me.DeleteMemberToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CreateFileToolStripMenuItem
        '
        Me.CreateFileToolStripMenuItem.Name = "CreateFileToolStripMenuItem"
        Me.CreateFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CreateFileToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CreateFileToolStripMenuItem.Text = "Create File"
        '
        'AddMemberToolStripMenuItem
        '
        Me.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        Me.AddMemberToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.AddMemberToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AddMemberToolStripMenuItem.Text = "Add Member"
        '
        'DeleteMemberToolStripMenuItem
        '
        Me.DeleteMemberToolStripMenuItem.Name = "DeleteMemberToolStripMenuItem"
        Me.DeleteMemberToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.DeleteMemberToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DeleteMemberToolStripMenuItem.Text = "Delete Member"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendToolStripMenuItem, Me.DescendToolStripMenuItem})
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'AscendToolStripMenuItem
        '
        Me.AscendToolStripMenuItem.Name = "AscendToolStripMenuItem"
        Me.AscendToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AscendToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AscendToolStripMenuItem.Text = "Ascend"
        '
        'DescendToolStripMenuItem
        '
        Me.DescendToolStripMenuItem.Name = "DescendToolStripMenuItem"
        Me.DescendToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DescendToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DescendToolStripMenuItem.Text = "Descend"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(354, 329)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(35, 13)
        Me.lblCount.TabIndex = 4
        Me.lblCount.Text = "Count"
        '
        'lblMembers
        '
        Me.lblMembers.AutoSize = True
        Me.lblMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembers.Location = New System.Drawing.Point(374, 119)
        Me.lblMembers.Name = "lblMembers"
        Me.lblMembers.Size = New System.Drawing.Size(82, 20)
        Me.lblMembers.TabIndex = 5
        Me.lblMembers.Text = "Members"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMembers)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMembers As ListBox
    Friend WithEvents txtCount As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AscendToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCount As Label
    Friend WithEvents lblMembers As Label
End Class

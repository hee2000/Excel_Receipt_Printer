<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridView = New System.Windows.Forms.DataGridView()
        Me.GridRCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFilterCriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdRollback = New System.Windows.Forms.Button()
        Me.optFilter = New System.Windows.Forms.RadioButton()
        Me.optFull = New System.Windows.Forms.RadioButton()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSelectedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilteredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdFilter = New System.Windows.Forms.Button()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridRCMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridView
        '
        Me.gridView.AllowUserToResizeRows = False
        Me.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridView.ContextMenuStrip = Me.GridRCMenu
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridView.Location = New System.Drawing.Point(-1, 101)
        Me.gridView.Name = "gridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridView.RowHeadersVisible = False
        Me.gridView.Size = New System.Drawing.Size(776, 463)
        Me.gridView.TabIndex = 0
        '
        'GridRCMenu
        '
        Me.GridRCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.InsertToolStripMenuItem, Me.SetFilterCriteriaToolStripMenuItem, Me.PrintSelectedToolStripMenuItem})
        Me.GridRCMenu.Name = "GridRCMenu"
        Me.GridRCMenu.Size = New System.Drawing.Size(147, 114)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'SetFilterCriteriaToolStripMenuItem
        '
        Me.SetFilterCriteriaToolStripMenuItem.Name = "SetFilterCriteriaToolStripMenuItem"
        Me.SetFilterCriteriaToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SetFilterCriteriaToolStripMenuItem.Text = "Filter"
        '
        'PrintSelectedToolStripMenuItem
        '
        Me.PrintSelectedToolStripMenuItem.Name = "PrintSelectedToolStripMenuItem"
        Me.PrintSelectedToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintSelectedToolStripMenuItem.Text = "Print Selected"
        '
        'cmdLoad
        '
        Me.cmdLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdLoad.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdLoad.FlatAppearance.BorderSize = 0
        Me.cmdLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.Location = New System.Drawing.Point(8, 37)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(94, 46)
        Me.cmdLoad.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmdLoad, "Load New")
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'cmdRollback
        '
        Me.cmdRollback.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdRollback.FlatAppearance.BorderSize = 0
        Me.cmdRollback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdRollback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdRollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRollback.Location = New System.Drawing.Point(208, 37)
        Me.cmdRollback.Name = "cmdRollback"
        Me.cmdRollback.Size = New System.Drawing.Size(94, 46)
        Me.cmdRollback.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmdRollback, "Rollback")
        Me.cmdRollback.UseVisualStyleBackColor = True
        '
        'optFilter
        '
        Me.optFilter.AutoSize = True
        Me.optFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFilter.Location = New System.Drawing.Point(607, 183)
        Me.optFilter.Name = "optFilter"
        Me.optFilter.Size = New System.Drawing.Size(62, 24)
        Me.optFilter.TabIndex = 3
        Me.optFilter.Text = "Filter"
        Me.optFilter.UseVisualStyleBackColor = True
        Me.optFilter.Visible = False
        '
        'optFull
        '
        Me.optFull.AutoSize = True
        Me.optFull.Checked = True
        Me.optFull.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFull.Location = New System.Drawing.Point(607, 153)
        Me.optFull.Name = "optFull"
        Me.optFull.Size = New System.Drawing.Size(66, 24)
        Me.optFull.TabIndex = 4
        Me.optFull.TabStop = True
        Me.optFull.Text = "Table"
        Me.optFull.UseVisualStyleBackColor = True
        Me.optFull.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(108, 37)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(94, 46)
        Me.cmdSave.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cmdSave, "Save Changes")
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Location = New System.Drawing.Point(550, 245)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(112, 29)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.Visible = False
        '
        'cmdInfo
        '
        Me.cmdInfo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdInfo.FlatAppearance.BorderSize = 0
        Me.cmdInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInfo.Location = New System.Drawing.Point(669, 37)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(94, 46)
        Me.cmdInfo.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cmdInfo, "Information")
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.RecordToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(775, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadNewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'LoadNewToolStripMenuItem
        '
        Me.LoadNewToolStripMenuItem.Name = "LoadNewToolStripMenuItem"
        Me.LoadNewToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LoadNewToolStripMenuItem.Text = "Load New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RecordToolStripMenuItem
        '
        Me.RecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1, Me.SelectAllToolStripMenuItem1, Me.InsertNewToolStripMenuItem, Me.PrintSelectedToolStripMenuItem1})
        Me.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem"
        Me.RecordToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RecordToolStripMenuItem.Text = "Record"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SelectAllToolStripMenuItem1
        '
        Me.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1"
        Me.SelectAllToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.SelectAllToolStripMenuItem1.Text = "Select All"
        '
        'InsertNewToolStripMenuItem
        '
        Me.InsertNewToolStripMenuItem.Name = "InsertNewToolStripMenuItem"
        Me.InsertNewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.InsertNewToolStripMenuItem.Text = "Insert New"
        '
        'PrintSelectedToolStripMenuItem1
        '
        Me.PrintSelectedToolStripMenuItem1.Name = "PrintSelectedToolStripMenuItem1"
        Me.PrintSelectedToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.PrintSelectedToolStripMenuItem1.Text = "Print Selected"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetFilterToolStripMenuItem, Me.FullTableToolStripMenuItem, Me.FilteredToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ViewToolStripMenuItem.Text = "Filter"
        '
        'SetFilterToolStripMenuItem
        '
        Me.SetFilterToolStripMenuItem.Name = "SetFilterToolStripMenuItem"
        Me.SetFilterToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SetFilterToolStripMenuItem.Text = "Set Filter"
        '
        'FullTableToolStripMenuItem
        '
        Me.FullTableToolStripMenuItem.CheckOnClick = True
        Me.FullTableToolStripMenuItem.Enabled = False
        Me.FullTableToolStripMenuItem.Name = "FullTableToolStripMenuItem"
        Me.FullTableToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FullTableToolStripMenuItem.Text = "Full Table"
        '
        'FilteredToolStripMenuItem
        '
        Me.FilteredToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.FilteredToolStripMenuItem.CheckOnClick = True
        Me.FilteredToolStripMenuItem.Enabled = False
        Me.FilteredToolStripMenuItem.Name = "FilteredToolStripMenuItem"
        Me.FilteredToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FilteredToolStripMenuItem.Text = "Filtered Table"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdDelete.FlatAppearance.BorderSize = 0
        Me.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Location = New System.Drawing.Point(308, 37)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(94, 46)
        Me.cmdDelete.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.cmdDelete, "Delete")
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdFilter
        '
        Me.cmdFilter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdFilter.FlatAppearance.BorderSize = 0
        Me.cmdFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilter.Location = New System.Drawing.Point(408, 37)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(94, 46)
        Me.cmdFilter.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.cmdFilter, "Filter")
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 564)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gridView)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdFilter)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.optFull)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.optFilter)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.cmdRollback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Start"
        Me.Text = "Start"
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridRCMenu.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdRollback As System.Windows.Forms.Button
    Friend WithEvents GridRCMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetFilterCriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optFilter As System.Windows.Forms.RadioButton
    Friend WithEvents optFull As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents PrintSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdInfo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilteredToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSelectedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
End Class

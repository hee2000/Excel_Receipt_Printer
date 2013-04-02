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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridView = New System.Windows.Forms.DataGridView()
        Me.GridRCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFilterCriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdRollback = New System.Windows.Forms.Button()
        Me.optFilter = New System.Windows.Forms.RadioButton()
        Me.optFull = New System.Windows.Forms.RadioButton()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridRCMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridView
        '
        Me.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridView.ContextMenuStrip = Me.GridRCMenu
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.gridView.Location = New System.Drawing.Point(-1, 88)
        Me.gridView.Name = "gridView"
        Me.gridView.Size = New System.Drawing.Size(776, 476)
        Me.gridView.TabIndex = 0
        '
        'GridRCMenu
        '
        Me.GridRCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSelectedToolStripMenuItem, Me.SetFilterCriteriaToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.GridRCMenu.Name = "GridRCMenu"
        Me.GridRCMenu.Size = New System.Drawing.Size(147, 70)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
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
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.Location = New System.Drawing.Point(12, 7)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(72, 68)
        Me.cmdLoad.TabIndex = 1
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdRollback
        '
        Me.cmdRollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRollback.Location = New System.Drawing.Point(193, 7)
        Me.cmdRollback.Name = "cmdRollback"
        Me.cmdRollback.Size = New System.Drawing.Size(68, 68)
        Me.cmdRollback.TabIndex = 2
        Me.cmdRollback.UseVisualStyleBackColor = True
        '
        'optFilter
        '
        Me.optFilter.AutoSize = True
        Me.optFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFilter.Location = New System.Drawing.Point(600, 46)
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
        Me.optFull.Location = New System.Drawing.Point(600, 16)
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
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(102, 7)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(69, 68)
        Me.cmdSave.TabIndex = 5
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
        Me.cmdInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInfo.Location = New System.Drawing.Point(686, 7)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(68, 68)
        Me.cmdInfo.TabIndex = 7
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 564)
        Me.Controls.Add(Me.gridView)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.optFilter)
        Me.Controls.Add(Me.optFull)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdRollback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Start"
        Me.Text = "Start"
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridRCMenu.ResumeLayout(False)
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
End Class

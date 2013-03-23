Imports System.Windows.Forms

Public Class printDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ReportViewer.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chkSub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSub.CheckedChanged
        If chkSub.Checked = True Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        Else
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
        End If
    End Sub

    Private Sub printDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

    Private Sub chkColl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColl.CheckedChanged
        If chkColl.Checked = True Then
            TextBox1.Enabled = False
        Else
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
       
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        If chkDate.Checked = True Then
            DateTimePicker1.Enabled = False
        Else
            DateTimePicker1.Enabled = True
        End If

    End Sub
End Class

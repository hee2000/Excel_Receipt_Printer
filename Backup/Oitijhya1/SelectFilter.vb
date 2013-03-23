Imports System.Windows.Forms

Public Class SelectFilter
    Public chk(gridDataTable.Columns.Count) As CheckBox
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim checkTemp(gridDataTable.Columns.Count) As CheckBox
        Dim index As Integer = 0
        Dim chkResponse(gridDataTable.Columns.Count) As Boolean
        For Each Control In Me.Controls
            If Control.GetType Is GetType(System.Windows.Forms.CheckBox) Then
                checkTemp(index) = Control
                chkResponse(index) = checkTemp(index).Checked
                'MsgBox(checkTemp(index).Checked.ToString)
                index += 1
            End If
        Next
        Dim filt(index + 1) As Integer
        Dim ctr As Integer = 0
        For i = 0 To checkTemp.Length()
            filt(i) = -1
        Next
        Dim filtVal As String = String.Empty
        For i = 0 To checkTemp.Length() - 1
            If (chkResponse(i) = True) Then
                filt(ctr) = i
                ctr += 1
            End If
        Next
        Start.showFilteredResults(filt)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        Start.Enabled() = True
    End Sub

    Private Sub Filter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lctr As Integer = 0
        Dim hctr As Integer = 10
        For i As Integer = 0 To gridDataTable.Columns.Count - 1
            chk(i) = New CheckBox()
            chk(i).Visible = True
            chk(i).Text = gridDataTable.Columns(i).Caption
            If (hctr > Me.Height - 100) Then
                hctr = 10
                lctr = lctr + 150
            End If
            chk(i).Left = 10 + lctr
            chk(i).Top = hctr
            hctr += 30
            If (Me.Width < lctr + 100) Then
                Me.Width = lctr + 100
            End If
            chk(i).Checked = True
            Me.Controls.Add(chk(i))
        Next

    End Sub
End Class

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReportViewer

    Dim cr As New ReportDocument
    Dim crCon As New ConnectionInfo
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim CrTables As Tables
    Dim CrTable As Table
    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        


        cr.Load(Application.StartupPath & "\Reports\oitijhya.rpt")

        cr.Database.Tables(0).SetDataSource(reportTable)
        ' Load Report to cr viewer
        CrystalReportViewer1.ReportSource = cr
        Try
            CrystalReportViewer1.Refresh()
        Catch
            MsgBox("Error. Database inconsistent. Please check all the fields and try again.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
Imports Microsoft.Reporting.WinForms

Public Class OathOfUndertakingForm
    Private Sub OathOfUndertakingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DateNow As String = Date.Now.ToString("MM/dd/yyyy")
        Dim NameOfEstablishment As New ReportParameter("NameOfEstablishment", IEFReqForm.NameOfEstablishmentReq.Text)
        Dim DateParameter As New ReportParameter("DateNow", DateNow)
        ReportViewer1.LocalReport.SetParameters(NameOfEstablishment)
        ReportViewer1.LocalReport.SetParameters(DateParameter)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
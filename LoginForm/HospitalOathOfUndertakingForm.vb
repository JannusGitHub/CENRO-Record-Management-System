Imports Microsoft.Reporting.WinForms

Public Class HospitalOathOfUndertakingForm
    Private Sub HospitalOathOfUndertakingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DateNow As String = Date.Now.ToString("MM/dd/yyyy")
        Dim NameOfEstablishment As New ReportParameter("NameOfEstablishment", HospitalAndMedicalReqForm.NameOfEstablishment1.Text)
        Dim DateParameter As New ReportParameter("DateNow", DateNow)
        ReportViewer1.LocalReport.SetParameters(NameOfEstablishment)
        ReportViewer1.LocalReport.SetParameters(DateParameter)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
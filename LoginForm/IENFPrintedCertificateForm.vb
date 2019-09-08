Imports Microsoft.Reporting.WinForms

Public Class IENFPrintedCertificateForm
    Private Sub IENFPrintedCertificateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ControlNumber As New ReportParameter("ControlNumber", IENFCertificationPopupForm.ControlNumber1.Text)
        Dim NameOfEstablishment As New ReportParameter("NameOfEstablishment", IENFCertificationPopupForm.NameOfEstablishment1.Text)
        Dim Address As New ReportParameter("Address", IENFCertificationPopupForm.Address1.Text)
        Dim Owner As New ReportParameter("Owner", IENFCertificationPopupForm.Owner1.Text)
        Dim DateNow As New ReportParameter("DateNow", IENFCertificationPopupForm.DateNow1.Text)
        ReportViewer1.LocalReport.SetParameters(ControlNumber)
        ReportViewer1.LocalReport.SetParameters(NameOfEstablishment)
        ReportViewer1.LocalReport.SetParameters(Address)
        ReportViewer1.LocalReport.SetParameters(Owner)
        ReportViewer1.LocalReport.SetParameters(DateNow)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
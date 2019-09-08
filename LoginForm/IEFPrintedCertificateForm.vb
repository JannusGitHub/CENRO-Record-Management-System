Imports Microsoft.Reporting.WinForms

Public Class IEFPrintedCertificateForm
    Private Sub Printreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ControlNumber As New ReportParameter("ControlNumber", IEFCertificationPopupForm.ControlNumber1.Text)
        Dim NameOfEstablishment As New ReportParameter("NameOfEstablishment", IEFCertificationPopupForm.NameOfEstablishment1.Text)
        Dim Address As New ReportParameter("Address", IEFCertificationPopupForm.Address1.Text)
        Dim Owner As New ReportParameter("Owner", IEFCertificationPopupForm.Owner1.Text)
        Dim DateNow As New ReportParameter("DateNow", IEFCertificationPopupForm.DateNow1.Text)
        ReportViewer1.LocalReport.SetParameters(ControlNumber)
        ReportViewer1.LocalReport.SetParameters(NameOfEstablishment)
        ReportViewer1.LocalReport.SetParameters(Address)
        ReportViewer1.LocalReport.SetParameters(Owner)
        ReportViewer1.LocalReport.SetParameters(DateNow)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
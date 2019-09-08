Imports Microsoft.Reporting.WinForms

Public Class FastfoodPrintedCertificationForm
    Private Sub FastfoodPrintedCertificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ControlNumber As New ReportParameter("ControlNumber", FastfoodCertificationPopupForm.ControlNumber1.Text)
        Dim NameOfEstablishment As New ReportParameter("NameOfEstablishment", FastfoodCertificationPopupForm.NameOfEstablishment1.Text)
        Dim Address As New ReportParameter("Address", FastfoodCertificationPopupForm.Address1.Text)
        Dim Owner As New ReportParameter("Owner", FastfoodCertificationPopupForm.Owner1.Text)
        Dim DateNow As New ReportParameter("DateNow", FastfoodCertificationPopupForm.DateNow1.Text)
        ReportViewer1.LocalReport.SetParameters(ControlNumber)
        ReportViewer1.LocalReport.SetParameters(NameOfEstablishment)
        ReportViewer1.LocalReport.SetParameters(Address)
        ReportViewer1.LocalReport.SetParameters(Owner)
        ReportViewer1.LocalReport.SetParameters(DateNow)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
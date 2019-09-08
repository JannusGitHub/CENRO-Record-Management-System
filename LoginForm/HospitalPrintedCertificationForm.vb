Imports Microsoft.Reporting.WinForms

Public Class HospitalPrintedCertificationForm
    Private Sub HospitalPrintCertificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ControlNumber As New ReportParameter("ControlNumber", HospitalCertificationPopupForm.ControlNumber1.Text)
        Dim NameOfEstablishment As New ReportParameter("NameOfEstablishment", HospitalCertificationPopupForm.NameOfEstablishment1.Text)
        Dim Address As New ReportParameter("Address", HospitalCertificationPopupForm.Address1.Text)
        Dim Owner As New ReportParameter("Owner", HospitalCertificationPopupForm.Owner1.Text)
        Dim DateNow As New ReportParameter("DateNow", HospitalCertificationPopupForm.DateNow1.Text)
        ReportViewer1.LocalReport.SetParameters(ControlNumber)
        ReportViewer1.LocalReport.SetParameters(NameOfEstablishment)
        ReportViewer1.LocalReport.SetParameters(Address)
        ReportViewer1.LocalReport.SetParameters(Owner)
        ReportViewer1.LocalReport.SetParameters(DateNow)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
Imports System.Data.SqlClient


Public Class HospitalCertificationPopupForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8; Initial Catalog=cenro_DB; Integrated Security=True")
    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        Try
            Dim command As New SqlCommand("SELECT * FROM HospitalAndMedicalEstablishment_tbl WHERE ControlNumber = @ControlNumber1", connection)
            command.Parameters.Add("@ControlNumber1", SqlDbType.VarChar).Value = ControlNumber1.Text
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            'open connection
            If connection.State = ConnectionState.Closed Then connection.Open()

            'declare variable reader to read data in database
            Dim reader As SqlDataReader = command.ExecuteReader

            If reader.Read = True Then
                'DECLARE VARIABLES TO READ THE DATA IN DATABASE
                Dim BrgyClearanceWithCTC As String = reader("BrgyClearanceWithCTC")
                Dim DTI_SEC As String = reader("DTI_SEC")
                Dim ECC As String = reader("ECC")
                Dim PTO As String = reader("PTO")
                Dim DP As String = reader("DP")
                Dim DENR_IDNumber As String = reader("DENR_IDNumber")
                Dim DOHAccreditation As String = reader("DOHAccreditation")
                Dim AccreditedWasteHauler As String = reader("AccreditedWasteHauler")



                'PRINT IF THE REQUIREMENTS ARE COMPLIANT
                If BrgyClearanceWithCTC = "Compliant" And DTI_SEC = "Compliant" And ECC = "Compliant" And PTO = "Compliant" And DP = "Compliant" And DENR_IDNumber = "Compliant" And DOHAccreditation = "Compliant" And AccreditedWasteHauler = "Compliant" Then
                    Me.Hide()
                    With HospitalPrintedCertificationForm
                        .TopLevel = False
                        Main.MDIpanel.Controls.Add(HospitalPrintedCertificationForm)
                        .BringToFront()
                        .Show()
                    End With
                    reader.Close()
                    connection.Close()
                Else
                    MessageBox.Show("An error occured! Please check the requirement/s.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
            reader.Close()
            If connection.State = ConnectionState.Open Then connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        With CertificationMainForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(CertificationMainForm)
            .BringToFront()
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Dim color As Color
        color = Color.FromArgb(232, 17, 35)
        If PictureBox2.Text = "" Then
            PictureBox2.BackColor = color
        End If
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Dim color As Color
        color = Color.FromArgb(255, 250, 250)
        If PictureBox2.Text = "" Then
            PictureBox2.BackColor = color
        End If
    End Sub

    Private Sub HospitalCertificationPopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub HospitalCertificationPopupForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control = True AndAlso e.KeyCode = Keys.P) Then
            Print.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.Escape) Then
            CancelButton.PerformClick()
        End If


    End Sub
End Class
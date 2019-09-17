Imports System.Data.SqlClient

Public Class IEFCertificationPopupForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8; Initial Catalog=cenro_DB; Integrated Security=True")
    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        Try
            Dim command As New SqlCommand("SELECT * FROM IndustrialEstablishmentFood_tbl WHERE ControlNumber = @ControlNumber1", connection)
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
                Dim BFAD As String = reader("BFAD")
                Dim AccreditedWasteHauler As String = reader("AccreditedWasteHauler")
                Dim SelfMonitoringReport As String = reader("SelfMonitoringReport")

                'PRINT IF THE REQUIREMENTS ARE COMPLIANT
                If BrgyClearanceWithCTC = "Compliant" And DTI_SEC = "Compliant" And ECC = "Compliant" And PTO = "Compliant" And DP = "Compliant" And BFAD = "Compliant" And AccreditedWasteHauler = "Compliant" And SelfMonitoringReport = "Compliant" Then
                    Me.Hide()
                    With IEFPrintedCertificateForm
                        .TopLevel = False
                        Main.MDIpanel.Controls.Add(IEFPrintedCertificateForm)
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

    Private Sub CertificationPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()

        Me.KeyPreview = True
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

    Private Sub IEFCertificationPopupForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control = True AndAlso e.KeyCode = Keys.P) Then
            Print.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.Escape) Then
            CancelButton.PerformClick()
        End If


    End Sub

    Private Sub ControlNumber1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ControlNumber1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NameOfEstablishment1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Owner1.KeyPress, NameOfEstablishment1.KeyPress, Address1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
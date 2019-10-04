Public Class FastfoodReportForm
    Private Sub FastfoodReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FastfoodDataSet.FastfoodCanteenAndRestaurant_tbl' table. You can move, or remove it, as needed.
        Me.FastfoodCanteenAndRestaurant_tblTableAdapter.Fill(Me.FastfoodDataSet.FastfoodCanteenAndRestaurant_tbl)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        '===============================HospitalEst.===================================
        Try
            If Not String.IsNullOrEmpty(SearchButton.Text) Then
                Dim keyword As String = Me.SearchButton.Text.Trim()
                Me.FastfoodCanteenAndRestaurant_tblBindingSource.Filter =
                    "(NameOfEstablishment LIKE '%" & keyword & "%')" &
                    "OR (Address LIKE '%" & keyword & "%')" &
                    "OR (EmailAddress LIKE '%" & keyword & "%')" &
                    "OR (CEO_President LIKE '%" & keyword & "%')" &
                    "OR (GeneralManager LIKE '%" & keyword & "%')" &
                    "OR (PollutionControlOfficer LIKE '%" & keyword & "%')" &
                    "OR (NatureOfBusiness LIKE '%" & keyword & "%')" &
                    "OR (ContactNumber LIKE '%" & keyword & "%')" &
                    "OR (NameOfAccreditedWasteHauler LIKE '%" & keyword & "%')" &
                    "OR (ControlNumber LIKE '%" & keyword & "%')"
                Me.ReportViewer1.RefreshReport()
            Else
                Me.FastfoodCanteenAndRestaurant_tblBindingSource.RemoveFilter()
                FastfoodReportForm_Load(sender, e)

            End If
        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message.ToString() + "Error Handler")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        With FastfoodCanteenAndRestoReportOption
            .TopLevel = False
            Main.MDIpanel.Controls.Add(FastfoodCanteenAndRestoReportOption)
            .BringToFront()
            .Show()
        End With
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

End Class
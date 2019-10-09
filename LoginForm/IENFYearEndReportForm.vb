Public Class IENFYearEndReportForm
    Private Sub IENFYearEndReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'IENFYearEndReportDataSet.YearEndReport_tbl1' table. You can move, or remove it, as needed.
        Me.YearEndReport_tbl1TableAdapter.FillIENF(Me.IENFYearEndReportDataSet.YearEndReport_tbl1)
        Me.ReportViewer1.RefreshReport()
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

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Try
            If Not String.IsNullOrEmpty(SearchButton.Text) Then
                Dim keyword As String = Me.SearchButton.Text.Trim()
                Me.YearEndReporttbl1BindingSource.Filter =
                    "(Convert(IndustrialEstablishmentNonFoodID, 'System.String') LIKE '%" & keyword & "%')" &
                    "OR (NameOfEstablishment LIKE '%" & keyword & "%')" &
                    "OR (Address LIKE '%" & keyword & "%')" &
                    "OR (ControlNumber LIKE '%" & keyword & "%')" &
                    "OR (Status LIKE '%" & keyword & "%')"
                Me.ReportViewer1.RefreshReport()
            Else
                Me.YearEndReporttbl1BindingSource.RemoveFilter()
                IENFYearEndReportForm_Load(sender, e)

            End If
        Catch ex As Exception
            MessageBox.Show("Error! " + ex.Message.ToString() + " Error Handler")
        End Try
    End Sub

    Private Sub SearchButton_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchButton.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Not String.IsNullOrEmpty(SearchButton.Text) Then
                    Dim keyword As String = Me.SearchButton.Text.Trim()
                    Me.YearEndReporttbl1BindingSource.Filter =
                        "(Convert(IndustrialEstablishmentNonFoodID, 'System.String') LIKE '%" & keyword & "%')" &
                        "OR (NameOfEstablishment LIKE '%" & keyword & "%')" &
                        "OR (Address LIKE '%" & keyword & "%')" &
                        "OR (ControlNumber LIKE '%" & keyword & "%')" &
                        "OR (Status LIKE '%" & keyword & "%')"
                    Me.ReportViewer1.RefreshReport()
                Else
                    Me.YearEndReporttbl1BindingSource.RemoveFilter()
                    IENFYearEndReportForm_Load(sender, e)

                End If
            Catch ex As Exception
                MessageBox.Show("Error! " + ex.Message.ToString() + " Error Handler")
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        With IENFReportOption
            .TopLevel = False
            Main.MDIpanel.Controls.Add(IENFReportOption)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
Public Class LogHistoryForm
    Private Sub LogHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LogHistoryDataSet.LogHistory_tbl' table. You can move, or remove it, as needed.
        Me.LogHistory_tblTableAdapter.Fill(Me.LogHistoryDataSet.LogHistory_tbl)

        Me.ReportViewer1.RefreshReport()
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

End Class
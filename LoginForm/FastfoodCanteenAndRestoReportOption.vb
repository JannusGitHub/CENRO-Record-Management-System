Public Class FastfoodCanteenAndRestoReportOption
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each form As Form In Main.MDIpanel.Controls
            form.Close()
        Next
        With FastfoodReportForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(FastfoodReportForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        With ReportCategory
            .TopLevel = False
            Main.MDIpanel.Controls.Add(ReportCategory)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each form As Form In Main.MDIpanel.Controls
            form.Close()
        Next
        With FastFoodYearEndReportForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(FastFoodYearEndReportForm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
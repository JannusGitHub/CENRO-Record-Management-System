Public Class Category

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each form As Form In Main.MDIpanel.Controls
            form.Close()
        Next
        With IEFForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(IEFForm)
            .BringToFront()
            .Show()
        End With
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each form As Form In Main.MDIpanel.Controls
            form.Close()
        Next
        With IENFForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(IENFForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each form As Form In Main.MDIpanel.Controls
            form.Close()
        Next
        With HospitalAndEstablishmentForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(HospitalAndEstablishmentForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each form As Form In Main.MDIpanel.Controls
            form.Close()
        Next
        With FastfoodCanteenAndRestoForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(FastfoodCanteenAndRestoForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Category_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Activate()
    End Sub
End Class
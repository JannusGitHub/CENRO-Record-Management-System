Imports System.Windows.Forms.Button

Public Class Settings
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        Main.Panel1.BackColor = ColorDialog1.Color
        Main.BackColor = ColorDialog1.Color
        Main.Panel3.BackColor = ColorDialog1.Color
        'For Each ctrl As Control In Main.Controls
        '    If TypeOf (ctrl) Is Panel Then
        '        ctrl.BackColor = ColorDialog1.Color
        '    End If
        'Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
        'Main.Button1.ForeColor = ColorDialog1.Color
        'Main.Button2.ForeColor = ColorDialog1.Color
        'Main.Button3.ForeColor = ColorDialog1.Color
        'Main.Button4.ForeColor = ColorDialog1.Color
        'Main.Button5.ForeColor = ColorDialog1.Color
        'Main.Button6.ForeColor = ColorDialog1.Color
        'Main.ActivateButton.ForeColor = ColorDialog1.Color
        'Main.HistoryButton.ForeColor = ColorDialog1.Color
        'Main.Button7.ForeColor = ColorDialog1.Color
        'Main.Datenow.ForeColor = ColorDialog1.Color
        'Main.Datenow2.ForeColor = ColorDialog1.Color
        'Main.ForeColor = ColorDialog1.Color
        For Each buttonCtrl As Control In Main.Controls.OfType(Of Button)
            buttonCtrl.ForeColor = ColorDialog1.Color
        Next
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox3.Width += 48
        If PictureBox3.Width >= 264 Then
            Login.Show()
            Me.Close()
        End If
    End Sub

End Class
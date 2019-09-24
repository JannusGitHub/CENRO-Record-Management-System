Imports System.Data.SqlClient


Public Class InspectorForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8; Initial Catalog=cenro_DB; Integrated Security=True")
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub InspectorForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim message As String = "Do you want to exit?"
        Dim caption As String = "Confirmation"
        Dim icons As String = MessageBoxIcon.Question
        Dim buttons As String = MessageBoxButtons.YesNo
        Dim result As DialogResult
        result = MessageBox.Show(Me, message, caption, buttons, icons)
        If result = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With InspectorCategoryForm
            .TopLevel = False
            MDIpanel.Controls.Add(InspectorCategoryForm)
            .BringToFront()
            .Show()
        End With
        activeButton.Height = Button1.Height
        activeButton.Top = Button1.Top
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim message As String = "Do you want to logout?"
        Dim caption As String = "Confirmation"
        Dim icons As String = MessageBoxIcon.Question
        Dim buttons As String = MessageBoxButtons.YesNo
        Dim result As DialogResult
        result = MessageBox.Show(Me, message, caption, buttons, icons)

        Dim Inpector As String = "Inpector"
        Dim Logout As String = "Logged Out"
        Dim dateofloghistory As String = Date.Now.ToString("dd MMM yyyy hh:mm:ss")
        Dim Username As String = Login.Username.Text

        If result = DialogResult.No Then
            Me.Refresh()
        Else
            Dim insertquery As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username & "', '" & Inpector & "', '" & Logout & "', '" & dateofloghistory & "')"
            Dim cmd As New SqlCommand(insertquery, connection)
            connection.Open()
            cmd.ExecuteNonQuery()
            Login.Username.Clear()
            Login.Password.Clear()
            Login.Show()
            Login.Refresh()
            Login.Username.Focus()
            If Login.showpassword.Checked = True Then
                Login.showpassword.Checked = False
            End If
            Me.Dispose()
            Login.Username.Clear()
            Login.Password.Clear()
            connection.Close()
        End If
        activeButton.Height = Button3.Height
        activeButton.Top = Button3.Top
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Datenow.Text = Date.Now.ToString("MMM dd, yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Datenow2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub InspectorForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class ForgotPasswordform
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Login.Show()
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
        color = Color.FromArgb(255, 255, 255)
        If PictureBox2.Text = "" Then
            PictureBox2.BackColor = color
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        Dim command As New SqlCommand("SELECT * FROM user_tbl WHERE Username = @Username and Question = @Question and Answer = @Answer", connection)
        command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username.Text
        command.Parameters.Add("@Question", SqlDbType.VarChar).Value = Question.Text
        command.Parameters.Add("@Answer", SqlDbType.VarChar).Value = Answer.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 And NewPasswordlbl.Enabled = False And NewPassword.Enabled = False And ConfirmPasswordlbl.Enabled = False And ConfirmPassword.Enabled = False And ChangePasswordbtn.Enabled = False Then
            NewPasswordlbl.Enabled = True
            NewPassword.Enabled = True
            ConfirmPasswordlbl.Enabled = True
            ConfirmPassword.Enabled = True
            ChangePasswordbtn.Enabled = True
            Submitbtn.Enabled = False
            Username.Enabled = False
            Question.Enabled = False
            Answer.Enabled = False
            MessageBox.Show("Success!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Public Function Md5FromString(ByVal Source As String) As String
        Dim bytes() As Byte
        Dim stringBuilder As New StringBuilder()
        If String.IsNullOrEmpty(Source) Then
            Throw New ArgumentNullException
        End If

        bytes = Encoding.Default.GetBytes(Source)
        bytes = MD5.Create().ComputeHash(bytes)
        For x As Integer = 0 To bytes.Length - 1
            stringBuilder.Append(bytes(x).ToString("x2"))
        Next
        Return stringBuilder.ToString
    End Function

    Private Sub ChangePasswordbtn_Click(sender As Object, e As EventArgs) Handles ChangePasswordbtn.Click
        Dim hashCode As Login
        hashCode = New Login()

        Try
            Dim username As String
            username = Me.Username.Text
            connection.Open()

            'Update the password of current user
            If NewPassword.Text = "" Then
                MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ConfirmPassword.Text = "" Then
                MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                MessageBox.Show("Password didn't matched!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf NewPassword.Text = ConfirmPassword.Text Then
                Dim command = New SqlCommand("UPDATE user_tbl set Password = '" & hashCode.Md5FromString(ConfirmPassword.Text) & "' where Username = '" & username & "'", connection)
                command.ExecuteNonQuery()
                MessageBox.Show("Successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            'Show error message if occured during program execution
            MessageBox.Show(ex.Message, "Error execution!")
        Finally
            'Finally close the connection
            connection.Close()
        End Try
    End Sub

    Private Sub ForgotPasswordform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub ForgotPasswordform_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Submitbtn.PerformClick()
        End If
    End Sub

    Private Sub Question_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Question.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NewPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles NewPassword.KeyDown
        Dim hashCode As Login
        hashCode = New Login()

        If e.KeyCode = Keys.Enter Then
            Try
                Dim username As String
                username = Me.Username.Text
                connection.Open()

                'Update the password of current user
                If NewPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf ConfirmPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                    MessageBox.Show("Password didn't matched!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf NewPassword.Text = ConfirmPassword.Text Then
                    Dim command = New SqlCommand("UPDATE user_tbl set Password = '" & hashCode.Md5FromString(ConfirmPassword.Text) & "' where Username = '" & username & "'", connection)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Login.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                'Show error message if occured during program execution
                MessageBox.Show(ex.Message, "Error execution!")
            Finally
                'Finally close the connection
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub ConfirmPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles ConfirmPassword.KeyDown
        Dim hashCode As Login
        hashCode = New Login()

        If e.KeyCode = Keys.Enter Then
            Try
                Dim username As String
                username = Me.Username.Text
                connection.Open()

                'Update the password of current user
                If NewPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf ConfirmPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                    MessageBox.Show("Password didn't matched!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf NewPassword.Text = ConfirmPassword.Text Then
                    Dim command = New SqlCommand("UPDATE user_tbl set Password = '" & hashCode.Md5FromString(ConfirmPassword.Text) & "' where Username = '" & username & "'", connection)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Login.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                'Show error message if occured during program execution
                MessageBox.Show(ex.Message, "Error execution!")
            Finally
                'Finally close the connection
                connection.Close()
            End Try
        End If
    End Sub
End Class
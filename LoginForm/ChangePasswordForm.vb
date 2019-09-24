Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class ChangePasswordForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")
    Private Sub ChangePasswordbtn_Click(sender As Object, e As EventArgs) Handles ChangePasswordbtn.Click
        Dim hashCode As Login
        hashCode = New Login()

        Try
            Dim username As String
            username = ForgotPasswordform.Username.Text
            connection.Open()

            'Update the password of current user
            If NewPassword.Text = "" Then
                MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Clear()
                ConfirmPassword.Clear()
                NewPassword.Refresh()
                ConfirmPassword.Refresh()
            ElseIf ConfirmPassword.Text = "" Then
                MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Clear()
                ConfirmPassword.Clear()
                NewPassword.Refresh()
                ConfirmPassword.Refresh()
            ElseIf NewPassword.Text = "" And ConfirmPassword.Text = "" Then
                MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Clear()
                ConfirmPassword.Clear()
                NewPassword.Refresh()
                ConfirmPassword.Refresh()
            ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                MessageBox.Show("Password didn't matched!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Clear()
                ConfirmPassword.Clear()
                NewPassword.Refresh()
                ConfirmPassword.Refresh()
            ElseIf NewPassword.Text = ConfirmPassword.Text Then
                Dim command = New SqlCommand("UPDATE user_tbl set Password = @ConfirmPassword where Username = '" & username & "'", connection)
                command.Parameters.AddWithValue("@ConfirmPassword", hashCode.Md5FromString(ConfirmPassword.Text))
                command.ExecuteNonQuery()
                MessageBox.Show("Successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login.Show()
                ForgotPasswordform.Username.Clear()
                ForgotPasswordform.Answer.Clear()
                If ForgotPasswordform.Question.Text = ForgotPasswordform.Question.SelectedItem Then
                    ForgotPasswordform.Question.Text = ""
                End If
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Login.Show()
        ForgotPasswordform.Username.Clear()
        ForgotPasswordform.Answer.Clear()
        If ForgotPasswordform.Question.Text = ForgotPasswordform.Question.SelectedItem Then
            ForgotPasswordform.Question.Text = ""
        End If
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

    Private Sub NewPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles NewPassword.KeyDown
        Dim hashCode As Login
        hashCode = New Login()

        If e.KeyCode = Keys.Enter Then
            Try
                Dim username As String
                username = ForgotPasswordform.Username.Text
                connection.Open()

                'Update the password of current user
                If NewPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf ConfirmPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf NewPassword.Text = "" And ConfirmPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                    MessageBox.Show("Password didn't matched!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf NewPassword.Text = ConfirmPassword.Text Then
                    Dim command = New SqlCommand("UPDATE user_tbl set Password = @ConfirmPassword where Username = '" & username & "'", connection)
                    command.Parameters.AddWithValue("@ConfirmPassword", hashCode.Md5FromString(ConfirmPassword.Text))
                    command.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Login.Show()
                    ForgotPasswordform.Username.Clear()
                    ForgotPasswordform.Answer.Clear()
                    If ForgotPasswordform.Question.Text = ForgotPasswordform.Question.SelectedItem Then
                        ForgotPasswordform.Question.Text = ""
                    End If
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
                username = ForgotPasswordform.Username.Text
                connection.Open()

                'Update the password of current user
                If NewPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf ConfirmPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf NewPassword.Text = "" And ConfirmPassword.Text = "" Then
                    MessageBox.Show("Please fill the blanks!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                    MessageBox.Show("Password didn't matched!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    NewPassword.Clear()
                    ConfirmPassword.Clear()
                    NewPassword.Refresh()
                    ConfirmPassword.Refresh()
                ElseIf NewPassword.Text = ConfirmPassword.Text Then
                    Dim command = New SqlCommand("UPDATE user_tbl set Password = @ConfirmPassword where Username = '" & username & "'", connection)
                    command.Parameters.AddWithValue("@ConfirmPassword", hashCode.Md5FromString(ConfirmPassword.Text))
                    command.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Login.Show()
                    ForgotPasswordform.Username.Clear()
                    ForgotPasswordform.Answer.Clear()
                    If ForgotPasswordform.Question.Text = ForgotPasswordform.Question.SelectedItem Then
                        ForgotPasswordform.Question.Text = ""
                    End If
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
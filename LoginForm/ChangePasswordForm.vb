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
        Dim salt As String = "62#&*!28!^%#"
        Dim encoder As New UTF8Encoding()
        Dim bytes() As Byte
        Dim stringBuilder As New StringBuilder()
        Dim md5Hasher As New MD5CryptoServiceProvider

        ' Get Bytes for "password"
        Dim passwordBytes As Byte() = encoder.GetBytes(Source)

        ' Get Bytes for "salt"
        Dim saltBytes As Byte() = encoder.GetBytes(salt)

        ' Creat new Array to store both "password" and "salt" bytes
        Dim passwordAndSaltBytes As Byte() = New Byte(passwordBytes.Length + saltBytes.Length - 1) {}

        ' Store "password" bytes
        For i As Integer = 0 To passwordBytes.Length - 1
            passwordAndSaltBytes(i) = passwordBytes(i)
        Next

        ' Append "salt" bytes
        For i As Integer = 0 To saltBytes.Length - 1
            passwordAndSaltBytes(i + passwordBytes.Length) = saltBytes(i)
        Next

        ' Compute hash value for "password" and "salt" bytes
        bytes = md5Hasher.ComputeHash(passwordAndSaltBytes)

        ' Create array which will hold hash and original "salt" bytes.
        Dim hashWithSaltBytes() As Byte = New Byte(bytes.Length + saltBytes.Length - 1) {}

        ' Copy hash bytes into resulting array.
        For x As Integer = 0 To bytes.Length - 1
            hashWithSaltBytes(x) = bytes(x)
        Next x

        ' Append salt bytes to the result.
        For x As Integer = 0 To saltBytes.Length - 1
            hashWithSaltBytes(bytes.Length + x) = saltBytes(x)
        Next x

        ' Convert result into a base64-encoded string.
        Dim hashValue As String
        hashValue = Convert.ToBase64String(hashWithSaltBytes)

        bytes = Encoding.Default.GetBytes(hashValue)
        bytes = SHA256.Create().ComputeHash(bytes)
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
Imports System.Data.SqlClient

Public Class ForgotPasswordform
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Login.Show()
        Username.Clear()
        If Question.Text = Question.SelectedItem Then
            Question.Text = ""
        End If
        Answer.Clear()
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

    Private Sub ForgotPasswordform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
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

    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        Try
            If Username.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Username.Focus()
                Username.Clear()
                If Question.Text = Question.SelectedItem Then
                    Question.Text = ""
                End If
                Answer.Clear()
            ElseIf Answer.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Answer.Focus()
                Username.Clear()
                If Question.Text = Question.SelectedItem Then
                    Question.Text = ""
                End If
                Answer.Clear()
            ElseIf Question.SelectedItem = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Question.Focus()
                Username.Clear()
                If Question.Text = Question.SelectedItem Then
                    Question.Text = ""
                End If
                Answer.Clear()
            Else
                Dim selectQuery As String = "SELECT * FROM user_tbl WHERE Username = @Username and Question = @Question and Answer = @Answer"
                Dim Command As New SqlCommand(selectQuery, connection)
                Command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username.Text
                Command.Parameters.Add("@Question", SqlDbType.NVarChar).Value = Question.Text
                Command.Parameters.Add("@Answer", SqlDbType.NVarChar).Value = Answer.Text
                Dim adapter As New SqlDataAdapter(Command)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Clear()
                    If Question.Text = Question.SelectedItem Then
                        Question.Text = ""
                    End If
                    Answer.Clear()
                Else
                    MessageBox.Show("Correct!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ChangePasswordForm.Show()
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Username_KeyDown(sender As Object, e As KeyEventArgs) Handles Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Username.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Focus()
                    Username.Clear()
                    If Question.Text = Question.SelectedItem Then
                        Question.Text = ""
                    End If
                    Answer.Clear()
                ElseIf Answer.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Answer.Focus()
                    Username.Clear()
                    If Question.Text = Question.SelectedItem Then
                        Question.Text = ""
                    End If
                    Answer.Clear()
                ElseIf Question.SelectedItem = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Question.Focus()
                    Username.Clear()
                    If Question.Text = Question.SelectedItem Then
                        Question.Text = ""
                    End If
                    Answer.Clear()
                Else
                    Dim selectQuery As String = "SELECT * FROM user_tbl WHERE Username = @Username and Question = @Question and Answer = @Answer"
                    Dim Command As New SqlCommand(selectQuery, connection)
                    Command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username.Text
                    Command.Parameters.Add("@Question", SqlDbType.NVarChar).Value = Question.Text
                    Command.Parameters.Add("@Answer", SqlDbType.NVarChar).Value = Answer.Text
                    Dim adapter As New SqlDataAdapter(Command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    If table.Rows.Count() = 0 Then
                        MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Username.Clear()
                        If Question.Text = Question.SelectedItem Then
                            Question.Text = ""
                        End If
                        Answer.Clear()
                    Else
                        MessageBox.Show("Correct!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ChangePasswordForm.Show()
                        Me.Hide()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub Answer_KeyDown(sender As Object, e As KeyEventArgs) Handles Answer.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Username.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Focus()
                    Username.Clear()
                    If Question.Text = Question.SelectedItem Then
                        Question.Text = ""
                    End If
                    Answer.Clear()
                ElseIf Answer.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Answer.Focus()
                    Username.Clear()
                    If Question.Text = Question.SelectedItem Then
                        Question.Text = ""
                    End If
                    Answer.Clear()
                ElseIf Question.SelectedItem = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Question.Focus()
                    Username.Clear()
                    If Question.Text = Question.SelectedItem Then
                        Question.Text = ""
                    End If
                    Answer.Clear()
                Else
                    Dim selectQuery As String = "SELECT * FROM user_tbl WHERE Username = @Username and Question = @Question and Answer = @Answer"
                    Dim Command As New SqlCommand(selectQuery, connection)
                    Command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username.Text
                    Command.Parameters.Add("@Question", SqlDbType.NVarChar).Value = Question.Text
                    Command.Parameters.Add("@Answer", SqlDbType.NVarChar).Value = Answer.Text
                    Dim adapter As New SqlDataAdapter(Command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    If table.Rows.Count() = 0 Then
                        MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Username.Clear()
                        If Question.Text = Question.SelectedItem Then
                            Question.Text = ""
                        End If
                        Answer.Clear()
                    Else
                        MessageBox.Show("Correct!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ChangePasswordForm.Show()
                        Me.Hide()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
End Class
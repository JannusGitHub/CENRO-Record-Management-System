Imports System.Data.SqlClient

Public Class Login
    Dim mouse_move As System.Drawing.Point
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8; Initial Catalog=cenro_DB; Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim command As New SqlCommand("SELECT * FROM user_tbl WHERE Username = @Username and Password = @Password", connection)
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username.Text
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password.Text
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            'open connection
            If connection.State = ConnectionState.Closed Then connection.Open()

            'declare variable reader to read data in database
            Dim reader As SqlDataReader = command.ExecuteReader

            If Username.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Username.Clear()
                Password.Clear()
            ElseIf Password.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Username.Clear()
                Password.Clear()

            ElseIf reader.Read = True Then
                'declaring variables to store data from the database
                Dim usertype As String = reader("Usertype")
                Dim status As String = reader("Status")
                Dim Administrator As String = "Administrator"
                Dim Inpector As String = "Inpector"
                Dim Login As String = "Logged In"
                Dim dateofloghistory As String = Date.Now.ToString("dd MMM yyyy hh:mm:ss")

                'if admin exist then execute this
                If usertype = "Administrator" And status = "Active" Then
                    Dim insertquery As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username.Text & "', '" & Administrator & "', '" & Login & "', '" & dateofloghistory & "')"
                    Dim cmd As New SqlCommand(insertquery, connection)
                    reader.Close()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(("Successfully login as Administrator"), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Main.Show()
                    Me.Refresh()
                    Me.Hide()
                    connection.Close()

                ElseIf usertype = "Administrator" And status = "Inactive" Then
                    MessageBox.Show("Your account is inactive!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Clear()
                    Password.Clear()

                    'if inspector exist then execute this
                ElseIf usertype = "Inspector" And status = "Active" Then
                    Dim insertqueryinspector As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username.Text & "', '" & Inpector & "', '" & Login & "', '" & dateofloghistory & "')"
                    Dim cmd As New SqlCommand(insertqueryinspector, connection)
                    reader.Close()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(("Successfully login as Inspector"), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    InspectorForm.Show()
                    Me.Hide()
                    connection.Close()

                ElseIf usertype = "Inspector" And status = "Inactive" Then
                    MessageBox.Show("Your account is inactive!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Clear()
                    Password.Clear()
                End If

            ElseIf MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error) Then
                Username.Clear()
                Password.Clear()
            End If
            reader.Close()
            If connection.State = ConnectionState.Open Then connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End Sub


    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        'if mouse enter then the color should be changed
        Dim color As Color
        color = Color.FromArgb(232, 17, 35)
        If PictureBox2.Text = "" Then
            PictureBox2.BackColor = color
        End If
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        'if mouse leave then the color should be default
        Dim color As Color
        color = Color.FromArgb(255, 255, 255)
        If PictureBox2.Text = "" Then
            PictureBox2.BackColor = color
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles showpassword.CheckedChanged
        'if showpassword is checked then the passwordchar should be show or else the password char should be asterisk(*)
        If showpassword.Checked = True Then
            Password.PasswordChar = ""
        Else
            Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'show the forgot password form
        ForgotPasswordform.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'to show the date of variable name(Datenow) 
        Datenow.Text = Date.Now.ToString("MMM dd, yyyy")
    End Sub

    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'to enable the timer it should be set to (Timer1.Enabled = True)
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Datenow2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim command As New SqlCommand("SELECT * FROM user_tbl WHERE Username = @Username and Password = @Password", connection)
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username.Text
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password.Text
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                'open connection
                If connection.State = ConnectionState.Closed Then connection.Open()

                'declare variable reader to read data in database
                Dim reader As SqlDataReader = command.ExecuteReader

                If Username.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Clear()
                    Password.Clear()
                ElseIf Password.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Clear()
                    Password.Clear()

                ElseIf reader.Read = True Then
                    'declaring variables to store data from the database
                    Dim usertype As String = reader("Usertype")
                    Dim status As String = reader("Status")
                    Dim Administrator As String = "Administrator"
                    Dim Inpector As String = "Inpector"
                    Dim Login As String = "Logged In"
                    Dim dateofloghistory As String = Date.Now.ToString("dd MMM yyyy hh:mm:ss")

                    'if admin exist then execute this
                    If usertype = "Administrator" And status = "Active" Then
                        Dim insertquery As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username.Text & "', '" & Administrator & "', '" & Login & "', '" & dateofloghistory & "')"
                        Dim cmd As New SqlCommand(insertquery, connection)
                        reader.Close()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show(("Successfully login as Administrator"), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Main.Show()
                        Me.Hide()
                        connection.Close()

                    ElseIf usertype = "Administrator" And status = "Inactive" Then
                        MessageBox.Show("Your account is inactive!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Username.Clear()
                        Password.Clear()

                    ElseIf usertype = "Inspector" And status = "Active" Then
                        Dim insertquery As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username.Text & "', '" & Inpector & "', '" & Login & "', '" & dateofloghistory & "')"
                        Dim cmd As New SqlCommand(insertquery, connection)
                        reader.Close()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show(("Successfully login as Inspector"), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        InspectorForm.Show()
                        Me.Hide()
                        connection.Close()

                    ElseIf usertype = "Inspector" And status = "Inactive" Then
                        MessageBox.Show("Your account is inactive!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Username.Clear()
                        Password.Clear()
                    End If

                ElseIf MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error) Then
                    Username.Clear()
                    Password.Clear()
                End If
                reader.Close()
                If connection.State = ConnectionState.Open Then connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub Username_KeyDown(sender As Object, e As KeyEventArgs) Handles Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim command As New SqlCommand("SELECT * FROM user_tbl WHERE Username = @Username and Password = @Password", connection)
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username.Text
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password.Text
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                'open connection
                If connection.State = ConnectionState.Closed Then connection.Open()

                'declare variable reader to read data in database
                Dim reader As SqlDataReader = command.ExecuteReader

                If Username.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Clear()
                    Password.Clear()
                ElseIf Password.Text = "" Then
                    MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Username.Clear()
                    Password.Clear()

                ElseIf reader.Read = True Then
                    'declaring variables to store data from the database
                    Dim usertype As String = reader("Usertype")
                    Dim status As String = reader("Status")
                    Dim Administrator As String = "Administrator"
                    Dim Inpector As String = "Inpector"
                    Dim Login As String = "Logged In"
                    Dim dateofloghistory As String = Date.Now.ToString("dd MMM yyyy hh:mm:ss")

                    'if admin exist then execute this
                    If usertype = "Administrator" And status = "Active" Then
                        Dim insertquery As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username.Text & "', '" & Administrator & "', '" & Login & "', '" & dateofloghistory & "')"
                        Dim cmd As New SqlCommand(insertquery, connection)
                        reader.Close()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show(("Successfully login as Administrator"), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Main.Show()
                        Me.Hide()
                        connection.Close()

                    ElseIf usertype = "Administrator" And status = "Inactive" Then
                        MessageBox.Show("Your account is inactive!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Username.Clear()
                        Password.Clear()

                    ElseIf usertype = "Inspector" And status = "Active" Then
                        Dim insertquery As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username.Text & "', '" & Inpector & "', '" & Login & "', '" & dateofloghistory & "')"
                        Dim cmd As New SqlCommand(insertquery, connection)
                        reader.Close()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show(("Successfully login as Inspector"), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        InspectorForm.Show()
                        Me.Hide()
                        connection.Close()

                    ElseIf usertype = "Inspector" And status = "Inactive" Then
                        MessageBox.Show("Your account is inactive!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Username.Clear()
                        Password.Clear()
                    End If

                ElseIf MessageBox.Show("Incorrect please try again!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error) Then
                    Username.Clear()
                    Password.Clear()
                End If
                reader.Close()
                If connection.State = ConnectionState.Open Then connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub


    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class

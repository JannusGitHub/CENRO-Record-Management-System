Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo

Public Class Backup

    Dim database As String
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim get_servername As String
    Dim get_userid As String
    Dim get_password As String
    Dim constr As String
    Dim data_affector As Integer

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbServerName.Items.Add(My.Computer.Name.ToString)
            cmbServerName.Items.Add("Localhost\SQLServer")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.KeyPreview = True
    End Sub

    Private Sub Database_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDatabase.SelectedIndexChanged

    End Sub

    Private Sub Database_DropDown(sender As Object, e As EventArgs) Handles cmbDatabase.DropDown
        Try
            Me.Cursor = Cursors.WaitCursor
            cmbDatabase.Items.Clear()
            Dim servername As String = cmbServerName.Text.ToString
            Dim serverconnection As Microsoft.SqlServer.Management.Common.ServerConnection = New Microsoft.SqlServer.Management.Common.ServerConnection
            serverconnection.ServerInstance = servername
            serverconnection.LoginSecure = True

            If cmbAuth.SelectedIndex = 1 Then 'for login with username and password 
                serverconnection.LoginSecure = False
                serverconnection.Login = txtUsername.Text
                serverconnection.Password = txtPassword.Text
            End If

            Dim server As Server = New Server(serverconnection)

            Try
                For Each database As Database In server.Databases
                    cmbDatabase.Items.Add(database.Name)
                Next
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Dim exception As String = ex.Message
            End Try
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Backupbtn.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Filename As String
            get_servername = cmbServerName.Text.Trim
            get_userid = txtUsername.Text.Trim
            get_password = txtPassword.Text.Trim
            database = cmbDatabase.Text

            If cmbAuth.SelectedIndex = 0 Then
                'set data source connection without username and password if windows authentication is selected
                constr = "Data Source=" & get_servername & ";Initial Catalog=" & cmbDatabase.Text & ";Integrated Security=true"
            Else 'if sql server authentication(requires login is selected)
                constr = "Data Source=" & get_servername & ";Initial Catalog=" & cmbDatabase.Text & ";user id=" & get_userid & ";password=" & get_password & ";Integrated Security=false"
            End If

            con = New SqlConnection(constr) 'get connection string
            con.Open() 'open connection
            Dim strquery As String
            Dim save_dialog As New SaveFileDialog
            save_dialog.FileName = DateAndTime.DateString + " " + database
            'save_dialog.Filter = "SQL Server database backup files|*.bak"
            save_dialog.ShowDialog()
            Filename = save_dialog.FileName
            strquery = "backup database " & database & " to disk='" & Filename & "'"

            Try
                cmd = New SqlCommand(strquery, con)
                data_affector = cmd.ExecuteNonQuery
                MessageBox.Show("Backup has been successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub cmbAuth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAuth.SelectedIndexChanged
        If cmbAuth.SelectedIndex = 0 Then
            'disable log in
            txtPassword.Enabled = False
            txtUsername.Enabled = False
            txtUsername.Text = Nothing
            txtPassword.Text = Nothing
        Else
            'enable for SQL server authentication
            txtPassword.Enabled = True
            txtUsername.Enabled = True
            txtUsername.Text = Nothing
            txtPassword.Text = Nothing
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Restorebtn.Click
        Try
            Dim con2 As SqlConnection
            Dim cmd2 As SqlCommand
            Dim filename2 As String
            Dim strquery2 As String
            Dim database2 As String
            Dim get_servername2 As String
            'get the value selected in database name dropdown menu/combobox
            database2 = cmbDatabase.Text
            get_servername2 = cmbServerName.Text.Trim 'get selected value of server name dropdown menu

            Dim opendialog As New OpenFileDialog
            Dim constr2 As String
            'set sql connection data source using default master database
            constr2 = "Data Source=" & get_servername2 & ";Initial Catalog=master;Integrated Security=True"

            'open sql database to restore
            If opendialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                SqlConnection.ClearAllPools()
                con2 = New SqlConnection(constr2) 'get/set connection data source
                con2.Open() 'open connection
                filename2 = opendialog.FileName 'get the file name and path of the sql database selected
                'strquery2 = "Restore database " & database2 & " from disk='" & filename2 & "'" &
                '"WITH REPLACE"
                strquery2 = "USE Master ALTER DATABASE [" & database2 & "] SET Single_User WITH Rollback Immediate Restore database [" & database2 & "] FROM disk='" & filename2 & "' WITH REPLACE ALTER DATABASE [" & database2 & "] SET Multi_User "

                'execute command
                Try
                    cmd2 = New SqlCommand(strquery2, con2)
                    cmd2.ExecuteNonQuery()
                    MessageBox.Show("Database " + "'" & database2 & "'" + " has been restored successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Cursor = Cursors.Default
                    con2.Close()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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

    Private Sub Backup_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control = True AndAlso e.KeyCode = Keys.B) Then
            Backupbtn.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.R) Then
            Restorebtn.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbAuth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAuth.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
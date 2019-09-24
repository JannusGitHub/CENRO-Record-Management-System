Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography

Public Class UserManagementForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Try
            Dim ValidateEmail As Boolean
            ValidateEmail = Regex.IsMatch(EmailAddress.Text, "^([\w]+)@([\w]+)\.([\w]+)$", RegexOptions.IgnoreCase)

            If Firstname.Text = "" And Middlename.Text = "" And Lastname.Text = "" And Birthdate.Text = "" And Age.Text = "" And Gender.Text = "" And ContactNumber.Text = "" And EmailAddress.Text = "" And Division.Text = "" And Position.Text = "" And Usertype.Text = "" And Username.Text = "" And Password.Text = "" And ConfirmPassword.Text = "" And Question.Text = "" And Answer.Text = "" Then
                MessageBox.Show("All confirmation are required", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Firstname.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Middlename.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Lastname.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Birthdate.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Age.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Gender.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ContactNumber.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf EmailAddress.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Division.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Position.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Username.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Password.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ConfirmPassword.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Password.Text <> ConfirmPassword.Text Then
                MessageBox.Show("Password didn't matched!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not ValidateEmail Then
                MessageBox.Show("Invalid Email address", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmailAddress.Focus()
            ElseIf Usertype.SelectedIndex <> 0 And Usertype.SelectedIndex <> 1 Then
                MessageBox.Show("Invalid data", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Usertype.Focus()
            ElseIf Question.SelectedIndex <> 0 And Question.SelectedIndex <> 1 Then
                MessageBox.Show("Invalid data", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Question.Focus()
            ElseIf Gender.SelectedIndex <> 0 And Gender.SelectedIndex <> 1 Then
                MessageBox.Show("Invalid data", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Gender.Focus()
            ElseIf Password.Text = ConfirmPassword.Text And Gender.SelectedItem = "Male" Or Gender.SelectedItem = "Female" Then
                Dim Status As String = "Active"
                Dim insertquery As String = "INSERT INTO user_tbl(Firstname,Middlename,Lastname,Birthdate,Age,Gender,ContactNumber,EmailAddress,Division,Position,Username,Password,Question,Answer,Usertype,Status) VALUES(@Firstname,@Middlename,@Lastname,@Birthdate,@Age,@Gender,@ContactNumber,@EmailAddress,@Division,@Position,@Username,@Password,@Question,@Answer,@Usertype,'" & Status & "')"
                executequery(insertquery)
                MessageBox.Show("Registered Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Firstname.Clear()
                Middlename.Clear()
                Lastname.Clear()
                Birthdate.Refresh()
                Age.Clear()
                If Gender.Text = Gender.SelectedItem Then
                    Gender.Text = ""
                End If
                ContactNumber.Clear()
                EmailAddress.Clear()
                Division.Clear()
                Position.Clear()
                Username.Clear()
                Password.Clear()
                ConfirmPassword.Clear()
                If Question.Text = Question.SelectedItem Then
                    Question.Text = ""
                End If
                Answer.Clear()
                If Usertype.Text = Usertype.SelectedItem Then
                    Usertype.Text = ""
                ElseIf Usertype.Text = Usertype.Text Then
                    Usertype.Text = ""
                End If
            End If
            connection.Close()
            load_datagrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
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

    Public Sub executequery(ByVal query As String)
        Dim hashCode As UserManagementForm
        hashCode = New UserManagementForm()

        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Firstname", Firstname.Text)
        cmd.Parameters.AddWithValue("@Middlename", Middlename.Text)
        cmd.Parameters.AddWithValue("@Lastname", Lastname.Text)
        cmd.Parameters.Add("@Birthdate", SqlDbType.Date).Value = Birthdate.Text
        cmd.Parameters.AddWithValue("@Age", Age.Text)
        cmd.Parameters.AddWithValue("@Gender", Gender.SelectedItem)
        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber.Text)
        cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress.Text)
        cmd.Parameters.AddWithValue("@Division", Division.Text)
        cmd.Parameters.AddWithValue("@Position", Position.Text)
        cmd.Parameters.AddWithValue("@Username", Username.Text)
        cmd.Parameters.AddWithValue("@Password", hashCode.Md5FromString(Password.Text))
        cmd.Parameters.AddWithValue("@Question", Question.SelectedItem)
        cmd.Parameters.AddWithValue("@Answer", Answer.Text)
        cmd.Parameters.AddWithValue("@Usertype", Usertype.Text)
        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cenro_DBDataSet.user_tbl' table. You can move, or remove it, as needed.
        Me.User_tblTableAdapter.Fill(Me.Cenro_DBDataSet.user_tbl)

        Me.KeyPreview = True
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim hashCode As UserManagementForm
        hashCode = New UserManagementForm()

        Try
            Dim ValidateEmail As Boolean
            ValidateEmail = Regex.IsMatch(EmailEdit.Text, "^([\w]+)@([\w]+)\.([\w]+)$", RegexOptions.IgnoreCase)


            If UserID.Text = "" Then
                MessageBox.Show("Please enter ID", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserID.Focus()
            ElseIf FirstnameEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf MiddlenameEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf LastnameEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf AgeEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf GenderEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ContactNumberEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf EmailEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf DivisionEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf PositionEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf UsernameEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf PasswordEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf QuestionEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf AnswerEdit.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not ValidateEmail Then
                MessageBox.Show("Invalid Email address", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmailEdit.Focus()
            ElseIf UsertypeEdit.SelectedIndex <> 0 And UsertypeEdit.SelectedIndex <> 1 Then
                MessageBox.Show("Invalid data", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsertypeEdit.Focus()
            ElseIf QuestionEdit.SelectedIndex <> 0 And QuestionEdit.SelectedIndex <> 1 And QuestionEdit.SelectedIndex <> 2 And QuestionEdit.SelectedIndex <> 3 And QuestionEdit.SelectedIndex <> 4 Then
                MessageBox.Show("Invalid data", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                QuestionEdit.Focus()
            ElseIf GenderEdit.SelectedIndex <> 0 And GenderEdit.SelectedIndex <> 1 Then
                MessageBox.Show("Invalid data", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GenderEdit.Focus()
            Else
                Dim Updatequery As String = "Select * From user_tbl WHERE UserID = '" & UserID.Text & "' "
                Dim cmd As New SqlCommand(Updatequery, connection)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("No records found!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    clearedit()
                    UserID.Focus()
                Else
                    connection.Open()
                    cmd.Connection = connection
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "UPDATE user_tbl SET Firstname = '" & FirstnameEdit.Text & "', Middlename = '" & MiddlenameEdit.Text & "', Lastname = '" & LastnameEdit.Text & "', Birthdate = @Birthdate, Age = '" & AgeEdit.Text & "', Gender = '" & GenderEdit.SelectedItem & "', ContactNumber = '" & ContactNumberEdit.Text & "', EmailAddress = '" & EmailEdit.Text & "', Division = '" & DivisionEdit.Text & "', Position = '" & PositionEdit.Text & "',Usertype = @Usertype, Username = '" & UsernameEdit.Text & "', Password = '" & hashCode.Md5FromString(PasswordEdit.Text) & "', Answer = '" & AnswerEdit.Text & "', Question = @Question WHERE UserID = '" & UserID.Text & "' "
                    cmd.Parameters.Add("@Birthdate", SqlDbType.Date).Value = BirthdateEdit.Value
                    cmd.Parameters.AddWithValue("@Question", QuestionEdit.SelectedItem)
                    cmd.Parameters.AddWithValue("@Usertype", UsertypeEdit.SelectedItem)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                    clearedit()
                End If
                connection.Close()
            End If
            load_datagrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub clearprofile()
        UserID.Clear()
        Firstname.Clear()
        Middlename.Clear()
        Lastname.Clear()
        Birthdate.Refresh()
        Age.Clear()
        If Gender.Text = Gender.SelectedItem Then
            Gender.Text = ""
        End If
        ContactNumber.Clear()
        EmailAddress.Clear()
        Division.Clear()
        Position.Clear()
        Username.Clear()
        Password.Clear()
        Answer.Clear()
        If Usertype.Text = Usertype.SelectedItem Then
            Usertype.Text = ""
        End If

    End Sub
    Public Sub clearedit()
        UserID.Clear()
        FirstnameEdit.Clear()
        MiddlenameEdit.Clear()
        LastnameEdit.Clear()
        BirthdateEdit.Refresh()
        AgeEdit.Clear()
        If GenderEdit.Text = GenderEdit.SelectedItem Then
            GenderEdit.Text = ""
        End If
        ContactNumberEdit.Clear()
        EmailEdit.Clear()
        DivisionEdit.Clear()
        PositionEdit.Clear()
        UsernameEdit.Clear()
        PasswordEdit.Clear()
        If QuestionEdit.Text = QuestionEdit.SelectedItem Then
            QuestionEdit.Text = ""
        End If
        AnswerEdit.Clear()
        If UsertypeEdit.Text = UsertypeEdit.SelectedItem Then
            UsertypeEdit.Text = ""
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim index As Integer
                index = e.RowIndex
                Dim selectedrow As DataGridViewRow
                selectedrow = DataGridView2.Rows(index)
                UserID.Text = selectedrow.Cells(0).Value.ToString
                FirstnameEdit.Text = selectedrow.Cells(1).Value.ToString
                MiddlenameEdit.Text = selectedrow.Cells(2).Value.ToString
                LastnameEdit.Text = selectedrow.Cells(3).Value.ToString
                BirthdateEdit.Text = selectedrow.Cells(4).Value.ToString
                AgeEdit.Text = selectedrow.Cells(5).Value.ToString
                GenderEdit.Text = selectedrow.Cells(6).Value.ToString
                ContactNumberEdit.Text = selectedrow.Cells(7).Value.ToString
                EmailEdit.Text = selectedrow.Cells(8).Value.ToString
                DivisionEdit.Text = selectedrow.Cells(9).Value.ToString
                PositionEdit.Text = selectedrow.Cells(10).Value.ToString
                UsernameEdit.Text = selectedrow.Cells(11).Value.ToString
                PasswordEdit.Text = selectedrow.Cells(12).Value.ToString
                QuestionEdit.Text = selectedrow.Cells(13).Value.ToString
                AnswerEdit.Text = selectedrow.Cells(14).Value.ToString
                UsertypeEdit.Text = selectedrow.Cells(15).Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Dim color As Color
        color = Color.FromArgb(232, 17, 35)
        If PictureBox1.Text = "" Then
            PictureBox1.BackColor = color
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Dim color As Color
        color = Color.FromArgb(255, 250, 250)
        If PictureBox1.Text = "" Then
            PictureBox1.BackColor = color
        End If
    End Sub

    Private Sub SearchEdit_TextChanged(sender As Object, e As EventArgs) Handles SearchEdit.TextChanged
        FilterData()
    End Sub

    Public Sub FilterData()
        'INITIALIZATION
        Dim table1 As New DataTable()
        Dim dataview As New DataView(table1)

        If ComboBox1.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchEdit.Focus()
        ElseIf ComboBox1.SelectedItem.ToString() = "by Firstname" Then
            Dim searchQuery As String = "SELECT * From user_tbl WHERE Convert(nvarchar(50),Firstname) like '%" & SearchEdit.Text & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView2.DataSource = table
        ElseIf ComboBox1.SelectedItem.ToString() = "by Username" Then
            Dim searchQuery1 As String = "SELECT * From user_tbl WHERE Convert(nvarchar(50),Username) like '%" & SearchEdit.Text & "%' "
            Dim command1 As New SqlCommand(searchQuery1, connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            adapter1.Fill(table1)
            DataGridView2.DataSource = table1
        ElseIf ComboBox1.SelectedItem.ToString() = "by Gender" Then
            Dim searchQuery2 As String = "SELECT * From user_tbl WHERE Convert(nvarchar(50),Gender) like '%" & SearchEdit.Text & "%' "
            Dim command2 As New SqlCommand(searchQuery2, connection)
            Dim adapter2 As New SqlDataAdapter(command2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            DataGridView2.DataSource = table2
        ElseIf ComboBox1.SelectedItem.ToString() = "All" Then
            Dim searchQuery3 As String = "SELECT * From user_tbl WHERE Convert(nvarchar(50),UserID)+'-'+Convert(nvarchar(50),Firstname)+'-'+Convert(nvarchar(50),Middlename)+'-'+Convert(nvarchar(50),Lastname)+'-'+Convert(nvarchar(50),Birthdate)+'-'+Convert(nvarchar(50),Age)+'-'+Convert(nvarchar(50),Gender)+'-'+Convert(nvarchar(50),ContactNumber)+'-'+Convert(nvarchar(50),EmailAddress)+'-'+Convert(nvarchar(50),Division)+'-'+Convert(nvarchar(50),Position)+'-'+Convert(nvarchar(50),Usertype)+'-'+Convert(nvarchar(50),Username)+'-'+Convert(nvarchar(50),Question)+'-'+Convert(nvarchar(50),Answer) like '%" & SearchEdit.Text & "%' "
            Dim command3 As New SqlCommand(searchQuery3, connection)
            Dim adapter3 As New SqlDataAdapter(command3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            DataGridView2.DataSource = table3
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If UserID.Text = "" Then
            MessageBox.Show("Please enter ID", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserID.Focus()
        Else
            Dim Delete As String = "Select * from user_tbl WHERE UserID = '" & UserID.Text & "'"
            Dim cmd As New SqlCommand(Delete, connection)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() = 0 Then
                MessageBox.Show("No records found!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clearprofile()
                UserID.Focus()
            Else
                Dim message As String = "Are you sure to delete?"
                Dim caption As String = "Confirmation"
                Dim icons As String = MessageBoxIcon.Warning
                Dim buttons As String = MessageBoxButtons.YesNo
                Dim result As DialogResult
                result = MessageBox.Show(Me, message, caption, buttons, icons)

                If result = DialogResult.Yes Then
                    Dim Delete1 As String = "delete from user_tbl WHERE UserID =   '" & UserID.Text & "'"
                    Dim cmd1 As New SqlCommand(Delete1, connection)
                    Dim adapter1 As New SqlDataAdapter(cmd1)
                    Dim table1 As New DataTable
                    adapter1.Fill(table1)
                    connection.Open()
                    cmd1.ExecuteNonQuery()
                    MessageBox.Show("Successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearedit()
                    connection.Close()
                Else
                    clearedit()
                    Me.Refresh()
                End If
            End If
        End If
        load_datagrid()
    End Sub

    Private Sub load_datagrid()
        Dim cmd As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim table As New DataTable
        Dim bindingsource As New BindingSource
        Try
            connection.Open()
            cmd = New SqlCommand("SELECT UserID,Firstname,Middlename,Lastname,Birthdate,Age,Gender,ContactNumber,EmailAddress,Division,Position,Username,Password,Question,Answer,Usertype FROM user_tbl", connection)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(table)
            bindingsource.DataSource = table
            DataGridView2.DataSource = bindingsource
            adapter.Update(table)
            DataGridView2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactNumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "1234567890-()+"
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Firstname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Middlename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Middlename.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ. "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lastname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ. "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        SearchEdit.Clear()
    End Sub

    Private Sub Division_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Division.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstnameEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstnameEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MiddlenameEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiddlenameEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LastnameEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastnameEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactNumberEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactNumberEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "1234567890-()+"
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DivisionEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DivisionEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Position_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Position.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PositionEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PositionEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub UpdateButton_KeyDown(sender As Object, e As KeyEventArgs) Handles UpdateButton.KeyDown
        If (e.Control = True AndAlso e.KeyCode = Keys.U) Then
            UpdateButton.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.D) Then
            DeleteButton.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.F) Then
            SearchEdit.Select()
        End If

    End Sub

    Private Sub Birthdate_ValueChanged(sender As Object, e As EventArgs) Handles Birthdate.ValueChanged
        Dim myBirthdate As Integer = Birthdate.Value.Year 'selected value from Birthdate
        Dim currentDate As Integer = DateTime.Today.Year 'current date

        Dim myAge As Integer = currentDate - myBirthdate

        Age.Text = myAge.ToString()
    End Sub

    Private Sub BirthdateEdit_ValueChanged(sender As Object, e As EventArgs) Handles BirthdateEdit.ValueChanged
        Dim myBirthdate As Integer = BirthdateEdit.Value.Year 'selected value from Birthdate
        Dim currentDate As Integer = DateTime.Today.Year 'current date

        Dim myAge As Integer = currentDate - myBirthdate

        AgeEdit.Text = myAge.ToString()
    End Sub

    Private Sub Gender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Gender.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Usertype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Usertype.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
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

    Private Sub GenderEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GenderEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub UsertypeEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsertypeEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub QuestionEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuestionEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Firstname_TextChanged(sender As Object, e As EventArgs) Handles Firstname.TextChanged
        Firstname.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Firstname.Text.ToLower)
        Firstname.Select(Firstname.Text.Length, 0)
    End Sub

    Private Sub Middlename_TextChanged(sender As Object, e As EventArgs) Handles Middlename.TextChanged
        Middlename.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Middlename.Text.ToLower)
        Middlename.Select(Middlename.Text.Length, 0)
    End Sub

    Private Sub Lastname_TextChanged(sender As Object, e As EventArgs) Handles Lastname.TextChanged
        Lastname.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Lastname.Text.ToLower)
        Lastname.Select(Lastname.Text.Length, 0)
    End Sub

    Private Sub Division_TextChanged(sender As Object, e As EventArgs) Handles Division.TextChanged
        Division.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Division.Text.ToLower)
        Division.Select(Division.Text.Length, 0)
    End Sub

    Private Sub Position_TextChanged(sender As Object, e As EventArgs) Handles Position.TextChanged
        Position.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Position.Text.ToLower)
        Position.Select(Position.Text.Length, 0)
    End Sub

    Private Sub Answer_TextChanged(sender As Object, e As EventArgs) Handles Answer.TextChanged
        Answer.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Answer.Text.ToLower)
        Answer.Select(Answer.Text.Length, 0)
    End Sub

    Private Sub UserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UserID.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "1234567890"
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstnameEdit_TextChanged(sender As Object, e As EventArgs) Handles FirstnameEdit.TextChanged
        FirstnameEdit.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(FirstnameEdit.Text.ToLower)
        FirstnameEdit.Select(FirstnameEdit.Text.Length, 0)
    End Sub

    Private Sub MiddlenameEdit_TextChanged(sender As Object, e As EventArgs) Handles MiddlenameEdit.TextChanged
        MiddlenameEdit.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(MiddlenameEdit.Text.ToLower)
        MiddlenameEdit.Select(MiddlenameEdit.Text.Length, 0)
    End Sub

    Private Sub LastnameEdit_TextChanged(sender As Object, e As EventArgs) Handles LastnameEdit.TextChanged
        LastnameEdit.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(LastnameEdit.Text.ToLower)
        LastnameEdit.Select(LastnameEdit.Text.Length, 0)
    End Sub

    Private Sub DivisionEdit_TextChanged(sender As Object, e As EventArgs) Handles DivisionEdit.TextChanged
        DivisionEdit.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(DivisionEdit.Text.ToLower)
        DivisionEdit.Select(DivisionEdit.Text.Length, 0)
    End Sub

    Private Sub PositionEdit_TextChanged(sender As Object, e As EventArgs) Handles PositionEdit.TextChanged
        PositionEdit.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(PositionEdit.Text.ToLower)
        PositionEdit.Select(PositionEdit.Text.Length, 0)
    End Sub

    Private Sub AnswerEdit_TextChanged(sender As Object, e As EventArgs) Handles AnswerEdit.TextChanged
        AnswerEdit.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(AnswerEdit.Text.ToLower)
        AnswerEdit.Select(AnswerEdit.Text.Length, 0)
    End Sub

End Class
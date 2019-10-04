Imports System.Data.SqlClient

Public Class ActivateOrDeactivateForm

    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            If UserID.Text = "" Or Username.Text = "" Or CurrentlyStatus.Text = "" Or Usertype.Text = "" Or ActivateOrDeactivate.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf ActivateOrDeactivate.SelectedItem = "Activate" And Not UserID.Text = "" And Not Username.Text = "" And Not CurrentlyStatus.Text = "" And Not Usertype.Text = "" Then
                Dim active As String = "Active"
                Dim inactive As String = "Inactive"

                Dim update As String = "UPDATE user_tbl set Status = '" & active & "' WHERE UserID = '" & UserID.Text & "' "
                Dim command As New SqlCommand(update, connection)
                DataGridView1.Refresh()
                load_datagrid()
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Successfully activated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                connection.Close()
                Username.Clear()
                Usertype.Clear()
                UserID.Clear()
                CurrentlyStatus.Clear()
                If ActivateOrDeactivate.Text = ActivateOrDeactivate.Text Then
                    ActivateOrDeactivate.Text = Nothing
                End If
            ElseIf ActivateOrDeactivate.SelectedItem = "Deactivate" And Not UserID.Text = "" And Not Username.Text = "" And Not CurrentlyStatus.Text = "" And Not Usertype.Text = "" Then
                Dim active As String = "Active"
                Dim inactive As String = "Inactive"
                Dim update As String = "UPDATE user_tbl set Status = '" & inactive & "' WHERE UserID = '" & UserID.Text & "' "
                Dim command As New SqlCommand(update, connection)
                load_datagrid()
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Successfully deactivated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Username.Clear()
                Usertype.Clear()
                UserID.Clear()
                CurrentlyStatus.Clear()
                If ActivateOrDeactivate.Text = ActivateOrDeactivate.Text Then
                    ActivateOrDeactivate.Text = Nothing
                End If
                connection.Close()
            Else
                MessageBox.Show("Invalid data!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            connection.Close()
            load_datagrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            connection.Close()
        End Try
    End Sub

    Private Sub ActivateOrDeactivateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.User_tblTableAdapter.Fill(Me.Cenro_DBDataSet.user_tbl)
        ' When the form loads, the KeyPreview property is set to True.
        ' This lets the form capture keyboard events before
        ' any other element in the form.
        Me.KeyPreview = True
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        FilterData(Search.Text)
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Try
            'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
            Dim searchQuery As String = "SELECT * From user_tbl WHERE Convert(nvarchar(50),UserID)+'-'+Convert(nvarchar(50),Username)+'-'+Convert(nvarchar(50),Usertype)+'-'+Convert(nvarchar(50),Status) like '%" & valueToSearch & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error! " + ex.Message.ToString() + " Error Handler" + MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub load_datagrid()
        Dim cmd As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim table As New DataTable
        Dim bindingsource As New BindingSource
        Try
            connection.Open()
            cmd = New SqlCommand("select UserID, Username, Usertype, Status from user_tbl", connection)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(table)
            bindingsource.DataSource = table
            DataGridView1.DataSource = bindingsource
            adapter.Update(table)
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DataGridView1.Rows(index)
            UserID.Text = selectedrow.Cells(0).Value.ToString
            Username.Text = selectedrow.Cells(1).Value.ToString
            Usertype.Text = selectedrow.Cells(2).Value.ToString
            CurrentlyStatus.Text = selectedrow.Cells(3).Value.ToString
            Search.Clear()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Search.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Clear.Click
        UserID.Clear()
        Username.Clear()
        Usertype.Clear()
        CurrentlyStatus.Clear()
        If ActivateOrDeactivate.Text = ActivateOrDeactivate.Text Then
            ActivateOrDeactivate.Text = Nothing
        End If
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

    Private Sub Save_KeyDown(sender As Object, e As KeyEventArgs) Handles Save.KeyDown
    End Sub

    Private Sub ActivateOrDeactivateForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control = True AndAlso e.KeyCode = Keys.S) Then
            Save.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.C) Then
            Clear.PerformClick()
        End If
    End Sub

    Private Sub ActivateOrDeactivate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ActivateOrDeactivate.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim searchQuery As String = "SELECT * From user_tbl WHERE Convert(nvarchar(50),UserID)+'-'+Convert(nvarchar(50),Username)+'-'+Convert(nvarchar(50),Usertype)+'-'+Convert(nvarchar(50),Status) like '%" & Search.Text & "%' "
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class
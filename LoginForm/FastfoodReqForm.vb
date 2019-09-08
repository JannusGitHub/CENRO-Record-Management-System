Imports System.Data.SqlClient

Public Class FastfoodReqForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")
    Private Sub FastfoodReqForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cenro_DBDataSet.FastfoodCanteenAndRestaurant_tbl' table. You can move, or remove it, as needed.
        Me.FastfoodCanteenAndRestaurant_tblTableAdapter.Fill(Me.Cenro_DBDataSet.FastfoodCanteenAndRestaurant_tbl)

        Me.KeyPreview = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DataGridView1.Rows(index)
            NameOfEstablishmentReq.Text = selectedrow.Cells(0).Value.ToString
            ControlNumber1.Text = selectedrow.Cells(1).Value.ToString
            BrgyClearance1.Text = selectedrow.Cells(2).Value.ToString
            DTISEC1.Text = selectedrow.Cells(3).Value.ToString
            ECC1.Text = selectedrow.Cells(4).Value.ToString
            PTO1.Text = selectedrow.Cells(5).Value.ToString
            DP1.Text = selectedrow.Cells(6).Value.ToString
            AccreditedWasteHauler1.Text = selectedrow.Cells(7).Value.ToString
        End If
    End Sub

    Private Sub SearchReq_TextChanged(sender As Object, e As EventArgs) Handles SearchReq.TextChanged
        FilterDatareq()
    End Sub

    Public Sub FilterDatareq()
        'INITIALIZATION
        Dim table1 As New DataTable()
        Dim dataview As New DataView(table1)

        If ComboBox1.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchReq.Focus()
        ElseIf ComboBox1.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQuery As String = "SELECT * From FastfoodCanteenAndRestaurant_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & SearchReq.Text & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQuery1 As String = "SELECT * From FastfoodCanteenAndRestaurant_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & SearchReq.Text & "%' "
            Dim command1 As New SqlCommand(searchQuery1, connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            adapter1.Fill(table1)
            DataGridView1.DataSource = table1
        ElseIf ComboBox1.SelectedItem.ToString() = "All" Then
            Dim searchQuery3 As String = "SELECT * From FastfoodCanteenAndRestaurant_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),BrgyClearanceWithCTC)+'-'+Convert(nvarchar(50),DTI_SEC)+'-'+Convert(nvarchar(50),ECC)+'-'+Convert(nvarchar(50),PTO)+'-'+Convert(nvarchar(50),DP)+'-'+Convert(nvarchar(50),AccreditedWasteHauler)  like '%" & SearchReq.Text & "%' "
            Dim command3 As New SqlCommand(searchQuery3, connection)
            Dim adapter3 As New SqlDataAdapter(command3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            DataGridView1.DataSource = table3
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        With InspectorCategoryForm
            .TopLevel = False
            InspectorForm.MDIpanel.Controls.Add(InspectorCategoryForm)
            .BringToFront()
            .Show()
        End With
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SearchReq.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameOfEstablishmentReq.Clear()
        ControlNumber1.Clear()
        BrgyClearance1.Clear()
        DTISEC1.Clear()
        ECC1.Clear()
        PTO1.Clear()
        DP1.Clear()
        AccreditedWasteHauler1.Clear()
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        If NameOfEstablishmentReq.Text = "" Then
            MessageBox.Show("Fill the Name of Establishment field!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Hide()
            With FastfoodOathOfUndertakingForm
                .TopLevel = False
                InspectorForm.MDIpanel.Controls.Add(FastfoodOathOfUndertakingForm)
                .BringToFront()
                .Show()
            End With
        End If
    End Sub

    Private Sub FastfoodReqForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control = True AndAlso e.KeyCode = Keys.P) Then
            Print.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.C) Then
            ClearButton.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.F) Then
            SearchReq.Select()
        End If

    End Sub
End Class
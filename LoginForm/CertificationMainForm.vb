Imports System.Data.SqlClient

Public Class CertificationMainForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")

    Private Sub CertificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FastfoodDataSet.FastfoodCanteenAndRestaurant_tbl' table. You can move, or remove it, as needed.
        Me.FastfoodCanteenAndRestaurant_tblTableAdapter.Fill(Me.FastfoodDataSet.FastfoodCanteenAndRestaurant_tbl)
        'TODO: This line of code loads data into the 'HospitalDataSet.HospitalAndMedicalEstablishment_tbl' table. You can move, or remove it, as needed.
        Me.HospitalAndMedicalEstablishment_tblTableAdapter.Fill(Me.HospitalDataSet.HospitalAndMedicalEstablishment_tbl)
        'TODO: This line of code loads data into the 'IENFDataSet.IndustrialEstablishmentNonFood_tbl' table. You can move, or remove it, as needed.
        Me.IndustrialEstablishmentNonFood_tblTableAdapter.Fill(Me.IENFDataSet.IndustrialEstablishmentNonFood_tbl)
        'TODO: This line of code loads data into the 'IEFDataSet.IndustrialEstablishmentFood_tbl' table. You can move, or remove it, as needed.
        Me.IndustrialEstablishmentFood_tblTableAdapter.Fill(Me.IEFDataSet.IndustrialEstablishmentFood_tbl)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DataGridView1.Rows(index)
            IEFCertificationPopupForm.ControlNumber1.Text = selectedrow.Cells(0).Value.ToString
            IEFCertificationPopupForm.NameOfEstablishment1.Text = selectedrow.Cells(1).Value.ToString
            IEFCertificationPopupForm.Address1.Text = selectedrow.Cells(2).Value.ToString
            IEFCertificationPopupForm.Owner1.Text = selectedrow.Cells(3).Value.ToString
        End If
        With IEFCertificationPopupForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(IEFCertificationPopupForm)
            .BringToFront()
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub SearchInTable_TextChanged(sender As Object, e As EventArgs) Handles SearchInTable.TextChanged
        FilterData()
    End Sub

    Public Sub FilterData()
        'INITIALIZATION
        Dim table1 As New DataTable()
        Dim dataview As New DataView(table1)

        If ComboBox2.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchInTable.Focus()
        ElseIf ComboBox2.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQuery As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & SearchInTable.Text & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox2.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQuery1 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & SearchInTable.Text & "%' "
            Dim command1 As New SqlCommand(searchQuery1, connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            adapter1.Fill(table1)
            DataGridView1.DataSource = table1
        ElseIf ComboBox2.SelectedItem.ToString() = "by Address" Then
            Dim searchQuery2 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),Address)  like '%" & SearchInTable.Text & "%' "
            Dim command2 As New SqlCommand(searchQuery2, connection)
            Dim adapter2 As New SqlDataAdapter(command2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            DataGridView1.DataSource = table2
        ElseIf ComboBox2.SelectedItem.ToString() = "All" Then
            Dim searchQuery3 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),Address)+'-'+Convert(nvarchar(50),CEO_President)  like '%" & SearchInTable.Text & "%' "
            Dim command3 As New SqlCommand(searchQuery3, connection)
            Dim adapter3 As New SqlDataAdapter(command3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            DataGridView1.DataSource = table3
        End If
    End Sub

    Private Sub IENFSearch_TextChanged(sender As Object, e As EventArgs) Handles IENFSearch.TextChanged
        IENFFilterData()
    End Sub

    Public Sub IENFFilterData()
        'INITIALIZATION
        Dim IENF_tbl As New DataTable()
        Dim dataview As New DataView(IENF_tbl)

        If IENFCategoryCombobox.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IENFSearch.Focus()
        ElseIf IENFCategoryCombobox.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQueryOfIENF_tbl As String = "SELECT * From IndustrialEstablishmentNonFood_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & IENFSearch.Text & "%' "
            Dim CommandOfIENF As New SqlCommand(searchQueryOfIENF_tbl, connection)
            Dim adapterOfIENF As New SqlDataAdapter(CommandOfIENF)
            adapterOfIENF.Fill(IENF_tbl)
            IENFDataGridView.DataSource = IENF_tbl
        ElseIf IENFCategoryCombobox.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQueryOfIENF_tbl1 As String = "SELECT * From IndustrialEstablishmentNonFood_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & IENFSearch.Text & "%' "
            Dim CommandOfIENF1 As New SqlCommand(searchQueryOfIENF_tbl1, connection)
            Dim adapterOfIENF1 As New SqlDataAdapter(CommandOfIENF1)
            adapterOfIENF1.Fill(IENF_tbl)
            IENFDataGridView.DataSource = IENF_tbl
        ElseIf IENFCategoryCombobox.SelectedItem.ToString() = "by Address" Then
            Dim searchQueryOfIENF_tbl2 As String = "SELECT * From IndustrialEstablishmentNonFood_tbl WHERE Convert(nvarchar(50),Address)  like '%" & IENFSearch.Text & "%' "
            Dim CommandOfIENF2 As New SqlCommand(searchQueryOfIENF_tbl2, connection)
            Dim adapterOfIENF2 As New SqlDataAdapter(CommandOfIENF2)
            adapterOfIENF2.Fill(IENF_tbl)
            IENFDataGridView.DataSource = IENF_tbl
        ElseIf IENFCategoryCombobox.SelectedItem.ToString() = "All" Then
            Dim searchQueryOfIENF_tbl3 As String = "SELECT * From IndustrialEstablishmentNonFood_tbl WHERE Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),Address)+'-'+Convert(nvarchar(50),CEO_President)  like '%" & IENFSearch.Text & "%' "
            Dim CommandOfIENF3 As New SqlCommand(searchQueryOfIENF_tbl3, connection)
            Dim adapterOfIENF3 As New SqlDataAdapter(CommandOfIENF3)
            adapterOfIENF3.Fill(IENF_tbl)
            IENFDataGridView.DataSource = IENF_tbl
        End If
    End Sub

    Private Sub IENFDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles IENFDataGridView.CellClick

        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = IENFDataGridView.Rows(index)
            IENFCertificationPopupForm.ControlNumber1.Text = selectedrow.Cells(0).Value.ToString
            IENFCertificationPopupForm.NameOfEstablishment1.Text = selectedrow.Cells(1).Value.ToString
            IENFCertificationPopupForm.Address1.Text = selectedrow.Cells(2).Value.ToString
            IENFCertificationPopupForm.Owner1.Text = selectedrow.Cells(3).Value.ToString
        End If
        With IENFCertificationPopupForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(IENFCertificationPopupForm)
            .BringToFront()
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub HospitalSearch_TextChanged(sender As Object, e As EventArgs) Handles HospitalSearch.TextChanged
        HospitalFilterData()
    End Sub

    Public Sub HospitalFilterData()
        'INITIALIZATION
        Dim HospitalAndMedicalEstablishment_tbl As New DataTable()
        Dim dataview As New DataView(HospitalAndMedicalEstablishment_tbl)

        If HospitalCategoryCombobox.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HospitalSearch.Focus()
        ElseIf HospitalCategoryCombobox.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQueryOfHospital_tbl As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & HospitalSearch.Text & "%' "
            Dim CommandOfHospital As New SqlCommand(searchQueryOfHospital_tbl, connection)
            Dim adapterOfHospital As New SqlDataAdapter(CommandOfHospital)
            adapterOfHospital.Fill(HospitalAndMedicalEstablishment_tbl)
            HospitalDataGridView.DataSource = HospitalAndMedicalEstablishment_tbl
        ElseIf HospitalCategoryCombobox.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQueryOfHospital_tbl1 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & HospitalSearch.Text & "%' "
            Dim CommandOfHospital1 As New SqlCommand(searchQueryOfHospital_tbl1, connection)
            Dim adapterOfHospital1 As New SqlDataAdapter(CommandOfHospital1)
            adapterOfHospital1.Fill(HospitalAndMedicalEstablishment_tbl)
            HospitalDataGridView.DataSource = HospitalAndMedicalEstablishment_tbl
        ElseIf HospitalCategoryCombobox.SelectedItem.ToString() = "by Address" Then
            Dim searchQueryOfHospital_tbl2 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),Address)  like '%" & HospitalSearch.Text & "%' "
            Dim CommandOfHospital2 As New SqlCommand(searchQueryOfHospital_tbl2, connection)
            Dim adapterOfHospital2 As New SqlDataAdapter(CommandOfHospital2)
            adapterOfHospital2.Fill(HospitalAndMedicalEstablishment_tbl)
            HospitalDataGridView.DataSource = HospitalAndMedicalEstablishment_tbl
        ElseIf HospitalCategoryCombobox.SelectedItem.ToString() = "All" Then
            Dim searchQueryOfHospital_tbl3 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),Address)+'-'+Convert(nvarchar(50),CEO_President)  like '%" & HospitalSearch.Text & "%' "
            Dim CommandOfHospital3 As New SqlCommand(searchQueryOfHospital_tbl3, connection)
            Dim adapterOfHospital3 As New SqlDataAdapter(CommandOfHospital3)
            adapterOfHospital3.Fill(HospitalAndMedicalEstablishment_tbl)
            HospitalDataGridView.DataSource = HospitalAndMedicalEstablishment_tbl
        End If
    End Sub

    Private Sub HospitalDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles HospitalDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = HospitalDataGridView.Rows(index)
            HospitalCertificationPopupForm.ControlNumber1.Text = selectedrow.Cells(0).Value.ToString
            HospitalCertificationPopupForm.NameOfEstablishment1.Text = selectedrow.Cells(1).Value.ToString
            HospitalCertificationPopupForm.Address1.Text = selectedrow.Cells(2).Value.ToString
            HospitalCertificationPopupForm.Owner1.Text = selectedrow.Cells(3).Value.ToString
        End If
        With HospitalCertificationPopupForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(HospitalCertificationPopupForm)
            .BringToFront()
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub FastfoodSearch_TextChanged(sender As Object, e As EventArgs) Handles FastfoodSearch.TextChanged
        FastfoodFilterData()
    End Sub

    Public Sub FastfoodFilterData()
        'INITIALIZATION
        Dim FastfoodCanteenAndRestaurant_tbl As New DataTable()
        Dim dataview As New DataView(FastfoodCanteenAndRestaurant_tbl)

        If FastfoodCategoryCombobox.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FastfoodSearch.Focus()
        ElseIf FastfoodCategoryCombobox.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQueryOfFastfood_tbl As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & FastfoodSearch.Text & "%' "
            Dim CommandOfFastfood As New SqlCommand(searchQueryOfFastfood_tbl, connection)
            Dim adapterOfFastfood As New SqlDataAdapter(CommandOfFastfood)
            adapterOfFastfood.Fill(FastfoodCanteenAndRestaurant_tbl)
            FastfoodDataGridView.DataSource = FastfoodCanteenAndRestaurant_tbl
        ElseIf FastfoodCategoryCombobox.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQueryOfFastfood_tbl1 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & FastfoodSearch.Text & "%' "
            Dim CommandOfFastfood1 As New SqlCommand(searchQueryOfFastfood_tbl1, connection)
            Dim adapterOfFastfood1 As New SqlDataAdapter(CommandOfFastfood1)
            adapterOfFastfood1.Fill(FastfoodCanteenAndRestaurant_tbl)
            FastfoodDataGridView.DataSource = FastfoodCanteenAndRestaurant_tbl
        ElseIf FastfoodCategoryCombobox.SelectedItem.ToString() = "by Address" Then
            Dim searchQueryOfFastfood_tbl2 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),Address)  like '%" & FastfoodSearch.Text & "%' "
            Dim CommandOfFastfood2 As New SqlCommand(searchQueryOfFastfood_tbl2, connection)
            Dim adapterOfFastfood2 As New SqlDataAdapter(CommandOfFastfood2)
            adapterOfFastfood2.Fill(FastfoodCanteenAndRestaurant_tbl)
            FastfoodDataGridView.DataSource = FastfoodCanteenAndRestaurant_tbl
        ElseIf FastfoodCategoryCombobox.SelectedItem.ToString() = "All" Then
            Dim searchQueryOfFastfood_tbl3 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),Address)+'-'+Convert(nvarchar(50),CEO_President)  like '%" & FastfoodSearch.Text & "%' "
            Dim CommandOfFastfood3 As New SqlCommand(searchQueryOfFastfood_tbl3, connection)
            Dim adapterOfFastfood3 As New SqlDataAdapter(CommandOfFastfood3)
            adapterOfFastfood3.Fill(FastfoodCanteenAndRestaurant_tbl)
            FastfoodDataGridView.DataSource = FastfoodCanteenAndRestaurant_tbl
        End If
    End Sub

    Private Sub FastfoodDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FastfoodDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = FastfoodDataGridView.Rows(index)
            FastfoodCertificationPopupForm.ControlNumber1.Text = selectedrow.Cells(0).Value.ToString
            FastfoodCertificationPopupForm.NameOfEstablishment1.Text = selectedrow.Cells(1).Value.ToString
            FastfoodCertificationPopupForm.Address1.Text = selectedrow.Cells(2).Value.ToString
            FastfoodCertificationPopupForm.Owner1.Text = selectedrow.Cells(3).Value.ToString
        End If
        With FastfoodCertificationPopupForm
            .TopLevel = False
            Main.MDIpanel.Controls.Add(FastfoodCertificationPopupForm)
            .BringToFront()
            .Show()
        End With
        Me.Close()
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        SearchInTable.Clear()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        IENFSearch.Clear()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        HospitalSearch.Clear()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        FastfoodSearch.Clear()
    End Sub
End Class

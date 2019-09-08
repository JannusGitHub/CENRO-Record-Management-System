Imports System.Data.SqlClient

Public Class HospitalAndEstablishmentForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        With Category
            .TopLevel = False
            Main.MDIpanel.Controls.Add(Category)
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

    Private Sub SearchReq_TextChanged(sender As Object, e As EventArgs) Handles SearchReq.TextChanged
        FilterDataReq()
    End Sub

    Public Sub FilterDataReq()
        'INITIALIZATION
        Dim table1 As New DataTable()
        Dim dataview As New DataView(table1)

        If ComboBox2.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchReq.Focus()
        ElseIf ComboBox2.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQuery As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & SearchReq.Text & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView2.DataSource = table
        ElseIf ComboBox2.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQuery1 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & SearchReq.Text & "%' "
            Dim command1 As New SqlCommand(searchQuery1, connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            adapter1.Fill(table1)
            DataGridView2.DataSource = table1
        ElseIf ComboBox2.SelectedItem.ToString() = "All" Then
            Dim searchQuery3 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),BrgyClearanceWithCTC)+'-'+Convert(nvarchar(50),DTI_SEC)+'-'+Convert(nvarchar(50),ECC)+'-'+Convert(nvarchar(50),PTO)+'-'+Convert(nvarchar(50),DP)+'-'+Convert(nvarchar(50),DENR_IDNumber)+'-'+Convert(nvarchar(50),DOHAccreditation)+'-'+Convert(nvarchar(50),AccreditedWasteHauler)  like '%" & SearchReq.Text & "%' "
            Dim command3 As New SqlCommand(searchQuery3, connection)
            Dim adapter3 As New SqlDataAdapter(command3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            DataGridView2.DataSource = table3
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NameOfEstablishment.Text = "" And Address.Text = "" And EmailAddress.Text = "" And CEOPresident.Text = "" And GeneralManager.Text = "" And PollutionControlOfficer.Text = "" And NatureOfBusiness.Text = "" And ContactNumber.Text = "" And NameOfAccreditedWasteHauler.Text = "" And ControlNumber.Text = "" And BrgyClearance.Text = "" And DTISEC.Text = "" And ECC.Text = "" And PTO.Text = "" And DP.Text = "" And DENRIDNumber.Text = "" And AccreditedWasteHauler.Text = "" And DOHAccreditation.Text = "" Then
            MessageBox.Show("All confirmation is required", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NameOfEstablishment.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Address.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf EmailAddress.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CEOPresident.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf GeneralManager.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf PollutionControlOfficer.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NatureOfBusiness.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ContactNumber.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NameOfAccreditedWasteHauler.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ControlNumber.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf BrgyClearance.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DTISEC.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ECC.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf PTO.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DP.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DENRIDNumber.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf AccreditedWasteHauler.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DOHAccreditation.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim command As SqlCommand
            Dim datareader As SqlDataReader

            connection.Open()
            command = New SqlCommand("select * from HospitalAndMedicalEstablishment_tbl where ControlNumber = '" & ControlNumber.Text & "'", connection)

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            datareader = command.ExecuteReader
            If datareader.HasRows Then
                MessageBox.Show("Duplicate control number found!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ControlNumber.Focus()
                connection.Close()
            Else
                connection.Close()
                connection.Open()
                Dim insertquery As String = "insert into HospitalAndMedicalEstablishment_tbl(NameOfEstablishment,Address,EmailAddress,CEO_President,GeneralManager,PollutionControlOfficer,NatureOfBusiness,ContactNumber,NameOfAccreditedWasteHauler,ControlNumber,BrgyClearanceWithCTC,DTI_SEC,ECC,PTO,DP,DENR_IDNumber,DOHAccreditation,AccreditedWasteHauler) values (@NameOfEstablishment,@Address,@EmailAddress,@CEOPresident,@GeneralManager,@PollutionControlOfficer,@NatureOfBusiness,@ContactNumber,@NameOfAccreditedWasteHauler,@ControlNumber,@BrgyClearance,@DTISEC,@ECC,@PTO,@DP,@DENRIDNumber,@DOHAccreditation,@AccreditedWasteHauler)"
                Dim cmd As New SqlCommand(insertquery, connection)
                cmd.Parameters.AddWithValue("@NameOfEstablishment", NameOfEstablishment.Text)
                cmd.Parameters.AddWithValue("@Address", Address.Text)
                cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress.Text)
                cmd.Parameters.AddWithValue("@CEOPresident", CEOPresident.Text)
                cmd.Parameters.AddWithValue("@GeneralManager", GeneralManager.Text)
                cmd.Parameters.AddWithValue("@PollutionControlOfficer", PollutionControlOfficer.Text)
                cmd.Parameters.AddWithValue("@NatureOfBusiness", NatureOfBusiness.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber.Text)
                cmd.Parameters.AddWithValue("@NameOfAccreditedWasteHauler", NameOfAccreditedWasteHauler.Text)
                cmd.Parameters.AddWithValue("@ControlNumber", ControlNumber.Text)
                cmd.Parameters.AddWithValue("@BrgyClearance", BrgyClearance.Text)
                cmd.Parameters.AddWithValue("@DTISEC", DTISEC.Text)
                cmd.Parameters.AddWithValue("@ECC", ECC.Text)
                cmd.Parameters.AddWithValue("@PTO", PTO.Text)
                cmd.Parameters.AddWithValue("@DP", DP.Text)
                cmd.Parameters.AddWithValue("@DENRIDNumber", DENRIDNumber.Text)
                cmd.Parameters.AddWithValue("@DOHAccreditation", DOHAccreditation.Text)
                cmd.Parameters.AddWithValue("@AccreditedWasteHauler", AccreditedWasteHauler.Text)
                cmd.Parameters.AddWithValue("@HospitalAndMedical", Search.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearprofile()
                connection.Close()
            End If
            datareader.Close()
            connection.Close()
        End If
        load_datagrid()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If NameOfEstablishment.Text = "" And Address.Text = "" And EmailAddress.Text = "" And CEOPresident.Text = "" And GeneralManager.Text = "" And PollutionControlOfficer.Text = "" And NatureOfBusiness.Text = "" And ContactNumber.Text = "" And NameOfAccreditedWasteHauler.Text = "" And ControlNumber.Text = "" And BrgyClearance.Text = "" And DTISEC.Text = "" And ECC.Text = "" And PTO.Text = "" And DP.Text = "" And DENRIDNumber.Text = "" And DOHAccreditation.Text = "" And AccreditedWasteHauler.Text = "" Then
            MessageBox.Show("All confirmation is required", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NameOfEstablishment.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Address.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf EmailAddress.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CEOPresident.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf GeneralManager.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf PollutionControlOfficer.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NatureOfBusiness.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ContactNumber.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NameOfAccreditedWasteHauler.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ControlNumber.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf BrgyClearance.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DTISEC.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ECC.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf PTO.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DP.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DENRIDNumber.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DOHAccreditation.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf AccreditedWasteHauler.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim Updatequery As String = "Select * From HospitalAndMedicalEstablishment_tbl WHERE ControlNumber = '" & ControlNumber.Text & "' "
            Dim cmd As New SqlCommand(Updatequery, connection)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() = 0 Then
                MessageBox.Show("No records found!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clearprofile()
                ControlNumber.Focus()
            Else
                Dim Update1 As String = "UPDATE HospitalAndMedicalEstablishment_tbl set NameOfEstablishment = '" & NameOfEstablishment.Text & "', Address = '" & Address.Text & "', EmailAddress = '" & EmailAddress.Text & "', CEO_President = '" & CEOPresident.Text & "', GeneralManager = '" & GeneralManager.Text & "', PollutionControlOfficer = '" & PollutionControlOfficer.Text & "', NatureOfBusiness = '" & NatureOfBusiness.Text & "', ContactNumber = '" & ContactNumber.Text & "', NameOfAccreditedWasteHauler = '" & NameOfAccreditedWasteHauler.Text & "', BrgyClearanceWithCTC = '" & BrgyClearance.Text & "', DTI_SEC = '" & DTISEC.Text & "', ECC = '" & ECC.Text & "', PTO = '" & PTO.Text & "', DP = '" & DP.Text & "', DENR_IDNumber = '" & DENRIDNumber.Text & "', DOHAccreditation = '" & DOHAccreditation.Text & "', AccreditedWasteHauler = '" & AccreditedWasteHauler.Text & "' WHERE ControlNumber = '" & ControlNumber.Text & "' "
                Dim cmd1 As New SqlCommand(Update1, connection)
                Dim adapter1 As New SqlDataAdapter(cmd1)
                Dim table1 As New DataTable
                adapter1.Fill(table1)
                connection.Open()
                cmd1.ExecuteNonQuery()
                MessageBox.Show("Successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearprofile()
                connection.Close()
            End If
        End If
        load_datagrid()
    End Sub

    Private Sub DeleteButton_Click_1(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If ControlNumber.Text = "" Then
            MessageBox.Show("You must enter the control number!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ControlNumber.Focus()
        Else
            Dim Delete As String = "Select * from HospitalAndMedicalEstablishment_tbl WHERE ControlNumber = '" & ControlNumber.Text & "'"
            Dim cmd As New SqlCommand(Delete, connection)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() = 0 Then
                MessageBox.Show("No records found!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clearprofile()
                ControlNumber.Focus()
            Else
                Dim message As String = "Are you sure to delete?"
                Dim caption As String = "Confirmation"
                Dim icons As String = MessageBoxIcon.Warning
                Dim buttons As String = MessageBoxButtons.YesNo
                Dim result As DialogResult
                result = MessageBox.Show(Me, message, caption, buttons, icons)

                If result = DialogResult.Yes Then
                    Dim Delete1 As String = "delete from HospitalAndMedicalEstablishment_tbl WHERE ControlNumber = '" & ControlNumber.Text & "'"
                    Dim cmd1 As New SqlCommand(Delete1, connection)
                    Dim adapter1 As New SqlDataAdapter(cmd1)
                    Dim table1 As New DataTable
                    adapter1.Fill(table1)
                    connection.Open()
                    cmd1.ExecuteNonQuery()
                    MessageBox.Show("Successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearprofile()
                    connection.Close()
                Else
                    clearprofile()
                    Me.Refresh()
                End If
            End If
        End If
            load_datagrid()
    End Sub

    Private Sub HospitalAndEstablishmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Cenro_DBDataSet.HospitalAndMedicalEstablishment_tbl' table. You can move, or remove it, as needed.
        Me.HospitalAndMedicalEstablishment_tblTableAdapter.Fill(Me.Cenro_DBDataSet.HospitalAndMedicalEstablishment_tbl)

        Me.KeyPreview = True
    End Sub

    Private Sub Search_TextChanged_1(sender As Object, e As EventArgs) Handles Search.TextChanged
        FilterData()
    End Sub

    Public Sub FilterData()
        'INITIALIZATION
        Dim table1 As New DataTable()
        Dim dataview As New DataView(table1)

        If ComboBox1.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Search.Focus()
        ElseIf ComboBox1.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQuery As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & Search.Text & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQuery1 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & Search.Text & "%' "
            Dim command1 As New SqlCommand(searchQuery1, connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            adapter1.Fill(table1)
            DataGridView1.DataSource = table1
        ElseIf ComboBox1.SelectedItem.ToString() = "by Address" Then
            Dim searchQuery2 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),Address)  like '%" & Search.Text & "%' "
            Dim command2 As New SqlCommand(searchQuery2, connection)
            Dim adapter2 As New SqlDataAdapter(command2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            DataGridView1.DataSource = table2
        ElseIf ComboBox1.SelectedItem.ToString() = "All" Then
            Dim searchQuery3 As String = "SELECT * From HospitalAndMedicalEstablishment_tbl WHERE Convert(nvarchar(50),HospitalAndMedicalEstablishmentID)+'-'+Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),Address)+'-'+Convert(nvarchar(50),EmailAddress)+'-'+Convert(nvarchar(50),CEO_President)+'-'+Convert(nvarchar(50),GeneralManager)+'-'+Convert(nvarchar(50),PollutionControlOfficer)+'-'+Convert(nvarchar(50),NatureOfBusiness)+'-'+Convert(nvarchar(50),ContactNumber)+'-'+Convert(nvarchar(50),NameOfAccreditedWasteHauler)+'-'+Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),BrgyClearanceWithCTC)+'-'+Convert(nvarchar(50),DTI_SEC)+'-'+Convert(nvarchar(50),ECC)+'-'+Convert(nvarchar(50),PTO)+'-'+Convert(nvarchar(50),DP)+'-'+Convert(nvarchar(50),DENR_IDNumber)+'-'+Convert(nvarchar(50),DOHAccreditation)+'-'+Convert(nvarchar(50),AccreditedWasteHauler)  like '%" & Search.Text & "%' "
            Dim command3 As New SqlCommand(searchQuery3, connection)
            Dim adapter3 As New SqlDataAdapter(command3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            DataGridView1.DataSource = table3
        End If
    End Sub

    Private Sub load_datagrid()
        Dim cmd As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim table As New DataTable
        Dim bindingsource As New BindingSource
        Dim cmd1 As New SqlCommand
        Dim adapter1 As New SqlDataAdapter
        Dim table1 As New DataTable
        Dim bindingsource1 As New BindingSource
        Try
            connection.Open()
            cmd = New SqlCommand("SELECT  HospitalAndMedicalEstablishmentID,NameOfEstablishment,Address,EmailAddress,CEO_President,GeneralManager,PollutionControlOfficer,NatureOfBusiness,ContactNumber,NameOfAccreditedWasteHauler,ControlNumber,BrgyClearanceWithCTC,DTI_SEC,ECC,PTO,DP,DENR_IDNumber,DOHAccreditation,AccreditedWasteHauler FROM HospitalAndMedicalEstablishment_tbl", connection)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(table)
            bindingsource.DataSource = table
            DataGridView1.DataSource = bindingsource
            adapter.Update(table)
            DataGridView1.Refresh()
            cmd1 = New SqlCommand("SELECT  HospitalAndMedicalEstablishmentID,NameOfEstablishment,Address,EmailAddress,CEO_President,GeneralManager,PollutionControlOfficer,NatureOfBusiness,ContactNumber,NameOfAccreditedWasteHauler,ControlNumber,BrgyClearanceWithCTC,DTI_SEC,ECC,PTO,DP,DENR_IDNumber,DOHAccreditation,AccreditedWasteHauler FROM HospitalAndMedicalEstablishment_tbl", connection)
            adapter1 = New SqlDataAdapter(cmd1)
            adapter1.Fill(table1)
            bindingsource1.DataSource = table1
            DataGridView2.DataSource = bindingsource1
            adapter1.Update(table1)
            DataGridView2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub clearprofile()
        NameOfEstablishment.Clear()
        Address.Clear()
        EmailAddress.Clear()
        CEOPresident.Clear()
        GeneralManager.Clear()
        PollutionControlOfficer.Clear()
        NatureOfBusiness.Clear()
        ContactNumber.Clear()
        NameOfAccreditedWasteHauler.Clear()
        ControlNumber.Clear()
        BrgyClearance.Clear()
        DTISEC.Clear()
        ECC.Clear()
        PTO.Clear()
        DP.Clear()
        DENRIDNumber.Clear()
        DOHAccreditation.Clear()
        AccreditedWasteHauler.Clear()

    End Sub

    Private Sub clearrequirements()
        NameOfEstablishment1.Clear()
        ControlNumber1.Clear()
        BrgyClearance1.Clear()
        DTISEC1.Clear()
        ECC1.Clear()
        PTO1.Clear()
        DP1.Clear()
        DENRIDNumber1.Clear()
        AccreditedWasteHauler1.Clear()
        DOHAccreditation1.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DataGridView1.Rows(index)
            ControlNumber.Text = selectedrow.Cells(0).Value.ToString
            NameOfEstablishment.Text = selectedrow.Cells(1).Value.ToString
            Address.Text = selectedrow.Cells(2).Value.ToString
            EmailAddress.Text = selectedrow.Cells(3).Value.ToString
            CEOPresident.Text = selectedrow.Cells(4).Value.ToString
            GeneralManager.Text = selectedrow.Cells(5).Value.ToString
            PollutionControlOfficer.Text = selectedrow.Cells(6).Value.ToString
            NatureOfBusiness.Text = selectedrow.Cells(7).Value.ToString
            ContactNumber.Text = selectedrow.Cells(8).Value.ToString
            NameOfAccreditedWasteHauler.Text = selectedrow.Cells(9).Value.ToString
            BrgyClearance.Text = selectedrow.Cells(10).Value.ToString
            DTISEC.Text = selectedrow.Cells(11).Value.ToString
            ECC.Text = selectedrow.Cells(12).Value.ToString
            PTO.Text = selectedrow.Cells(13).Value.ToString
            DP.Text = selectedrow.Cells(14).Value.ToString
            DENRIDNumber.Text = selectedrow.Cells(15).Value.ToString
            DOHAccreditation.Text = selectedrow.Cells(16).Value.ToString
            AccreditedWasteHauler.Text = selectedrow.Cells(17).Value.ToString
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DataGridView2.Rows(index)
            NameOfEstablishment1.Text = selectedrow.Cells(0).Value.ToString
            ControlNumber1.Text = selectedrow.Cells(1).Value.ToString
            BrgyClearance1.Text = selectedrow.Cells(2).Value.ToString
            DTISEC1.Text = selectedrow.Cells(3).Value.ToString
            ECC1.Text = selectedrow.Cells(4).Value.ToString
            PTO1.Text = selectedrow.Cells(5).Value.ToString
            DP1.Text = selectedrow.Cells(6).Value.ToString
            DENRIDNumber1.Text = selectedrow.Cells(7).Value.ToString
            DOHAccreditation1.Text = selectedrow.Cells(8).Value.ToString
            AccreditedWasteHauler1.Text = selectedrow.Cells(9).Value.ToString
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Search.Clear()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        SearchReq.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        clearprofile()
    End Sub

    Private Sub HospitalAndEstablishmentForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control = True AndAlso e.KeyCode = Keys.N) Then
            NewButton.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.S) Then
            SaveButton.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.U) Then
            UpdateButton.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.D) Then
            DeleteButton.PerformClick()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.F) Then
            Search.Select()
        End If

        If (e.Control = True AndAlso e.KeyCode = Keys.F) Then
            SearchReq.Select()
        End If
    End Sub

    Private Sub ControlNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ControlNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub
End Class
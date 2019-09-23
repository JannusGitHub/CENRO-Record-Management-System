Imports System.Data.SqlClient


Public Class IEFForm
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

        If ComboBox1.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchReq.Focus()
        ElseIf ComboBox1.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQuery As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & SearchReq.Text & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView2.DataSource = table
        ElseIf ComboBox1.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQuery1 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & SearchReq.Text & "%' "
            Dim command1 As New SqlCommand(searchQuery1, connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            adapter1.Fill(table1)
            DataGridView2.DataSource = table1
        ElseIf ComboBox1.SelectedItem.ToString() = "All" Then
            Dim searchQuery2 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),BrgyClearanceWithCTC)+'-'+Convert(nvarchar(50),DTI_SEC)+'-'+Convert(nvarchar(50),ECC)+'-'+Convert(nvarchar(50),PTO)+'-'+Convert(nvarchar(50),DP)+'-'+Convert(nvarchar(50),BFAD)+'-'+Convert(nvarchar(50),AccreditedWasteHauler)+'-'+Convert(nvarchar(50),SelfMonitoringReport)  like '%" & SearchReq.Text & "%' "
            Dim command2 As New SqlCommand(searchQuery2, connection)
            Dim adapter2 As New SqlDataAdapter(command2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            DataGridView2.DataSource = table2
        End If
    End Sub

    Private Sub Search_TextChanged_1(sender As Object, e As EventArgs) Handles Search.TextChanged
        FilterData()
    End Sub

    Public Sub FilterData()
        'INITIALIZATION
        Dim table1 As New DataTable()
        Dim dataview As New DataView(table1)

        If ComboBox2.SelectedItem() = "" Then
            MessageBox.Show("Select category to search", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Search.Focus()
        ElseIf ComboBox2.SelectedItem.ToString() = "by Control Number" Then
            Dim searchQuery As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),ControlNumber)  like '%" & Search.Text & "%' "
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox2.SelectedItem.ToString() = "by Name of Establishment" Then
            Dim searchQuery1 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)  like '%" & Search.Text & "%' "
            Dim command1 As New SqlCommand(searchQuery1, connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            adapter1.Fill(table1)
            DataGridView1.DataSource = table1
        ElseIf ComboBox2.SelectedItem.ToString() = "by Address" Then
            Dim searchQuery2 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),Address)  like '%" & Search.Text & "%' "
            Dim command2 As New SqlCommand(searchQuery2, connection)
            Dim adapter2 As New SqlDataAdapter(command2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            DataGridView1.DataSource = table2
        ElseIf ComboBox2.SelectedItem.ToString() = "All" Then
            Dim searchQuery3 As String = "SELECT * From IndustrialEstablishmentFood_tbl WHERE Convert(nvarchar(50),NameOfEstablishment)+'-'+Convert(nvarchar(50),Address)+'-'+Convert(nvarchar(50),EmailAddress)+'-'+Convert(nvarchar(50),CEO_President)+'-'+Convert(nvarchar(50),GeneralManager)+'-'+Convert(nvarchar(50),PollutionControlOfficer)+'-'+Convert(nvarchar(50),NatureOfBusiness)+'-'+Convert(nvarchar(50),ContactNumber)+'-'+Convert(nvarchar(50),NameOfAccreditedWasteHauler)+'-'+Convert(nvarchar(50),ControlNumber)+'-'+Convert(nvarchar(50),BrgyClearanceWithCTC)+'-'+Convert(nvarchar(50),DTI_SEC)+'-'+Convert(nvarchar(50),ECC)+'-'+Convert(nvarchar(50),PTO)+'-'+Convert(nvarchar(50),DP)+'-'+Convert(nvarchar(50),BFAD)+'-'+Convert(nvarchar(50),AccreditedWasteHauler)+'-'+Convert(nvarchar(50),SelfMonitoringReport)  like '%" & Search.Text & "%' "
            Dim command3 As New SqlCommand(searchQuery3, connection)
            Dim adapter3 As New SqlDataAdapter(command3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            DataGridView1.DataSource = table3
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If NameOfEstablishment.Text = "" And Address.Text = "" And EmailAddress.Text = "" And CEOPresident.Text = "" And GeneralManager.Text = "" And PollutionControlOfficer.Text = "" And NatureOfBusiness.Text = "" And ContactNumber.Text = "" And NameOfAccreditedWasteHauler.Text = "" And ControlNumber.Text = "" And BrgyClearance.Text = "" And DTISEC.Text = "" And ECC.Text = "" And PTO.Text = "" And DP.Text = "" And BFAD.Text = "" And AccreditedWasteHauler.Text = "" And SMR.Text = "" Then
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
            ElseIf BFAD.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf AccreditedWasteHauler.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf SMR.Text = "" Then
                MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim command As SqlCommand
                Dim datareader As SqlDataReader

                connection.Open()
                command = New SqlCommand("select * from IndustrialEstablishmentFood_tbl where ControlNumber = '" & ControlNumber.Text & "'", connection)
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
                    Dim insertquery As String = "insert into IndustrialEstablishmentFood_tbl(NameOfEstablishment,Address,EmailAddress,CEO_President,GeneralManager,PollutionControlOfficer,NatureOfBusiness,ContactNumber,NameOfAccreditedWasteHauler,ControlNumber,BrgyClearanceWithCTC,DTI_SEC,ECC,PTO,DP,BFAD,AccreditedWasteHauler,SelfMonitoringReport) values (@NameOfEstablishment,@Address,@EmailAddress,@CEOPresident,@GeneralManager,@PollutionControlOfficer,@NatureOfBusiness,@ContactNumber,@NameOfAccreditedWasteHauler,@ControlNumber,@BrgyClearance,@DTISEC,@ECC,@PTO,@DP,@BFAD,@AccreditedWasteHauler,@SMR)"
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
                    cmd.Parameters.AddWithValue("@BFAD", BFAD.Text)
                    cmd.Parameters.AddWithValue("@AccreditedWasteHauler", AccreditedWasteHauler.Text)
                    cmd.Parameters.AddWithValue("@SMR", SMR.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear() 'clear all fields after inserted to database

                    'insert to another table(YearEndReport_tbl) to update the (Status) Column in that table, after inserting new company
                    Dim commandToUpdateStatus As New SqlCommand("SELECT * FROM IndustrialEstablishmentFood_tbl ORDER BY IndustrialEstablishmentFoodID DESC", connection)
                    Dim adapterToUpdateStatus As New SqlDataAdapter(commandToUpdateStatus)
                    Dim tableToUpdateStatus As New DataTable()
                    adapterToUpdateStatus.Fill(tableToUpdateStatus)

                    'open connection
                    If connection.State = ConnectionState.Closed Then connection.Open()

                    'declare variable reader to read data in database
                    Dim reader As SqlDataReader = commandToUpdateStatus.ExecuteReader

                    If reader.Read = True Then
                        'declaring variables to store data from the database
                        'this is the requirements column in IndustrialEstablishmentFood_tbl
                        Dim BrgyClearanceWithCTC As String = reader("BrgyClearanceWithCTC")
                        Dim DTI_SEC As String = reader("DTI_SEC")
                        Dim ECC As String = reader("ECC")
                        Dim PTO As String = reader("PTO")
                        Dim DP As String = reader("DP")
                        Dim BFAD As String = reader("BFAD")
                        Dim AccreditedWasteHauler As String = reader("AccreditedWasteHauler")
                        Dim SelfMonitoringReport As String = reader("SelfMonitoringReport")

                        'this is the column in YearEndReport_tbl
                        Dim IndustrialEstablishmentFoodID As String = reader("IndustrialEstablishmentFoodID")
                        Dim NameOfEstablishment As String = reader("NameOfEstablishment")
                        Dim Address As String = reader("Address")
                        Dim ControlNumber As String = reader("ControlNumber")
                        Dim compliantStatus As String = "Compliant"
                        Dim oathStatus As String = "Oath"

                        If BrgyClearanceWithCTC = "Compliant" And DTI_SEC = "Compliant" And ECC = "Compliant" And PTO = "Compliant" And DP = "Compliant" And BFAD = "Compliant" And AccreditedWasteHauler = "Compliant" And SelfMonitoringReport = "Compliant" Then
                            Dim insertCompliant As String = "INSERT into YearEndReport_tbl(IndustrialEstablishmentFoodID,NameOfEstablishment,Address,ControlNumber,Status) VALUES('" & IndustrialEstablishmentFoodID & "','" & NameOfEstablishment & "', '" & Address & "', '" & ControlNumber & "', '" & compliantStatus & "')"
                            Dim commandToInsertCompliant As New SqlCommand(insertCompliant, connection)
                            reader.Close()
                            commandToInsertCompliant.ExecuteNonQuery()
                            connection.Close()

                        ElseIf BrgyClearanceWithCTC = "Oath" Or DTI_SEC = "Oath" Or ECC = "Oath" Or PTO = "Oath" Or DP = "Oath" Or BFAD = "Oath" Or AccreditedWasteHauler = "Oath" Or SelfMonitoringReport = "Oath" Then
                            Dim insertOath As String = "INSERT into YearEndReport_tbl(IndustrialEstablishmentFoodID,NameOfEstablishment,Address,ControlNumber,Status) VALUES('" & IndustrialEstablishmentFoodID & "','" & NameOfEstablishment & "', '" & Address & "', '" & ControlNumber & "', '" & oathStatus & "')"
                            Dim commandToInsertOath As New SqlCommand(insertOath, connection)
                            reader.Close()
                            commandToInsertOath.ExecuteNonQuery()
                            connection.Close()
                        End If
                    End If

                    'close the connection and the reader
                    reader.Close()
                    If connection.State = ConnectionState.Open Then connection.Close()
                End If
                'close the connection and the reader
                datareader.Close()
                connection.Close()
            End If
            load_datagrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If NameOfEstablishment.Text = "" And Address.Text = "" And EmailAddress.Text = "" And CEOPresident.Text = "" And GeneralManager.Text = "" And PollutionControlOfficer.Text = "" And NatureOfBusiness.Text = "" And ContactNumber.Text = "" And NameOfAccreditedWasteHauler.Text = "" And ControlNumber.Text = "" And BrgyClearance.Text = "" And DTISEC.Text = "" And ECC.Text = "" And PTO.Text = "" And DP.Text = "" And BFAD.Text = "" And AccreditedWasteHauler.Text = "" And SMR.Text = "" Then
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
        ElseIf BFAD.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf AccreditedWasteHauler.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SMR.Text = "" Then
            MessageBox.Show("Please fill the blanks", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Updatequery As String = "Select * From IndustrialEstablishmentFood_tbl WHERE ControlNumber = '" & ControlNumber.Text & "' "
            Dim cmd As New SqlCommand(Updatequery, connection)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count() = 0 Then
                MessageBox.Show("No records found!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                ControlNumber.Focus()
            Else
                Dim Update1 As String = "UPDATE IndustrialEstablishmentFood_tbl set NameOfEstablishment = '" & NameOfEstablishment.Text & "', Address = '" & Address.Text & "', EmailAddress = '" & EmailAddress.Text & "', CEO_President = '" & CEOPresident.Text & "', GeneralManager = '" & GeneralManager.Text & "', PollutionControlOfficer = '" & PollutionControlOfficer.Text & "', NatureOfBusiness = '" & NatureOfBusiness.Text & "', ContactNumber = '" & ContactNumber.Text & "', NameOfAccreditedWasteHauler = '" & NameOfAccreditedWasteHauler.Text & "', BrgyClearanceWithCTC = '" & BrgyClearance.Text & "', DTI_SEC = '" & DTISEC.Text & "', ECC = '" & ECC.Text & "', PTO = '" & PTO.Text & "', DP = '" & DP.Text & "', BFAD = '" & BFAD.Text & "', AccreditedWasteHauler = '" & AccreditedWasteHauler.Text & "', SelfMonitoringReport = '" & SMR.Text & "' WHERE ControlNumber = '" & ControlNumber.Text & "' "
                Dim cmd1 As New SqlCommand(Update1, connection)
                Dim adapter1 As New SqlDataAdapter(cmd1)
                Dim table1 As New DataTable
                adapter1.Fill(table1)
                connection.Open()
                cmd1.ExecuteNonQuery()
                MessageBox.Show("Successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
                clear()
            End If
            connection.Close()
        End If

        connection.Close()

        load_datagrid()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If ControlNumber.Text = "" Then
                MessageBox.Show("You must enter the control number!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ControlNumber.Focus()
            Else
                Dim Delete As String = "Select * from IndustrialEstablishmentFood_tbl WHERE ControlNumber = '" & ControlNumber.Text & "'"
                Dim cmd As New SqlCommand(Delete, connection)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("No records found!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    clear()
                    ControlNumber.Focus()
                Else
                    Dim message As String = "Are you sure to delete?"
                    Dim caption As String = "Confirmation"
                    Dim icons As String = MessageBoxIcon.Warning
                    Dim buttons As String = MessageBoxButtons.YesNo
                    Dim result As DialogResult
                    result = MessageBox.Show(Me, message, caption, buttons, icons)

                    If result = DialogResult.Yes Then
                        Dim Delete1 As String = "delete from IndustrialEstablishmentFood_tbl WHERE ControlNumber = '" & ControlNumber.Text & "'"
                        Dim cmd1 As New SqlCommand(Delete1, connection)
                        Dim adapter1 As New SqlDataAdapter(cmd1)
                        Dim table1 As New DataTable
                        adapter1.Fill(table1)
                        connection.Open()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clear()
                        connection.Close()
                    Else
                        clear()
                        Me.Refresh()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        load_datagrid()
    End Sub

    Private Sub CompanyManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cenro_DBDataSet.IndustrialEstablishmentFood_tbl' table. You can move, or remove it, as needed.
        Me.IndustrialEstablishmentFood_tblTableAdapter.Fill(Me.Cenro_DBDataSet.IndustrialEstablishmentFood_tbl)

        Me.KeyPreview = True
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
            cmd = New SqlCommand("select  IndustrialEstablishmentFoodID,NameOfEstablishment,Address,EmailAddress,CEO_President,GeneralManager,PollutionControlOfficer,NatureOfBusiness,ContactNumber,NameOfAccreditedWasteHauler,ControlNumber,BrgyClearanceWithCTC,DTI_SEC,ECC,PTO,DP,BFAD,AccreditedWasteHauler,SelfMonitoringReport from IndustrialEstablishmentFood_tbl", connection)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(table)
            bindingsource.DataSource = table
            DataGridView1.DataSource = bindingsource
            adapter.Update(table)
            DataGridView1.Refresh()
            cmd1 = New SqlCommand("select  IndustrialEstablishmentFoodID,NameOfEstablishment,Address,EmailAddress,CEO_President,GeneralManager,PollutionControlOfficer,NatureOfBusiness,ContactNumber,NameOfAccreditedWasteHauler,ControlNumber,BrgyClearanceWithCTC,DTI_SEC,ECC,PTO,DP,BFAD,AccreditedWasteHauler,SelfMonitoringReport from IndustrialEstablishmentFood_tbl", connection)
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

    Private Sub clear()
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
        If BrgyClearance.Text = BrgyClearance.SelectedItem Then
            BrgyClearance.Text = ""
        End If
        If DTISEC.Text = DTISEC.SelectedItem Then
            DTISEC.Text = ""
        End If
        If ECC.Text = ECC.SelectedItem Then
            ECC.Text = ""
        End If
        If PTO.Text = PTO.SelectedItem Then
            PTO.Text = ""
        End If
        If DP.Text = DP.SelectedItem Then
            DP.Text = ""
        End If
        If BFAD.Text = BFAD.SelectedItem Then
            BFAD.Text = ""
        End If
        If AccreditedWasteHauler.Text = AccreditedWasteHauler.SelectedItem Then
            AccreditedWasteHauler.Text = ""
        End If
        If SMR.Text = SMR.SelectedItem Then
            SMR.Text = ""
        End If
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
            BFAD.Text = selectedrow.Cells(15).Value.ToString
            AccreditedWasteHauler.Text = selectedrow.Cells(16).Value.ToString
            SMR.Text = selectedrow.Cells(17).Value.ToString
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DataGridView2.Rows(index)
            NameOfEstablishmentReq.Text = selectedrow.Cells(0).Value.ToString
            ControlNumber1.Text = selectedrow.Cells(1).Value.ToString
            BrgyClearance1.Text = selectedrow.Cells(2).Value.ToString
            DTISEC1.Text = selectedrow.Cells(3).Value.ToString
            ECC1.Text = selectedrow.Cells(4).Value.ToString
            PTO1.Text = selectedrow.Cells(5).Value.ToString
            DP1.Text = selectedrow.Cells(6).Value.ToString
            BFAD1.Text = selectedrow.Cells(7).Value.ToString
            AccreditedWasteHauler1.Text = selectedrow.Cells(8).Value.ToString
            SMR1.Text = selectedrow.Cells(9).Value.ToString
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Search.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SearchReq.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        clear()
    End Sub

    Private Sub IEFForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        ElseIf (e.Control = True AndAlso e.KeyCode = Keys.F) Then
            SearchReq.Select()
        End If
    End Sub

    Private Sub ControlNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ControlNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub NameOfEstablishment_TextChanged(sender As Object, e As EventArgs) Handles NameOfEstablishment.TextChanged
        NameOfEstablishment.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(NameOfEstablishment.Text.ToLower)
        NameOfEstablishment.Select(NameOfEstablishment.Text.Length, 0)
    End Sub

    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles Address.TextChanged
        Address.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Address.Text.ToLower)
        Address.Select(Address.Text.Length, 0)
    End Sub

    Private Sub EmailAddress_TextChanged(sender As Object, e As EventArgs) Handles EmailAddress.TextChanged

    End Sub

    Private Sub CEOPresident_TextChanged(sender As Object, e As EventArgs) Handles CEOPresident.TextChanged
        CEOPresident.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(CEOPresident.Text.ToLower)
        CEOPresident.Select(CEOPresident.Text.Length, 0)
    End Sub

    Private Sub GeneralManager_TextChanged(sender As Object, e As EventArgs) Handles GeneralManager.TextChanged
        GeneralManager.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(GeneralManager.Text.ToLower)
        GeneralManager.Select(GeneralManager.Text.Length, 0)
    End Sub

    Private Sub PollutionControlOfficer_TextChanged(sender As Object, e As EventArgs) Handles PollutionControlOfficer.TextChanged
        PollutionControlOfficer.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(PollutionControlOfficer.Text.ToLower)
        PollutionControlOfficer.Select(PollutionControlOfficer.Text.Length, 0)
    End Sub

    Private Sub NatureOfBusiness_TextChanged(sender As Object, e As EventArgs) Handles NatureOfBusiness.TextChanged
        NatureOfBusiness.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(NatureOfBusiness.Text.ToLower)
        NatureOfBusiness.Select(NatureOfBusiness.Text.Length, 0)
    End Sub

    Private Sub NameOfAccreditedWasteHauler_TextChanged(sender As Object, e As EventArgs) Handles NameOfAccreditedWasteHauler.TextChanged
        NameOfAccreditedWasteHauler.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(NameOfAccreditedWasteHauler.Text.ToLower)
        NameOfAccreditedWasteHauler.Select(NameOfAccreditedWasteHauler.Text.Length, 0)
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

    Private Sub ControlNumber_KeyUp(sender As Object, e As KeyEventArgs) Handles ControlNumber.KeyUp

        'Dim lagunaCode = "19200"
        'Dim controlNumString As String = String.Format("{0}-{1}-", lagunaCode.Substring(0, 3), lagunaCode.Substring(3, 2))
        'ControlNumber.Text = controlNumString
        'If ControlNumber.TextLength = 3 Then
        '    Dim strTemp2 As String
        '    strTemp2 = Microsoft.VisualBasic.Right(ControlNumber.Text, 3) & "-"
        '    ControlNumber.Text = strTemp2
        'End If

        'If ControlNumber.TextLength = 9 Then
        '    Dim strTemp2 As String
        '    strTemp2 = Microsoft.VisualBasic.Left(ControlNumber.Text, 2) & "-"
        '    ControlNumber.Text = strTemp2
        'End If
    End Sub

    Private Sub BrgyClearance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SMR.KeyPress, PTO.KeyPress, ECC.KeyPress, DTISEC.KeyPress, DP.KeyPress, BrgyClearance.KeyPress, BFAD.KeyPress, AccreditedWasteHauler.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = ""
            If Not allowedchars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
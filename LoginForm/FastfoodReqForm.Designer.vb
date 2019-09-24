<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FastfoodReqForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FastfoodReqForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Print = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SearchReq = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.NameOfEstablishmentReq = New System.Windows.Forms.TextBox()
        Me.ControlNumber1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BrgyClearance1 = New System.Windows.Forms.TextBox()
        Me.AccreditedWasteHauler1 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DTISEC1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DP1 = New System.Windows.Forms.TextBox()
        Me.ECC1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PTO1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameOfEstablishmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTI_SEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ECCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FastfoodCanteenAndRestauranttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cenro_DBDataSet = New LoginForm.cenro_DBDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FastfoodCanteenAndRestaurant_tblTableAdapter = New LoginForm.cenro_DBDataSetTableAdapters.FastfoodCanteenAndRestaurant_tblTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FastfoodCanteenAndRestauranttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cenro_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 35)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(670, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.NameOfEstablishmentReq)
        Me.GroupBox1.Controls.Add(Me.ControlNumber1)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.BrgyClearance1)
        Me.GroupBox1.Controls.Add(Me.AccreditedWasteHauler1)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.DTISEC1)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.DP1)
        Me.GroupBox1.Controls.Add(Me.ECC1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.PTO1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 605)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ClearButton)
        Me.GroupBox2.Controls.Add(Me.Print)
        Me.GroupBox2.Location = New System.Drawing.Point(595, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 95)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Image = CType(resources.GetObject("ClearButton.Image"), System.Drawing.Image)
        Me.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearButton.Location = New System.Drawing.Point(6, 56)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(92, 34)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "        Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Print
        '
        Me.Print.FlatAppearance.BorderSize = 0
        Me.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Print.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.Image = CType(resources.GetObject("Print.Image"), System.Drawing.Image)
        Me.Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Print.Location = New System.Drawing.Point(6, 14)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(92, 34)
        Me.Print.TabIndex = 9
        Me.Print.Text = "        &Print"
        Me.Print.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.SearchReq)
        Me.Panel3.Location = New System.Drawing.Point(5, 318)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 27)
        Me.Panel3.TabIndex = 98
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(250, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SearchReq
        '
        Me.SearchReq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchReq.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchReq.Location = New System.Drawing.Point(26, 2)
        Me.SearchReq.Multiline = True
        Me.SearchReq.Name = "SearchReq"
        Me.SearchReq.Size = New System.Drawing.Size(224, 23)
        Me.SearchReq.TabIndex = 72
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(189, 21)
        Me.Label29.TabIndex = 90
        Me.Label29.Text = "Name of Establishment"
        '
        'NameOfEstablishmentReq
        '
        Me.NameOfEstablishmentReq.BackColor = System.Drawing.Color.White
        Me.NameOfEstablishmentReq.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameOfEstablishmentReq.Location = New System.Drawing.Point(20, 56)
        Me.NameOfEstablishmentReq.Multiline = True
        Me.NameOfEstablishmentReq.Name = "NameOfEstablishmentReq"
        Me.NameOfEstablishmentReq.ReadOnly = True
        Me.NameOfEstablishmentReq.Size = New System.Drawing.Size(202, 24)
        Me.NameOfEstablishmentReq.TabIndex = 1
        '
        'ControlNumber1
        '
        Me.ControlNumber1.BackColor = System.Drawing.Color.White
        Me.ControlNumber1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlNumber1.Location = New System.Drawing.Point(20, 107)
        Me.ControlNumber1.Multiline = True
        Me.ControlNumber1.Name = "ControlNumber1"
        Me.ControlNumber1.ReadOnly = True
        Me.ControlNumber1.Size = New System.Drawing.Size(202, 24)
        Me.ControlNumber1.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 83)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 21)
        Me.Label26.TabIndex = 88
        Me.Label26.Text = "Control Number"
        '
        'BrgyClearance1
        '
        Me.BrgyClearance1.BackColor = System.Drawing.Color.White
        Me.BrgyClearance1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrgyClearance1.Location = New System.Drawing.Point(20, 158)
        Me.BrgyClearance1.Multiline = True
        Me.BrgyClearance1.Name = "BrgyClearance1"
        Me.BrgyClearance1.ReadOnly = True
        Me.BrgyClearance1.Size = New System.Drawing.Size(202, 24)
        Me.BrgyClearance1.TabIndex = 3
        '
        'AccreditedWasteHauler1
        '
        Me.AccreditedWasteHauler1.BackColor = System.Drawing.Color.White
        Me.AccreditedWasteHauler1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccreditedWasteHauler1.Location = New System.Drawing.Point(273, 158)
        Me.AccreditedWasteHauler1.Multiline = True
        Me.AccreditedWasteHauler1.Name = "AccreditedWasteHauler1"
        Me.AccreditedWasteHauler1.ReadOnly = True
        Me.AccreditedWasteHauler1.Size = New System.Drawing.Size(202, 24)
        Me.AccreditedWasteHauler1.TabIndex = 8
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 134)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(134, 21)
        Me.Label25.TabIndex = 82
        Me.Label25.Text = "Brgy. Clearance"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(268, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(207, 21)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Accredited Waste Hauler"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 185)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 21)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "DTI/SEC"
        '
        'DTISEC1
        '
        Me.DTISEC1.BackColor = System.Drawing.Color.White
        Me.DTISEC1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTISEC1.Location = New System.Drawing.Point(20, 209)
        Me.DTISEC1.Multiline = True
        Me.DTISEC1.Name = "DTISEC1"
        Me.DTISEC1.ReadOnly = True
        Me.DTISEC1.Size = New System.Drawing.Size(202, 24)
        Me.DTISEC1.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 236)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 21)
        Me.Label23.TabIndex = 84
        Me.Label23.Text = "ECC"
        '
        'DP1
        '
        Me.DP1.BackColor = System.Drawing.Color.White
        Me.DP1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DP1.Location = New System.Drawing.Point(273, 107)
        Me.DP1.Multiline = True
        Me.DP1.Name = "DP1"
        Me.DP1.ReadOnly = True
        Me.DP1.Size = New System.Drawing.Size(202, 24)
        Me.DP1.TabIndex = 7
        '
        'ECC1
        '
        Me.ECC1.BackColor = System.Drawing.Color.White
        Me.ECC1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECC1.Location = New System.Drawing.Point(20, 260)
        Me.ECC1.Multiline = True
        Me.ECC1.Name = "ECC1"
        Me.ECC1.ReadOnly = True
        Me.ECC1.Size = New System.Drawing.Size(202, 24)
        Me.ECC1.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(269, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 21)
        Me.Label21.TabIndex = 86
        Me.Label21.Text = "DP"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(269, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 21)
        Me.Label22.TabIndex = 85
        Me.Label22.Text = "PTO"
        '
        'PTO1
        '
        Me.PTO1.BackColor = System.Drawing.Color.White
        Me.PTO1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PTO1.Location = New System.Drawing.Point(273, 56)
        Me.PTO1.Multiline = True
        Me.PTO1.Name = "PTO1"
        Me.PTO1.ReadOnly = True
        Me.PTO1.Size = New System.Drawing.Size(202, 24)
        Me.PTO1.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(357, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 21)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Search Category"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"by Control Number", "by Name of Establishment", "All"})
        Me.ComboBox1.Location = New System.Drawing.Point(362, 318)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 25)
        Me.ComboBox1.TabIndex = 73
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1, 294)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 21)
        Me.Label28.TabIndex = 71
        Me.Label28.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 26
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameOfEstablishmentDataGridViewTextBoxColumn, Me.ControlNumberDataGridViewTextBoxColumn, Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn, Me.DTI_SEC, Me.ECCDataGridViewTextBoxColumn, Me.PTODataGridViewTextBoxColumn, Me.DPDataGridViewTextBoxColumn, Me.AccreditedWasteHaulerDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FastfoodCanteenAndRestauranttblBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(5, 351)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(691, 250)
        Me.DataGridView1.TabIndex = 70
        '
        'NameOfEstablishmentDataGridViewTextBoxColumn
        '
        Me.NameOfEstablishmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NameOfEstablishmentDataGridViewTextBoxColumn.DataPropertyName = "NameOfEstablishment"
        Me.NameOfEstablishmentDataGridViewTextBoxColumn.HeaderText = "Name of Establishment"
        Me.NameOfEstablishmentDataGridViewTextBoxColumn.Name = "NameOfEstablishmentDataGridViewTextBoxColumn"
        Me.NameOfEstablishmentDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameOfEstablishmentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NameOfEstablishmentDataGridViewTextBoxColumn.Width = 212
        '
        'ControlNumberDataGridViewTextBoxColumn
        '
        Me.ControlNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ControlNumberDataGridViewTextBoxColumn.DataPropertyName = "ControlNumber"
        Me.ControlNumberDataGridViewTextBoxColumn.HeaderText = "Control Number"
        Me.ControlNumberDataGridViewTextBoxColumn.Name = "ControlNumberDataGridViewTextBoxColumn"
        Me.ControlNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ControlNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ControlNumberDataGridViewTextBoxColumn.Width = 158
        '
        'BrgyClearanceWithCTCDataGridViewTextBoxColumn
        '
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn.DataPropertyName = "BrgyClearanceWithCTC"
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn.HeaderText = "Brgy. Clearance"
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn.Name = "BrgyClearanceWithCTCDataGridViewTextBoxColumn"
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BrgyClearanceWithCTCDataGridViewTextBoxColumn.Width = 157
        '
        'DTI_SEC
        '
        Me.DTI_SEC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DTI_SEC.DataPropertyName = "DTI_SEC"
        Me.DTI_SEC.HeaderText = "DTI/SEC"
        Me.DTI_SEC.Name = "DTI_SEC"
        Me.DTI_SEC.ReadOnly = True
        Me.DTI_SEC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTI_SEC.Width = 95
        '
        'ECCDataGridViewTextBoxColumn
        '
        Me.ECCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ECCDataGridViewTextBoxColumn.DataPropertyName = "ECC"
        Me.ECCDataGridViewTextBoxColumn.HeaderText = "ECC"
        Me.ECCDataGridViewTextBoxColumn.Name = "ECCDataGridViewTextBoxColumn"
        Me.ECCDataGridViewTextBoxColumn.ReadOnly = True
        Me.ECCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ECCDataGridViewTextBoxColumn.Width = 68
        '
        'PTODataGridViewTextBoxColumn
        '
        Me.PTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PTODataGridViewTextBoxColumn.DataPropertyName = "PTO"
        Me.PTODataGridViewTextBoxColumn.HeaderText = "PTO"
        Me.PTODataGridViewTextBoxColumn.Name = "PTODataGridViewTextBoxColumn"
        Me.PTODataGridViewTextBoxColumn.ReadOnly = True
        Me.PTODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PTODataGridViewTextBoxColumn.Width = 64
        '
        'DPDataGridViewTextBoxColumn
        '
        Me.DPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DPDataGridViewTextBoxColumn.DataPropertyName = "DP"
        Me.DPDataGridViewTextBoxColumn.HeaderText = "DP"
        Me.DPDataGridViewTextBoxColumn.Name = "DPDataGridViewTextBoxColumn"
        Me.DPDataGridViewTextBoxColumn.ReadOnly = True
        Me.DPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DPDataGridViewTextBoxColumn.Width = 54
        '
        'AccreditedWasteHaulerDataGridViewTextBoxColumn
        '
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn.DataPropertyName = "AccreditedWasteHauler"
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn.HeaderText = "Accredited Waste Hauler"
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn.Name = "AccreditedWasteHaulerDataGridViewTextBoxColumn"
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccreditedWasteHaulerDataGridViewTextBoxColumn.Width = 230
        '
        'FastfoodCanteenAndRestauranttblBindingSource
        '
        Me.FastfoodCanteenAndRestauranttblBindingSource.DataMember = "FastfoodCanteenAndRestaurant_tbl"
        Me.FastfoodCanteenAndRestauranttblBindingSource.DataSource = Me.Cenro_DBDataSet
        '
        'Cenro_DBDataSet
        '
        Me.Cenro_DBDataSet.DataSetName = "cenro_DBDataSet"
        Me.Cenro_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(148, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(395, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Fastfood, Canteen and Restaurant Requirements"
        '
        'FastfoodCanteenAndRestaurant_tblTableAdapter
        '
        Me.FastfoodCanteenAndRestaurant_tblTableAdapter.ClearBeforeFill = True
        '
        'FastfoodReqForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 660)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FastfoodReqForm"
        Me.Text = "FastfoodReqForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FastfoodCanteenAndRestauranttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cenro_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SearchReq As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents NameOfEstablishmentReq As TextBox
    Friend WithEvents ControlNumber1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents BrgyClearance1 As TextBox
    Friend WithEvents AccreditedWasteHauler1 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents DTISEC1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents DP1 As TextBox
    Friend WithEvents ECC1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PTO1 As TextBox
    Friend WithEvents Cenro_DBDataSet As cenro_DBDataSet
    Friend WithEvents FastfoodCanteenAndRestauranttblBindingSource As BindingSource
    Friend WithEvents FastfoodCanteenAndRestaurant_tblTableAdapter As cenro_DBDataSetTableAdapters.FastfoodCanteenAndRestaurant_tblTableAdapter
    Friend WithEvents DTISECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameOfEstablishmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ControlNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrgyClearanceWithCTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTI_SEC As DataGridViewTextBoxColumn
    Friend WithEvents ECCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccreditedWasteHaulerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents Print As Button
End Class

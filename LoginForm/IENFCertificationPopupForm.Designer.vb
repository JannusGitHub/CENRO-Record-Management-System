<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IENFCertificationPopupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IENFCertificationPopupForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ControlNumber1 = New System.Windows.Forms.TextBox()
        Me.Address1 = New System.Windows.Forms.TextBox()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Owner1 = New System.Windows.Forms.TextBox()
        Me.NameOfEstablishment1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Print = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateNow1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 35)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(516, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ControlNumber1)
        Me.GroupBox1.Controls.Add(Me.Address1)
        Me.GroupBox1.Controls.Add(Me.Cancelbtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Owner1)
        Me.GroupBox1.Controls.Add(Me.NameOfEstablishment1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Print)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateNow1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 503)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(212, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Certification"
        '
        'ControlNumber1
        '
        Me.ControlNumber1.Enabled = False
        Me.ControlNumber1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlNumber1.Location = New System.Drawing.Point(154, 84)
        Me.ControlNumber1.Multiline = True
        Me.ControlNumber1.Name = "ControlNumber1"
        Me.ControlNumber1.Size = New System.Drawing.Size(231, 28)
        Me.ControlNumber1.TabIndex = 0
        '
        'Address1
        '
        Me.Address1.Enabled = False
        Me.Address1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1.Location = New System.Drawing.Point(154, 203)
        Me.Address1.Multiline = True
        Me.Address1.Name = "Address1"
        Me.Address1.Size = New System.Drawing.Size(231, 28)
        Me.Address1.TabIndex = 2
        '
        'Cancelbtn
        '
        Me.Cancelbtn.FlatAppearance.BorderSize = 0
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelbtn.Image = CType(resources.GetObject("Cancelbtn.Image"), System.Drawing.Image)
        Me.Cancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancelbtn.Location = New System.Drawing.Point(259, 373)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(117, 34)
        Me.Cancelbtn.TabIndex = 6
        Me.Cancelbtn.Text = "          &Cancel"
        Me.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name of Establishment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date"
        '
        'Owner1
        '
        Me.Owner1.Enabled = False
        Me.Owner1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owner1.Location = New System.Drawing.Point(154, 267)
        Me.Owner1.Multiline = True
        Me.Owner1.Name = "Owner1"
        Me.Owner1.Size = New System.Drawing.Size(231, 28)
        Me.Owner1.TabIndex = 3
        '
        'NameOfEstablishment1
        '
        Me.NameOfEstablishment1.Enabled = False
        Me.NameOfEstablishment1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameOfEstablishment1.Location = New System.Drawing.Point(154, 144)
        Me.NameOfEstablishment1.Multiline = True
        Me.NameOfEstablishment1.Name = "NameOfEstablishment1"
        Me.NameOfEstablishment1.Size = New System.Drawing.Size(231, 28)
        Me.NameOfEstablishment1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Control Number"
        '
        'Print
        '
        Me.Print.FlatAppearance.BorderSize = 0
        Me.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Print.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.Image = CType(resources.GetObject("Print.Image"), System.Drawing.Image)
        Me.Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Print.Location = New System.Drawing.Point(163, 373)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(90, 34)
        Me.Print.TabIndex = 5
        Me.Print.Text = "         &Print"
        Me.Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Print.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Owner"
        '
        'DateNow1
        '
        Me.DateNow1.CustomFormat = "yyyy-MM-dd"
        Me.DateNow1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNow1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateNow1.Location = New System.Drawing.Point(154, 325)
        Me.DateNow1.Name = "DateNow1"
        Me.DateNow1.Size = New System.Drawing.Size(231, 22)
        Me.DateNow1.TabIndex = 4
        '
        'IENFCertificationPopupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 538)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IENFCertificationPopupForm"
        Me.Text = "IENFCertificationPopupForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ControlNumber1 As TextBox
    Friend WithEvents Address1 As TextBox
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Owner1 As TextBox
    Friend WithEvents NameOfEstablishment1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Print As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateNow1 As DateTimePicker
End Class

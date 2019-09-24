<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPasswordform))
        Me.Question = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Answer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Usernamelbl = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Submitbtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Question
        '
        Me.Question.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question.FormattingEnabled = True
        Me.Question.Items.AddRange(New Object() {"What's your dream job?", "What's your favorite movie?", "What's your favorite band?", "What was your mother's occupation?", "What was your Father's occupation?"})
        Me.Question.Location = New System.Drawing.Point(113, 360)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(175, 24)
        Me.Question.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(109, 394)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 21)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Answer"
        '
        'Answer
        '
        Me.Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer.Location = New System.Drawing.Point(113, 418)
        Me.Answer.Multiline = True
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(175, 23)
        Me.Answer.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 21)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Security Question"
        '
        'Usernamelbl
        '
        Me.Usernamelbl.AutoSize = True
        Me.Usernamelbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamelbl.Location = New System.Drawing.Point(109, 274)
        Me.Usernamelbl.Name = "Usernamelbl"
        Me.Usernamelbl.Size = New System.Drawing.Size(88, 21)
        Me.Usernamelbl.TabIndex = 66
        Me.Usernamelbl.Text = "Username"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(113, 298)
        Me.Username.Multiline = True
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(175, 23)
        Me.Username.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 3)
        Me.Panel2.TabIndex = 68
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(100, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 200)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Submitbtn
        '
        Me.Submitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Submitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Submitbtn.FlatAppearance.BorderSize = 0
        Me.Submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Submitbtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submitbtn.ForeColor = System.Drawing.Color.White
        Me.Submitbtn.Image = CType(resources.GetObject("Submitbtn.Image"), System.Drawing.Image)
        Me.Submitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Submitbtn.Location = New System.Drawing.Point(113, 468)
        Me.Submitbtn.Name = "Submitbtn"
        Me.Submitbtn.Size = New System.Drawing.Size(175, 31)
        Me.Submitbtn.TabIndex = 4
        Me.Submitbtn.Text = "Submit"
        Me.Submitbtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(382, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'ForgotPasswordform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(410, 521)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Usernamelbl)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Submitbtn)
        Me.Controls.Add(Me.Question)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Answer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPasswordform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Question As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Answer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Submitbtn As Button
    Friend WithEvents Usernamelbl As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class

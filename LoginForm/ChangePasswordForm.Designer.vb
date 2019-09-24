<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasswordForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ChangePasswordbtn = New System.Windows.Forms.Button()
        Me.ConfirmPasswordlbl = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.NewPasswordlbl = New System.Windows.Forms.Label()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 3)
        Me.Panel2.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(382, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'ChangePasswordbtn
        '
        Me.ChangePasswordbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ChangePasswordbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChangePasswordbtn.FlatAppearance.BorderSize = 0
        Me.ChangePasswordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePasswordbtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswordbtn.ForeColor = System.Drawing.Color.White
        Me.ChangePasswordbtn.Image = CType(resources.GetObject("ChangePasswordbtn.Image"), System.Drawing.Image)
        Me.ChangePasswordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangePasswordbtn.Location = New System.Drawing.Point(113, 413)
        Me.ChangePasswordbtn.Name = "ChangePasswordbtn"
        Me.ChangePasswordbtn.Size = New System.Drawing.Size(175, 31)
        Me.ChangePasswordbtn.TabIndex = 66
        Me.ChangePasswordbtn.Text = "    Change Password"
        Me.ChangePasswordbtn.UseVisualStyleBackColor = False
        '
        'ConfirmPasswordlbl
        '
        Me.ConfirmPasswordlbl.AutoSize = True
        Me.ConfirmPasswordlbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordlbl.Location = New System.Drawing.Point(109, 338)
        Me.ConfirmPasswordlbl.Name = "ConfirmPasswordlbl"
        Me.ConfirmPasswordlbl.Size = New System.Drawing.Size(147, 21)
        Me.ConfirmPasswordlbl.TabIndex = 68
        Me.ConfirmPasswordlbl.Text = "Confirm Password"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.Location = New System.Drawing.Point(113, 362)
        Me.ConfirmPassword.Multiline = True
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(175, 23)
        Me.ConfirmPassword.TabIndex = 65
        '
        'NewPasswordlbl
        '
        Me.NewPasswordlbl.AutoSize = True
        Me.NewPasswordlbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordlbl.Location = New System.Drawing.Point(109, 274)
        Me.NewPasswordlbl.Name = "NewPasswordlbl"
        Me.NewPasswordlbl.Size = New System.Drawing.Size(122, 21)
        Me.NewPasswordlbl.TabIndex = 67
        Me.NewPasswordlbl.Text = "New Password"
        '
        'NewPassword
        '
        Me.NewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassword.Location = New System.Drawing.Point(113, 298)
        Me.NewPassword.Multiline = True
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassword.Size = New System.Drawing.Size(175, 23)
        Me.NewPassword.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(100, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 200)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(410, 521)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChangePasswordbtn)
        Me.Controls.Add(Me.ConfirmPasswordlbl)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.NewPasswordlbl)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePasswordForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ChangePasswordbtn As Button
    Friend WithEvents ConfirmPasswordlbl As Label
    Friend WithEvents ConfirmPassword As TextBox
    Friend WithEvents NewPasswordlbl As Label
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

Imports System.Data.SqlClient

Public Class Main
    Dim mouse_move As System.Drawing.Point
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8; Initial Catalog=cenro_DB; Integrated Security=True")
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim message As String = "Do you want to exit?"
        Dim caption As String = "Confirmation"
        Dim icons As String = MessageBoxIcon.Question
        Dim buttons As String = MessageBoxButtons.YesNo
        Dim result As DialogResult
        result = MessageBox.Show(Me, message, caption, buttons, icons)

        If result = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Select all active forms in MDIpanel then close it and me.Show()
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With Category
            .TopLevel = False
            MDIpanel.Controls.Add(Category)
            .BringToFront()
            .Show()
        End With



        'With Category
        '  .TopLevel = False
        'MDIpanel.Controls.Add(Category)
        '.BringToFront()
        ' .Show()
        'ActivateOrDeactivateForm.Close()
        'CompanyManagementForm.Close()
        'FastfoodCanteenAndRestoForm.Close()
        '  HospitalAndEstablishmentForm.Close()
        ' IndustrialEstablishmentNonFoodForm.Close()
        ' UserManagementForm.Close()
        ' End With
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With UserManagementForm
            .TopLevel = False
            MDIpanel.Controls.Add(UserManagementForm)
            .BringToFront()
            .Show()
        End With




        'With UserManagementForm
        '.TopLevel = False
        ' MDIpanel.Controls.Add(UserManagementForm)
        '.BringToFront()
        '.Show()
        'ActivateOrDeactivateForm.Close()
        'Category.Close()
        'CompanyManagementForm.Close()
        'FastfoodCanteenAndRestoForm.Close()
        '  HospitalAndEstablishmentForm.Close()
        'IndustrialEstablishmentNonFoodForm.Close()
        'End With
    End Sub

    Private Sub Activate_Click(sender As Object, e As EventArgs) Handles Activate.Click
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With ActivateOrDeactivateForm
            .TopLevel = False
            MDIpanel.Controls.Add(ActivateOrDeactivateForm)
            .BringToFront()
            .Show()
        End With


        'With ActivateOrDeactivateForm
        'TopLevel = False
        'MDIpanel.Controls.Add(ActivateOrDeactivateForm)
        '.BringToFront()
        '.Show()
        'Category.Close()
        'CompanyManagementForm.Close()
        'FastfoodCanteenAndRestoForm.Close()
        'HospitalAndEstablishmentForm.Close()
        'IndustrialEstablishmentNonFoodForm.Close()
        'UserManagementForm.Close()
        'End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim message As String = "Do you want to logout?"
        Dim caption As String = "Confirmation"
        Dim icons As String = MessageBoxIcon.Question
        Dim buttons As String = MessageBoxButtons.YesNo
        Dim result As DialogResult
        result = MessageBox.Show(Me, message, caption, buttons, icons)
        Dim Administrator As String = "Administrator"
        Dim Logout As String = "Logged Out"
        Dim dateofloghistory As String = Date.Now.ToString("dd MMM yyyy hh:mm:ss")
        Dim Username As String = Login.Username.Text

        If result = DialogResult.No Then
            Me.Refresh()
        Else
            Dim insertquery As String = "insert into LogHistory_tbl(logName,logType,logOperation,logDate) VALUES('" & Username & "', '" & Administrator & "', '" & Logout & "', '" & dateofloghistory & "')"
            Dim cmd As New SqlCommand(insertquery, connection)
            connection.Open()
            cmd.ExecuteNonQuery()
            Login.Username.Clear()
            Login.Password.Clear()
            Login.Show()
            Login.Refresh()
            Login.Username.Focus()
            If Login.showpassword.Checked = True Then
                Login.showpassword.Checked = False
            End If
            Me.Dispose()
            connection.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With ReportCategory
            .TopLevel = False
            MDIpanel.Controls.Add(ReportCategory)
            .BringToFront()
            .Show()
        End With




        'With IEFReportForm
        '.TopLevel = False
        ' MDIpanel.Controls.Add(IEFReportForm)
        '  .BringToFront()
        '  .Show()
        '  Category.Close()
        '  CompanyManagementForm.Close()
        '  FastfoodCanteenAndRestoForm.Close()
        '  HospitalAndEstablishmentForm.Close()
        '  IndustrialEstablishmentNonFoodForm.Close()
        '  UserManagementForm.Close()
        '   End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With CertificationMainForm
            .TopLevel = False
            MDIpanel.Controls.Add(CertificationMainForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Datenow.Text = Date.Now.ToString("MMM dd, yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Datenow2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With LogHistoryForm
            .TopLevel = False
            MDIpanel.Controls.Add(LogHistoryForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each form As Form In Me.MDIpanel.Controls
            form.Close()
        Next
        With Backup
            .TopLevel = False
            MDIpanel.Controls.Add(Backup)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
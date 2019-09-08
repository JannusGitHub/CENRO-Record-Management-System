Imports System.Data.SqlClient

Public Class BackupDatabaseForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-KFTOEG8;Initial Catalog=cenro_DB;Integrated Security=True")


    Private Sub BackupDatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbservername.Items.Add(My.Computer.Name.ToString & "\SQLServer")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmbservername.SelectedItem = "" Then
            MessageBox.Show("Select server name", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SaveFileDialog1.FileName = DateAndTime.DateString + " - cenro_DB"
            SaveFileDialog1.Filter = "SQL Server database backup files|*.sql"
            SaveFileDialog1.ShowDialog()
            Dim command As New SqlCommand("BACKUP DATABASE cenro_DB TO disk='" & SaveFileDialog1.FileName & "'", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
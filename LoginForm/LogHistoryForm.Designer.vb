<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogHistoryForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogHistoryForm))
        Me.LogHistory_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogHistoryDataSet = New LoginForm.LogHistoryDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LogHistory_tblTableAdapter = New LoginForm.LogHistoryDataSetTableAdapters.LogHistory_tblTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.LogHistory_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogHistoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogHistory_tblBindingSource
        '
        Me.LogHistory_tblBindingSource.DataMember = "LogHistory_tbl"
        Me.LogHistory_tblBindingSource.DataSource = Me.LogHistoryDataSet
        '
        'LogHistoryDataSet
        '
        Me.LogHistoryDataSet.DataSetName = "LogHistoryDataSet"
        Me.LogHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "LogHistoryDataSet"
        ReportDataSource1.Value = Me.LogHistory_tblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LoginForm.LogHistoryReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 37)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(850, 693)
        Me.ReportViewer1.TabIndex = 0
        '
        'LogHistory_tblTableAdapter
        '
        Me.LogHistory_tblTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(850, 35)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(820, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'LogHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 730)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogHistoryForm"
        Me.Text = "LogHistoryForm"
        CType(Me.LogHistory_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogHistoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LogHistory_tblBindingSource As BindingSource
    Friend WithEvents LogHistoryDataSet As LogHistoryDataSet
    Friend WithEvents LogHistory_tblTableAdapter As LogHistoryDataSetTableAdapters.LogHistory_tblTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IEFReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IEFReportForm))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.IndustrialEstablishmentFood_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IEFDataSet = New LoginForm.IEFDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.TextBox()
        Me.button = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.IndustrialEstablishmentFood_tblTableAdapter = New LoginForm.IEFDataSetTableAdapters.IndustrialEstablishmentFood_tblTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.IndustrialEstablishmentFood_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IEFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IndustrialEstablishmentFood_tblBindingSource
        '
        Me.IndustrialEstablishmentFood_tblBindingSource.DataMember = "IndustrialEstablishmentFood_tbl"
        Me.IndustrialEstablishmentFood_tblBindingSource.DataSource = Me.IEFDataSet
        '
        'IEFDataSet
        '
        Me.IEFDataSet.DataSetName = "IEFDataSet"
        Me.IEFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SearchButton)
        Me.GroupBox1.Controls.Add(Me.button)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 53)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Search"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(6, 19)
        Me.SearchButton.Multiline = True
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(249, 25)
        Me.SearchButton.TabIndex = 12
        '
        'button
        '
        Me.button.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button.ForeColor = System.Drawing.Color.White
        Me.button.Location = New System.Drawing.Point(261, 16)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(77, 30)
        Me.button.TabIndex = 11
        Me.button.Text = "Search"
        Me.button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1100, 35)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1069, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'IndustrialEstablishmentFood_tblTableAdapter
        '
        Me.IndustrialEstablishmentFood_tblTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "IEFDataSet"
        ReportDataSource1.Value = Me.IndustrialEstablishmentFood_tblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LoginForm.IEFReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 100)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1100, 630)
        Me.ReportViewer1.TabIndex = 10
        '
        'IEFReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 730)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IEFReportForm"
        Me.Text = "IEFReportForm"
        CType(Me.IndustrialEstablishmentFood_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IEFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchButton As TextBox
    Friend WithEvents button As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IndustrialEstablishmentFood_tblBindingSource As BindingSource
    Friend WithEvents IEFDataSet As IEFDataSet
    Friend WithEvents IndustrialEstablishmentFood_tblTableAdapter As IEFDataSetTableAdapters.IndustrialEstablishmentFood_tblTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class

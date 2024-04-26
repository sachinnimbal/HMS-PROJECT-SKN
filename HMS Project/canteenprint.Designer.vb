<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class canteenprint
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(canteenprint))
        Me.CanteenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CanteenTableAdapter = New HMS_Project.HmsDataSetTableAdapters.CanteenTableAdapter()
        CType(Me.CanteenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CanteenBindingSource
        '
        Me.CanteenBindingSource.DataMember = "Canteen"
        Me.CanteenBindingSource.DataSource = Me.HmsDataSet
        '
        'HmsDataSet
        '
        Me.HmsDataSet.DataSetName = "HmsDataSet"
        Me.HmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CanteenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "HMS_Project.print.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(534, 311)
        Me.ReportViewer1.TabIndex = 1
        '
        'CanteenTableAdapter
        '
        Me.CanteenTableAdapter.ClearBeforeFill = True
        '
        'canteenprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 311)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "canteenprint"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canteen Print"
        CType(Me.CanteenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CanteenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents CanteenTableAdapter As HMS_Project.HmsDataSetTableAdapters.CanteenTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class canteen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(canteen))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MorningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AfternoonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EveningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanteenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.btnPrint = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CanteenTableAdapter = New HMS_Project.HmsDataSetTableAdapters.CanteenTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanteenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1325, 433)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Canteen"
        '
        'btnEdit
        '
        Me.btnEdit.AnimationHoverSpeed = 0.07!
        Me.btnEdit.AnimationSpeed = 0.03!
        Me.btnEdit.BaseColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderColor = System.Drawing.Color.Black
        Me.btnEdit.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnEdit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnEdit.CheckedForeColor = System.Drawing.Color.White
        Me.btnEdit.CheckedImage = CType(resources.GetObject("btnEdit.CheckedImage"), System.Drawing.Image)
        Me.btnEdit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEdit.Image = Global.HMS_Project.My.Resources.Resources.editor
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEdit.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnEdit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(1263, 99)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.SlateBlue
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.btnEdit.Size = New System.Drawing.Size(56, 40)
        Me.btnEdit.TabIndex = 365
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.btnEdit, "Edit Canteen Details")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(16, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(1241, 379)
        Me.Panel1.TabIndex = 75
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DaysDataGridViewTextBoxColumn, Me.MorningDataGridViewTextBoxColumn, Me.AfternoonDataGridViewTextBoxColumn, Me.EveningDataGridViewTextBoxColumn, Me.NightDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.DataSource = Me.CanteenBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView1.Location = New System.Drawing.Point(10, 10)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1217, 352)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 1
        '
        'DaysDataGridViewTextBoxColumn
        '
        Me.DaysDataGridViewTextBoxColumn.DataPropertyName = "Days"
        Me.DaysDataGridViewTextBoxColumn.HeaderText = "DAYS"
        Me.DaysDataGridViewTextBoxColumn.Name = "DaysDataGridViewTextBoxColumn"
        Me.DaysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MorningDataGridViewTextBoxColumn
        '
        Me.MorningDataGridViewTextBoxColumn.DataPropertyName = "Morning"
        Me.MorningDataGridViewTextBoxColumn.HeaderText = "MORNING (BREAK-FAST) 8:30-9:30"
        Me.MorningDataGridViewTextBoxColumn.Name = "MorningDataGridViewTextBoxColumn"
        Me.MorningDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AfternoonDataGridViewTextBoxColumn
        '
        Me.AfternoonDataGridViewTextBoxColumn.DataPropertyName = "Afternoon"
        Me.AfternoonDataGridViewTextBoxColumn.HeaderText = "AFTERNOON (LUNCH) 1:00-2:00"
        Me.AfternoonDataGridViewTextBoxColumn.Name = "AfternoonDataGridViewTextBoxColumn"
        Me.AfternoonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EveningDataGridViewTextBoxColumn
        '
        Me.EveningDataGridViewTextBoxColumn.DataPropertyName = "Evening"
        Me.EveningDataGridViewTextBoxColumn.HeaderText = "EVENING (SNACKS) 4:30-5:30"
        Me.EveningDataGridViewTextBoxColumn.Name = "EveningDataGridViewTextBoxColumn"
        Me.EveningDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NightDataGridViewTextBoxColumn
        '
        Me.NightDataGridViewTextBoxColumn.DataPropertyName = "Night"
        Me.NightDataGridViewTextBoxColumn.HeaderText = "NIGHT (DINNER) 9:00-10:00"
        Me.NightDataGridViewTextBoxColumn.Name = "NightDataGridViewTextBoxColumn"
        Me.NightDataGridViewTextBoxColumn.ReadOnly = True
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
        'btnPrint
        '
        Me.btnPrint.AnimationHoverSpeed = 0.07!
        Me.btnPrint.AnimationSpeed = 0.03!
        Me.btnPrint.BaseColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderColor = System.Drawing.Color.Black
        Me.btnPrint.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnPrint.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnPrint.CheckedForeColor = System.Drawing.Color.White
        Me.btnPrint.CheckedImage = CType(resources.GetObject("btnPrint.CheckedImage"), System.Drawing.Image)
        Me.btnPrint.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = Global.HMS_Project.My.Resources.Resources.print
        Me.btnPrint.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnPrint.LineColor = System.Drawing.Color.Transparent
        Me.btnPrint.Location = New System.Drawing.Point(1263, 33)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrint.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnPrint.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrint.Size = New System.Drawing.Size(56, 42)
        Me.btnPrint.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print Canteen Details")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1378, 5)
        Me.Panel2.TabIndex = 360
        '
        'CanteenTableAdapter
        '
        Me.CanteenTableAdapter.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
        '
        'canteen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1378, 560)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "canteen"
        Me.Text = "canteen"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanteenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents CanteenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CanteenTableAdapter As HMS_Project.HmsDataSetTableAdapters.CanteenTableAdapter
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MorningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AfternoonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EveningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

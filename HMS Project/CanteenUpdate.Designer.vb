<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CanteenUpdate
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
        Dim DaysLabel As System.Windows.Forms.Label
        Dim MorningLabel As System.Windows.Forms.Label
        Dim AfternoonLabel As System.Windows.Forms.Label
        Dim EveningLabel As System.Windows.Forms.Label
        Dim NightLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CanteenUpdate))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.NightTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.EveningTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.AfternoonTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.MorningTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Days = New Guna.UI.WinForms.GunaComboBox()
        Me.CanteenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.CanteenTableAdapter = New HMS_Project.HmsDataSetTableAdapters.CanteenTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        DaysLabel = New System.Windows.Forms.Label()
        MorningLabel = New System.Windows.Forms.Label()
        AfternoonLabel = New System.Windows.Forms.Label()
        EveningLabel = New System.Windows.Forms.Label()
        NightLabel = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.CanteenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DaysLabel
        '
        DaysLabel.AutoSize = True
        DaysLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DaysLabel.Location = New System.Drawing.Point(72, 81)
        DaysLabel.Name = "DaysLabel"
        DaysLabel.Size = New System.Drawing.Size(50, 19)
        DaysLabel.TabIndex = 392
        DaysLabel.Text = "Days:"
        '
        'MorningLabel
        '
        MorningLabel.AutoSize = True
        MorningLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MorningLabel.Location = New System.Drawing.Point(72, 114)
        MorningLabel.Name = "MorningLabel"
        MorningLabel.Size = New System.Drawing.Size(77, 19)
        MorningLabel.TabIndex = 394
        MorningLabel.Text = "Morning:"
        '
        'AfternoonLabel
        '
        AfternoonLabel.AutoSize = True
        AfternoonLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AfternoonLabel.Location = New System.Drawing.Point(72, 147)
        AfternoonLabel.Name = "AfternoonLabel"
        AfternoonLabel.Size = New System.Drawing.Size(88, 19)
        AfternoonLabel.TabIndex = 396
        AfternoonLabel.Text = "Afternoon:"
        '
        'EveningLabel
        '
        EveningLabel.AutoSize = True
        EveningLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EveningLabel.Location = New System.Drawing.Point(72, 180)
        EveningLabel.Name = "EveningLabel"
        EveningLabel.Size = New System.Drawing.Size(75, 19)
        EveningLabel.TabIndex = 398
        EveningLabel.Text = "Evening:"
        '
        'NightLabel
        '
        NightLabel.AutoSize = True
        NightLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NightLabel.Location = New System.Drawing.Point(72, 213)
        NightLabel.Name = "NightLabel"
        NightLabel.Size = New System.Drawing.Size(54, 19)
        NightLabel.TabIndex = 400
        NightLabel.Text = "Night:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.NightTextBox)
        Me.Panel4.Controls.Add(Me.EveningTextBox)
        Me.Panel4.Controls.Add(Me.AfternoonTextBox)
        Me.Panel4.Controls.Add(Me.MorningTextBox)
        Me.Panel4.Controls.Add(DaysLabel)
        Me.Panel4.Controls.Add(MorningLabel)
        Me.Panel4.Controls.Add(AfternoonLabel)
        Me.Panel4.Controls.Add(EveningLabel)
        Me.Panel4.Controls.Add(NightLabel)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Days)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(398, 316)
        Me.Panel4.TabIndex = 394
        '
        'NightTextBox
        '
        Me.NightTextBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.NightTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NightTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NightTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NightTextBox.LineColor = System.Drawing.Color.DeepSkyBlue
        Me.NightTextBox.LineSize = 1
        Me.NightTextBox.Location = New System.Drawing.Point(180, 216)
        Me.NightTextBox.MaxLength = 15
        Me.NightTextBox.Name = "NightTextBox"
        Me.NightTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NightTextBox.SelectedText = ""
        Me.NightTextBox.Size = New System.Drawing.Size(144, 30)
        Me.NightTextBox.TabIndex = 406
        '
        'EveningTextBox
        '
        Me.EveningTextBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.EveningTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EveningTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EveningTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EveningTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EveningTextBox.LineColor = System.Drawing.Color.DeepSkyBlue
        Me.EveningTextBox.LineSize = 1
        Me.EveningTextBox.Location = New System.Drawing.Point(180, 180)
        Me.EveningTextBox.MaxLength = 15
        Me.EveningTextBox.Name = "EveningTextBox"
        Me.EveningTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EveningTextBox.SelectedText = ""
        Me.EveningTextBox.Size = New System.Drawing.Size(144, 30)
        Me.EveningTextBox.TabIndex = 405
        '
        'AfternoonTextBox
        '
        Me.AfternoonTextBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.AfternoonTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AfternoonTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AfternoonTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AfternoonTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfternoonTextBox.LineColor = System.Drawing.Color.DeepSkyBlue
        Me.AfternoonTextBox.LineSize = 1
        Me.AfternoonTextBox.Location = New System.Drawing.Point(180, 144)
        Me.AfternoonTextBox.MaxLength = 15
        Me.AfternoonTextBox.Name = "AfternoonTextBox"
        Me.AfternoonTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AfternoonTextBox.SelectedText = ""
        Me.AfternoonTextBox.Size = New System.Drawing.Size(144, 30)
        Me.AfternoonTextBox.TabIndex = 404
        '
        'MorningTextBox
        '
        Me.MorningTextBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.MorningTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MorningTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MorningTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MorningTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MorningTextBox.LineColor = System.Drawing.Color.DeepSkyBlue
        Me.MorningTextBox.LineSize = 1
        Me.MorningTextBox.Location = New System.Drawing.Point(180, 108)
        Me.MorningTextBox.MaxLength = 15
        Me.MorningTextBox.Name = "MorningTextBox"
        Me.MorningTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MorningTextBox.SelectedText = ""
        Me.MorningTextBox.Size = New System.Drawing.Size(144, 30)
        Me.MorningTextBox.TabIndex = 403
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(398, 60)
        Me.Panel2.TabIndex = 392
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(398, 5)
        Me.Panel3.TabIndex = 368
        '
        'btnSearch
        '
        Me.btnSearch.AnimationHoverSpeed = 0.07!
        Me.btnSearch.AnimationSpeed = 0.03!
        Me.btnSearch.BaseColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSearch.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSearch.CheckedForeColor = System.Drawing.Color.White
        Me.btnSearch.CheckedImage = CType(resources.GetObject("btnSearch.CheckedImage"), System.Drawing.Image)
        Me.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnSearch.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnSearch.Image = Global.HMS_Project.My.Resources.Resources.search
        Me.btnSearch.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnSearch.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(212, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.OnHoverBorderColor = System.Drawing.Color.SlateBlue
        Me.btnSearch.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnSearch.OnHoverImage = Nothing
        Me.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSearch.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.btnSearch.Size = New System.Drawing.Size(112, 42)
        Me.btnSearch.TabIndex = 367
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search Canteen Details")
        '
        'btnUpdate
        '
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BaseColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdate.CheckedImage = CType(resources.GetObject("btnUpdate.CheckedImage"), System.Drawing.Image)
        Me.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnUpdate.Image = Global.HMS_Project.My.Resources.Resources.Save
        Me.btnUpdate.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnUpdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(94, 7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.SlateBlue
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.Size = New System.Drawing.Size(112, 42)
        Me.btnUpdate.TabIndex = 366
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Update Canteen Details")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.HMS_Project.My.Resources.Resources.status
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(398, 57)
        Me.Panel5.TabIndex = 391
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(398, 5)
        Me.Panel6.TabIndex = 367
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Centaur", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(70, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Update Canteen Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Days
        '
        Me.Days.BackColor = System.Drawing.Color.Transparent
        Me.Days.BaseColor = System.Drawing.Color.White
        Me.Days.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Days.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CanteenBindingSource, "Days", True))
        Me.Days.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CanteenBindingSource, "Days", True))
        Me.Days.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Days.FocusedColor = System.Drawing.Color.Empty
        Me.Days.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Days.ForeColor = System.Drawing.Color.Black
        Me.Days.FormattingEnabled = True
        Me.Days.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.Days.Location = New System.Drawing.Point(180, 73)
        Me.Days.Name = "Days"
        Me.Days.OnHoverItemBaseColor = System.Drawing.Color.Fuchsia
        Me.Days.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Days.Size = New System.Drawing.Size(144, 28)
        Me.Days.TabIndex = 407
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
        'CanteenUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(398, 316)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CanteenUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canteen Update"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.CanteenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NightTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents EveningTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents AfternoonTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents MorningTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Days As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents CanteenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CanteenTableAdapter As HMS_Project.HmsDataSetTableAdapters.CanteenTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

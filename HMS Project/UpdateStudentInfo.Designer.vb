<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStudentInfo
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
        Dim Permanant_AddressLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateStudentInfo))
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentInfoTableAdapter = New HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter()
        Me.TableAdapterManager = New HMS_Project.HmsDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.browse = New Guna.UI.WinForms.GunaCircleButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.MobileNo = New Guna.UI.WinForms.GunaLineTextBox()
        Me.LastName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.FirstName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.DOB = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PhoneNo = New Guna.UI.WinForms.GunaLineTextBox()
        Me.FullName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.StudentID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PictureTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Permanant_AddressLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Permanant_AddressLabel
        '
        Permanant_AddressLabel.AutoSize = True
        Permanant_AddressLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Permanant_AddressLabel.Location = New System.Drawing.Point(40, 325)
        Permanant_AddressLabel.Name = "Permanant_AddressLabel"
        Permanant_AddressLabel.Size = New System.Drawing.Size(74, 19)
        Permanant_AddressLabel.TabIndex = 380
        Permanant_AddressLabel.Text = "Address:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(37, 253)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(94, 19)
        Last_NameLabel.TabIndex = 379
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(37, 217)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(93, 19)
        First_NameLabel.TabIndex = 378
        First_NameLabel.Text = "First Name:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(37, 289)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(92, 19)
        Mobile_NoLabel.TabIndex = 377
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(40, 74)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(89, 19)
        Student_IDLabel.TabIndex = 372
        Student_IDLabel.Text = "Student ID:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(37, 181)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(46, 19)
        DOBLabel.TabIndex = 371
        DOBLabel.Text = "DOB:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NoLabel.Location = New System.Drawing.Point(37, 145)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(88, 19)
        Phone_NoLabel.TabIndex = 370
        Phone_NoLabel.Text = "Phone No:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(37, 109)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(92, 19)
        Full_NameLabel.TabIndex = 369
        Full_NameLabel.Text = "Full Name:"
        '
        'HmsDataSet
        '
        Me.HmsDataSet.DataSetName = "HmsDataSet"
        Me.HmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource.DataSource = Me.HmsDataSet
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CanteenTableAdapter = Nothing
        Me.TableAdapterManager.StudentInfoTableAdapter = Me.StudentInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = HMS_Project.HmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 5)
        Me.Panel1.TabIndex = 366
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.HMS_Project.My.Resources.Resources.status
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(492, 57)
        Me.Panel3.TabIndex = 391
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Centaur", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(139, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Update Records"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.browse)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Address)
        Me.Panel4.Controls.Add(Me.Picture)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.MobileNo)
        Me.Panel4.Controls.Add(Me.LastName)
        Me.Panel4.Controls.Add(Me.FirstName)
        Me.Panel4.Controls.Add(Permanant_AddressLabel)
        Me.Panel4.Controls.Add(Last_NameLabel)
        Me.Panel4.Controls.Add(First_NameLabel)
        Me.Panel4.Controls.Add(Mobile_NoLabel)
        Me.Panel4.Controls.Add(Me.DOB)
        Me.Panel4.Controls.Add(Me.PhoneNo)
        Me.Panel4.Controls.Add(Me.FullName)
        Me.Panel4.Controls.Add(Me.StudentID)
        Me.Panel4.Controls.Add(Student_IDLabel)
        Me.Panel4.Controls.Add(DOBLabel)
        Me.Panel4.Controls.Add(Phone_NoLabel)
        Me.Panel4.Controls.Add(Full_NameLabel)
        Me.Panel4.Controls.Add(Me.PictureTextBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(492, 445)
        Me.Panel4.TabIndex = 392
        '
        'browse
        '
        Me.browse.AnimationHoverSpeed = 0.07!
        Me.browse.AnimationSpeed = 0.03!
        Me.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.browse.BaseColor = System.Drawing.Color.Transparent
        Me.browse.BorderColor = System.Drawing.Color.SteelBlue
        Me.browse.BorderSize = 1
        Me.browse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.browse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.browse.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.browse.Image = Nothing
        Me.browse.ImageSize = New System.Drawing.Size(52, 52)
        Me.browse.Location = New System.Drawing.Point(309, 271)
        Me.browse.Name = "browse"
        Me.browse.OnHoverBaseColor = System.Drawing.Color.DarkSlateBlue
        Me.browse.OnHoverBorderColor = System.Drawing.Color.IndianRed
        Me.browse.OnHoverForeColor = System.Drawing.SystemColors.HighlightText
        Me.browse.OnHoverImage = Nothing
        Me.browse.OnPressedColor = System.Drawing.Color.MistyRose
        Me.browse.Size = New System.Drawing.Size(119, 29)
        Me.browse.TabIndex = 398
        Me.browse.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.browse, "Browse Picture")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Location = New System.Drawing.Point(145, 376)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(335, 1)
        Me.Panel5.TabIndex = 397
        '
        'Address
        '
        Me.Address.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Address.Font = New System.Drawing.Font("Century", 12.0!)
        Me.Address.Location = New System.Drawing.Point(145, 314)
        Me.Address.MaxLength = 120
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Address.Size = New System.Drawing.Size(335, 61)
        Me.Address.TabIndex = 394
        '
        'Picture
        '
        Me.Picture.BackgroundImage = Global.HMS_Project.My.Resources.Resources.User
        Me.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StudentInfoBindingSource, "Picture", True))
        Me.Picture.Location = New System.Drawing.Point(308, 145)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(120, 120)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 387
        Me.Picture.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 385)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 60)
        Me.Panel2.TabIndex = 392
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 55)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(492, 5)
        Me.Panel6.TabIndex = 368
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
        Me.btnSearch.Location = New System.Drawing.Point(250, 8)
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
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search Student Details")
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
        Me.btnUpdate.Location = New System.Drawing.Point(132, 8)
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
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Update Student Details")
        '
        'MobileNo
        '
        Me.MobileNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MobileNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MobileNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Mobile_No", True))
        Me.MobileNo.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MobileNo.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNo.LineColor = System.Drawing.Color.RoyalBlue
        Me.MobileNo.LineSize = 1
        Me.MobileNo.Location = New System.Drawing.Point(145, 278)
        Me.MobileNo.MaxLength = 10
        Me.MobileNo.Name = "MobileNo"
        Me.MobileNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MobileNo.SelectedText = ""
        Me.MobileNo.Size = New System.Drawing.Size(144, 30)
        Me.MobileNo.TabIndex = 384
        '
        'LastName
        '
        Me.LastName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Last_Name", True))
        Me.LastName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.LineColor = System.Drawing.Color.RoyalBlue
        Me.LastName.LineSize = 1
        Me.LastName.Location = New System.Drawing.Point(145, 242)
        Me.LastName.MaxLength = 20
        Me.LastName.Name = "LastName"
        Me.LastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastName.SelectedText = ""
        Me.LastName.Size = New System.Drawing.Size(144, 30)
        Me.LastName.TabIndex = 383
        '
        'FirstName
        '
        Me.FirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "First_Name", True))
        Me.FirstName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.LineColor = System.Drawing.Color.RoyalBlue
        Me.FirstName.LineSize = 1
        Me.FirstName.Location = New System.Drawing.Point(145, 206)
        Me.FirstName.MaxLength = 20
        Me.FirstName.Name = "FirstName"
        Me.FirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstName.SelectedText = ""
        Me.FirstName.Size = New System.Drawing.Size(144, 30)
        Me.FirstName.TabIndex = 382
        '
        'DOB
        '
        Me.DOB.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DOB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "DOB", True))
        Me.DOB.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DOB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.LineColor = System.Drawing.Color.RoyalBlue
        Me.DOB.LineSize = 1
        Me.DOB.Location = New System.Drawing.Point(145, 170)
        Me.DOB.MaxLength = 10
        Me.DOB.Name = "DOB"
        Me.DOB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DOB.SelectedText = ""
        Me.DOB.Size = New System.Drawing.Size(144, 30)
        Me.DOB.TabIndex = 376
        '
        'PhoneNo
        '
        Me.PhoneNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Phone_No", True))
        Me.PhoneNo.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneNo.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNo.LineColor = System.Drawing.Color.RoyalBlue
        Me.PhoneNo.LineSize = 1
        Me.PhoneNo.Location = New System.Drawing.Point(145, 134)
        Me.PhoneNo.MaxLength = 10
        Me.PhoneNo.Name = "PhoneNo"
        Me.PhoneNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneNo.SelectedText = ""
        Me.PhoneNo.Size = New System.Drawing.Size(144, 30)
        Me.PhoneNo.TabIndex = 375
        '
        'FullName
        '
        Me.FullName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FullName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Full_Name", True))
        Me.FullName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FullName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.LineColor = System.Drawing.Color.RoyalBlue
        Me.FullName.LineSize = 1
        Me.FullName.Location = New System.Drawing.Point(145, 98)
        Me.FullName.MaxLength = 25
        Me.FullName.Name = "FullName"
        Me.FullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullName.SelectedText = ""
        Me.FullName.Size = New System.Drawing.Size(283, 30)
        Me.FullName.TabIndex = 374
        '
        'StudentID
        '
        Me.StudentID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentID.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentID.LineColor = System.Drawing.Color.RoyalBlue
        Me.StudentID.LineSize = 1
        Me.StudentID.Location = New System.Drawing.Point(145, 63)
        Me.StudentID.MaxLength = 5
        Me.StudentID.Name = "StudentID"
        Me.StudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentID.SelectedText = ""
        Me.StudentID.Size = New System.Drawing.Size(144, 30)
        Me.StudentID.TabIndex = 373
        '
        'PictureTextBox
        '
        Me.PictureTextBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PictureTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "YOA", True))
        Me.PictureTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureTextBox.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureTextBox.ForeColor = System.Drawing.Color.Transparent
        Me.PictureTextBox.LineColor = System.Drawing.Color.Transparent
        Me.PictureTextBox.LineSize = 1
        Me.PictureTextBox.Location = New System.Drawing.Point(329, 191)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PictureTextBox.ReadOnly = True
        Me.PictureTextBox.SelectedText = ""
        Me.PictureTextBox.Size = New System.Drawing.Size(81, 30)
        Me.PictureTextBox.TabIndex = 390
        Me.PictureTextBox.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
        '
        'UpdateStudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(492, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateStudentInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Records"
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInfoTableAdapter As HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents TableAdapterManager As HMS_Project.HmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents MobileNo As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents LastName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents FirstName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents DOB As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PhoneNo As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents FullName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents StudentID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PictureTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents browse As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

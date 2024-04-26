<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Permanant_AddressLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.RoomNo = New Guna.UI.WinForms.GunaLineTextBox()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.MobileNo = New Guna.UI.WinForms.GunaLineTextBox()
        Me.LastName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.FirstName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.YOA = New Guna.UI.WinForms.GunaLineTextBox()
        Me.DOB = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PhoneNo = New Guna.UI.WinForms.GunaLineTextBox()
        Me.FullName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.StudentID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.StudentInfoTableAdapter = New HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter()
        Me.TableAdapterManager = New HMS_Project.HmsDataSetTableAdapters.TableAdapterManager()
        Me.search = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnPrint = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Label1 = New System.Windows.Forms.Label()
        Permanant_AddressLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(34, 217)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 19)
        Label1.TabIndex = 386
        Label1.Text = "YOA:"
        '
        'Permanant_AddressLabel
        '
        Permanant_AddressLabel.AutoSize = True
        Permanant_AddressLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Permanant_AddressLabel.Location = New System.Drawing.Point(34, 360)
        Permanant_AddressLabel.Name = "Permanant_AddressLabel"
        Permanant_AddressLabel.Size = New System.Drawing.Size(74, 19)
        Permanant_AddressLabel.TabIndex = 380
        Permanant_AddressLabel.Text = "Address:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(36, 288)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(94, 19)
        Last_NameLabel.TabIndex = 379
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(37, 252)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(93, 19)
        First_NameLabel.TabIndex = 378
        First_NameLabel.Text = "First Name:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(34, 324)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(92, 19)
        Mobile_NoLabel.TabIndex = 377
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(34, 74)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(89, 19)
        Student_IDLabel.TabIndex = 372
        Student_IDLabel.Text = "Student ID:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(34, 181)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(46, 19)
        DOBLabel.TabIndex = 371
        DOBLabel.Text = "DOB:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NoLabel.Location = New System.Drawing.Point(34, 145)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(88, 19)
        Phone_NoLabel.TabIndex = 370
        Phone_NoLabel.Text = "Phone No:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(34, 109)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(92, 19)
        Full_NameLabel.TabIndex = 369
        Full_NameLabel.Text = "Full Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(267, 74)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(84, 19)
        Label3.TabIndex = 392
        Label3.Text = "Room No:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Address)
        Me.Panel1.Controls.Add(Me.RoomNo)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.Picture)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureTextBox)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.MobileNo)
        Me.Panel1.Controls.Add(Me.LastName)
        Me.Panel1.Controls.Add(Me.FirstName)
        Me.Panel1.Controls.Add(Me.YOA)
        Me.Panel1.Controls.Add(Permanant_AddressLabel)
        Me.Panel1.Controls.Add(Last_NameLabel)
        Me.Panel1.Controls.Add(First_NameLabel)
        Me.Panel1.Controls.Add(Mobile_NoLabel)
        Me.Panel1.Controls.Add(Me.DOB)
        Me.Panel1.Controls.Add(Me.PhoneNo)
        Me.Panel1.Controls.Add(Me.FullName)
        Me.Panel1.Controls.Add(Me.StudentID)
        Me.Panel1.Controls.Add(Student_IDLabel)
        Me.Panel1.Controls.Add(DOBLabel)
        Me.Panel1.Controls.Add(Phone_NoLabel)
        Me.Panel1.Controls.Add(Full_NameLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 500)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Location = New System.Drawing.Point(145, 422)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(311, 1)
        Me.Panel5.TabIndex = 396
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Location = New System.Drawing.Point(145, 422)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(311, 1)
        Me.Panel4.TabIndex = 396
        '
        'Address
        '
        Me.Address.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Address.Font = New System.Drawing.Font("Century", 12.0!)
        Me.Address.Location = New System.Drawing.Point(145, 349)
        Me.Address.MaxLength = 120
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Address.Size = New System.Drawing.Size(311, 74)
        Me.Address.TabIndex = 395
        '
        'RoomNo
        '
        Me.RoomNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RoomNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RoomNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Room_No", True))
        Me.RoomNo.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoomNo.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNo.LineColor = System.Drawing.Color.RoyalBlue
        Me.RoomNo.LineSize = 1
        Me.RoomNo.Location = New System.Drawing.Point(357, 63)
        Me.RoomNo.Name = "RoomNo"
        Me.RoomNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RoomNo.SelectedText = ""
        Me.RoomNo.Size = New System.Drawing.Size(71, 30)
        Me.RoomNo.TabIndex = 393
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource.DataSource = Me.HmsDataSet
        '
        'HmsDataSet
        '
        Me.HmsDataSet.DataSetName = "HmsDataSet"
        Me.HmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Picture
        '
        Me.Picture.BackgroundImage = Global.HMS_Project.My.Resources.Resources.User
        Me.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StudentInfoBindingSource, "Picture", True))
        Me.Picture.Location = New System.Drawing.Point(350, 161)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(120, 120)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 387
        Me.Picture.TabStop = False
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
        Me.Panel3.Size = New System.Drawing.Size(494, 57)
        Me.Panel3.TabIndex = 391
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Centaur", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(139, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student Profile"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PictureTextBox.Location = New System.Drawing.Point(385, 191)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PictureTextBox.ReadOnly = True
        Me.PictureTextBox.SelectedText = ""
        Me.PictureTextBox.Size = New System.Drawing.Size(59, 30)
        Me.PictureTextBox.TabIndex = 390
        Me.PictureTextBox.Visible = False
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
        Me.MobileNo.Location = New System.Drawing.Point(145, 313)
        Me.MobileNo.Name = "MobileNo"
        Me.MobileNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MobileNo.ReadOnly = True
        Me.MobileNo.SelectedText = ""
        Me.MobileNo.Size = New System.Drawing.Size(188, 30)
        Me.MobileNo.TabIndex = 384
        '
        'LastName
        '
        Me.LastName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Last_Name", True))
        Me.LastName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.LineColor = System.Drawing.Color.RoyalBlue
        Me.LastName.LineSize = 1
        Me.LastName.Location = New System.Drawing.Point(145, 277)
        Me.LastName.Name = "LastName"
        Me.LastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastName.ReadOnly = True
        Me.LastName.SelectedText = ""
        Me.LastName.Size = New System.Drawing.Size(188, 30)
        Me.LastName.TabIndex = 383
        '
        'FirstName
        '
        Me.FirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "First_Name", True))
        Me.FirstName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.LineColor = System.Drawing.Color.RoyalBlue
        Me.FirstName.LineSize = 1
        Me.FirstName.Location = New System.Drawing.Point(145, 241)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstName.ReadOnly = True
        Me.FirstName.SelectedText = ""
        Me.FirstName.Size = New System.Drawing.Size(188, 30)
        Me.FirstName.TabIndex = 382
        '
        'YOA
        '
        Me.YOA.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.YOA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.YOA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "YOA", True))
        Me.YOA.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.YOA.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YOA.LineColor = System.Drawing.Color.RoyalBlue
        Me.YOA.LineSize = 1
        Me.YOA.Location = New System.Drawing.Point(145, 206)
        Me.YOA.Name = "YOA"
        Me.YOA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YOA.ReadOnly = True
        Me.YOA.SelectedText = ""
        Me.YOA.Size = New System.Drawing.Size(188, 30)
        Me.YOA.TabIndex = 381
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
        Me.DOB.Name = "DOB"
        Me.DOB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DOB.ReadOnly = True
        Me.DOB.SelectedText = ""
        Me.DOB.Size = New System.Drawing.Size(188, 30)
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
        Me.PhoneNo.Name = "PhoneNo"
        Me.PhoneNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneNo.ReadOnly = True
        Me.PhoneNo.SelectedText = ""
        Me.PhoneNo.Size = New System.Drawing.Size(188, 30)
        Me.PhoneNo.TabIndex = 375
        '
        'FullName
        '
        Me.FullName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FullName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Full_Name", True))
        Me.FullName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FullName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.LineColor = System.Drawing.Color.RoyalBlue
        Me.FullName.LineSize = 1
        Me.FullName.Location = New System.Drawing.Point(145, 98)
        Me.FullName.Name = "FullName"
        Me.FullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullName.ReadOnly = True
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
        Me.StudentID.Name = "StudentID"
        Me.StudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentID.SelectedText = ""
        Me.StudentID.Size = New System.Drawing.Size(105, 30)
        Me.StudentID.TabIndex = 373
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
        'search
        '
        Me.search.AnimationHoverSpeed = 0.07!
        Me.search.AnimationSpeed = 0.03!
        Me.search.BackColor = System.Drawing.Color.Transparent
        Me.search.BaseColor = System.Drawing.Color.Transparent
        Me.search.BorderColor = System.Drawing.Color.Black
        Me.search.CheckedBaseColor = System.Drawing.Color.Gray
        Me.search.CheckedBorderColor = System.Drawing.Color.Black
        Me.search.CheckedForeColor = System.Drawing.Color.White
        Me.search.CheckedImage = CType(resources.GetObject("search.CheckedImage"), System.Drawing.Image)
        Me.search.CheckedLineColor = System.Drawing.Color.DimGray
        Me.search.DialogResult = System.Windows.Forms.DialogResult.None
        Me.search.FocusedColor = System.Drawing.Color.Empty
        Me.search.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.DarkViolet
        Me.search.Image = Global.HMS_Project.My.Resources.Resources.search
        Me.search.ImageSize = New System.Drawing.Size(45, 45)
        Me.search.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.search.Location = New System.Drawing.Point(255, 17)
        Me.search.Name = "search"
        Me.search.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search.OnHoverBorderColor = System.Drawing.Color.RoyalBlue
        Me.search.OnHoverForeColor = System.Drawing.Color.White
        Me.search.OnHoverImage = Nothing
        Me.search.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.search.OnPressedColor = System.Drawing.Color.Aqua
        Me.search.Size = New System.Drawing.Size(112, 42)
        Me.search.TabIndex = 389
        Me.search.Text = "Search"
        Me.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.search, "Search Details")
        '
        'btnPrint
        '
        Me.btnPrint.AnimationHoverSpeed = 0.07!
        Me.btnPrint.AnimationSpeed = 0.03!
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BaseColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderColor = System.Drawing.Color.Black
        Me.btnPrint.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnPrint.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPrint.CheckedForeColor = System.Drawing.Color.White
        Me.btnPrint.CheckedImage = CType(resources.GetObject("btnPrint.CheckedImage"), System.Drawing.Image)
        Me.btnPrint.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrint.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.DarkViolet
        Me.btnPrint.Image = Global.HMS_Project.My.Resources.Resources.print
        Me.btnPrint.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnPrint.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(137, 17)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.OnHoverBorderColor = System.Drawing.Color.RoyalBlue
        Me.btnPrint.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrint.OnPressedColor = System.Drawing.Color.Aqua
        Me.btnPrint.Size = New System.Drawing.Size(112, 42)
        Me.btnPrint.TabIndex = 388
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print Details")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 429)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 71)
        Me.Panel2.TabIndex = 390
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.HMS_Project.My.Resources.Resources.light
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(494, 500)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInfoTableAdapter As HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents TableAdapterManager As HMS_Project.HmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents MobileNo As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents LastName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents FirstName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents YOA As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents DOB As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PhoneNo As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents FullName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents StudentID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents search As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RoomNo As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

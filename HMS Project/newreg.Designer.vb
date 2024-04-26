<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newreg
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
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim Room_NoLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim YOALabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim Annual_IncomeLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Permanant_AddressLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newreg))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Room_NoComboBox = New System.Windows.Forms.ComboBox()
        Me.Female_btn = New System.Windows.Forms.RadioButton()
        Me.Male_btn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.ACardNo = New System.Windows.Forms.TextBox()
        Me.Annual_IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Permanant_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.YOADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.browse = New Guna.UI.WinForms.GunaCircleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnClear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentInfoTableAdapter = New HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter()
        Me.TableAdapterManager = New HMS_Project.HmsDataSetTableAdapters.TableAdapterManager()
        Student_IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Room_NoLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        YOALabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        Annual_IncomeLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Permanant_AddressLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(30, 74)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(104, 18)
        Student_IDLabel.TabIndex = 28
        Student_IDLabel.Text = "Student ID:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(529, 74)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(100, 18)
        Full_NameLabel.TabIndex = 30
        Full_NameLabel.Text = "Full Name:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NoLabel.Location = New System.Drawing.Point(30, 101)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(93, 18)
        Phone_NoLabel.TabIndex = 32
        Phone_NoLabel.Text = "Phone No:"
        '
        'Room_NoLabel
        '
        Room_NoLabel.AutoSize = True
        Room_NoLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Room_NoLabel.Location = New System.Drawing.Point(529, 109)
        Room_NoLabel.Name = "Room_NoLabel"
        Room_NoLabel.Size = New System.Drawing.Size(89, 18)
        Room_NoLabel.TabIndex = 34
        Room_NoLabel.Text = "Room No:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(30, 133)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(75, 18)
        GenderLabel.TabIndex = 36
        GenderLabel.Text = "Gender:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(529, 146)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(50, 18)
        DOBLabel.TabIndex = 38
        DOBLabel.Text = "DOB:"
        '
        'YOALabel
        '
        YOALabel.AutoSize = True
        YOALabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YOALabel.Location = New System.Drawing.Point(529, 177)
        YOALabel.Name = "YOALabel"
        YOALabel.Size = New System.Drawing.Size(51, 18)
        YOALabel.TabIndex = 40
        YOALabel.Text = "YOA:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PictureLabel.Location = New System.Drawing.Point(30, 166)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(75, 18)
        PictureLabel.TabIndex = 42
        PictureLabel.Text = "Picture:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(24, 45)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(106, 18)
        First_NameLabel.TabIndex = 28
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(518, 50)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(102, 18)
        Last_NameLabel.TabIndex = 30
        Last_NameLabel.Text = "Last Name:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OccupationLabel.Location = New System.Drawing.Point(24, 77)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(111, 18)
        OccupationLabel.TabIndex = 32
        OccupationLabel.Text = "Occupation:"
        '
        'Annual_IncomeLabel
        '
        Annual_IncomeLabel.AutoSize = True
        Annual_IncomeLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Annual_IncomeLabel.Location = New System.Drawing.Point(518, 82)
        Annual_IncomeLabel.Name = "Annual_IncomeLabel"
        Annual_IncomeLabel.Size = New System.Drawing.Size(142, 18)
        Annual_IncomeLabel.TabIndex = 34
        Annual_IncomeLabel.Text = "Annual Income:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(24, 109)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(93, 18)
        Mobile_NoLabel.TabIndex = 36
        Mobile_NoLabel.Text = "Phone No:"
        '
        'Permanant_AddressLabel
        '
        Permanant_AddressLabel.AutoSize = True
        Permanant_AddressLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Permanant_AddressLabel.Location = New System.Drawing.Point(24, 141)
        Permanant_AddressLabel.Name = "Permanant_AddressLabel"
        Permanant_AddressLabel.Size = New System.Drawing.Size(178, 18)
        Permanant_AddressLabel.TabIndex = 38
        Permanant_AddressLabel.Text = "Permanant Address:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(518, 114)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(147, 18)
        Label1.TabIndex = 34
        Label1.Text = "Aadhar Number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Room_NoComboBox)
        Me.GroupBox1.Controls.Add(Me.Female_btn)
        Me.GroupBox1.Controls.Add(Me.Male_btn)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Student_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Student_IDTextBox)
        Me.GroupBox1.Controls.Add(Full_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Full_NameTextBox)
        Me.GroupBox1.Controls.Add(Phone_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Phone_NoTextBox)
        Me.GroupBox1.Controls.Add(Room_NoLabel)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(Me.GenderTextBox)
        Me.GroupBox1.Controls.Add(DOBLabel)
        Me.GroupBox1.Controls.Add(Me.DOBDateTimePicker)
        Me.GroupBox1.Controls.Add(YOALabel)
        Me.GroupBox1.Controls.Add(Me.YOADateTimePicker)
        Me.GroupBox1.Controls.Add(PictureLabel)
        Me.GroupBox1.Controls.Add(Me.PictureTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1077, 461)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Registration"
        '
        'Room_NoComboBox
        '
        Me.Room_NoComboBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_NoComboBox.FormattingEnabled = True
        Me.Room_NoComboBox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.Room_NoComboBox.Location = New System.Drawing.Point(772, 106)
        Me.Room_NoComboBox.Name = "Room_NoComboBox"
        Me.Room_NoComboBox.Size = New System.Drawing.Size(104, 26)
        Me.Room_NoComboBox.TabIndex = 47
        '
        'Female_btn
        '
        Me.Female_btn.AutoSize = True
        Me.Female_btn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female_btn.Location = New System.Drawing.Point(427, 131)
        Me.Female_btn.Name = "Female_btn"
        Me.Female_btn.Size = New System.Drawing.Size(78, 22)
        Me.Female_btn.TabIndex = 46
        Me.Female_btn.TabStop = True
        Me.Female_btn.Text = "Female"
        Me.Female_btn.UseVisualStyleBackColor = True
        '
        'Male_btn
        '
        Me.Male_btn.AutoSize = True
        Me.Male_btn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male_btn.Location = New System.Drawing.Point(360, 131)
        Me.Male_btn.Name = "Male_btn"
        Me.Male_btn.Size = New System.Drawing.Size(61, 22)
        Me.Male_btn.TabIndex = 45
        Me.Male_btn.TabStop = True
        Me.Male_btn.Text = "Male"
        Me.Male_btn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(First_NameLabel)
        Me.GroupBox2.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox2.Controls.Add(Last_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox2.Controls.Add(OccupationLabel)
        Me.GroupBox2.Controls.Add(Me.OccupationTextBox)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Annual_IncomeLabel)
        Me.GroupBox2.Controls.Add(Me.ACardNo)
        Me.GroupBox2.Controls.Add(Me.Annual_IncomeTextBox)
        Me.GroupBox2.Controls.Add(Mobile_NoLabel)
        Me.GroupBox2.Controls.Add(Me.Mobile_NoTextBox)
        Me.GroupBox2.Controls.Add(Permanant_AddressLabel)
        Me.GroupBox2.Controls.Add(Me.Permanant_AddressTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1045, 217)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parents/Guardian Details"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.First_NameTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(267, 42)
        Me.First_NameTextBox.MaxLength = 15
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(235, 26)
        Me.First_NameTextBox.TabIndex = 29
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(761, 47)
        Me.Last_NameTextBox.MaxLength = 15
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(235, 26)
        Me.Last_NameTextBox.TabIndex = 31
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OccupationTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OccupationTextBox.Location = New System.Drawing.Point(267, 74)
        Me.OccupationTextBox.MaxLength = 20
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(235, 26)
        Me.OccupationTextBox.TabIndex = 33
        '
        'ACardNo
        '
        Me.ACardNo.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACardNo.Location = New System.Drawing.Point(761, 111)
        Me.ACardNo.MaxLength = 12
        Me.ACardNo.Name = "ACardNo"
        Me.ACardNo.Size = New System.Drawing.Size(235, 26)
        Me.ACardNo.TabIndex = 35
        '
        'Annual_IncomeTextBox
        '
        Me.Annual_IncomeTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Annual_IncomeTextBox.Location = New System.Drawing.Point(761, 79)
        Me.Annual_IncomeTextBox.MaxLength = 6
        Me.Annual_IncomeTextBox.Name = "Annual_IncomeTextBox"
        Me.Annual_IncomeTextBox.Size = New System.Drawing.Size(235, 26)
        Me.Annual_IncomeTextBox.TabIndex = 35
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(267, 106)
        Me.Mobile_NoTextBox.MaxLength = 10
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(235, 26)
        Me.Mobile_NoTextBox.TabIndex = 37
        '
        'Permanant_AddressTextBox
        '
        Me.Permanant_AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Permanant_AddressTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Permanant_AddressTextBox.Location = New System.Drawing.Point(267, 138)
        Me.Permanant_AddressTextBox.MaxLength = 120
        Me.Permanant_AddressTextBox.Multiline = True
        Me.Permanant_AddressTextBox.Name = "Permanant_AddressTextBox"
        Me.Permanant_AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Permanant_AddressTextBox.Size = New System.Drawing.Size(416, 61)
        Me.Permanant_AddressTextBox.TabIndex = 39
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Student_IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(273, 66)
        Me.Student_IDTextBox.MaxLength = 8
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(235, 26)
        Me.Student_IDTextBox.TabIndex = 29
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(772, 71)
        Me.Full_NameTextBox.MaxLength = 30
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(235, 26)
        Me.Full_NameTextBox.TabIndex = 31
        '
        'Phone_NoTextBox
        '
        Me.Phone_NoTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NoTextBox.Location = New System.Drawing.Point(273, 98)
        Me.Phone_NoTextBox.MaxLength = 10
        Me.Phone_NoTextBox.Name = "Phone_NoTextBox"
        Me.Phone_NoTextBox.Size = New System.Drawing.Size(235, 26)
        Me.Phone_NoTextBox.TabIndex = 33
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.Color.Snow
        Me.GenderTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GenderTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(273, 130)
        Me.GenderTextBox.MaxLength = 6
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(81, 26)
        Me.GenderTextBox.TabIndex = 37
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(772, 140)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(145, 26)
        Me.DOBDateTimePicker.TabIndex = 39
        Me.DOBDateTimePicker.Value = New Date(2022, 6, 18, 0, 0, 0, 0)
        '
        'YOADateTimePicker
        '
        Me.YOADateTimePicker.Checked = False
        Me.YOADateTimePicker.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YOADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.YOADateTimePicker.Location = New System.Drawing.Point(772, 171)
        Me.YOADateTimePicker.Name = "YOADateTimePicker"
        Me.YOADateTimePicker.Size = New System.Drawing.Size(145, 26)
        Me.YOADateTimePicker.TabIndex = 41
        '
        'PictureTextBox
        '
        Me.PictureTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureTextBox.Location = New System.Drawing.Point(273, 163)
        Me.PictureTextBox.MaxLength = 6524
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.Size = New System.Drawing.Size(235, 26)
        Me.PictureTextBox.TabIndex = 43
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.browse)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(1134, 57)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(208, 282)
        Me.GroupBox5.TabIndex = 358
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "STUDENT PHOTO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.HMS_Project.My.Resources.Resources.User
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(14, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.browse.Location = New System.Drawing.Point(47, 233)
        Me.browse.Name = "browse"
        Me.browse.OnHoverBaseColor = System.Drawing.Color.DarkSlateBlue
        Me.browse.OnHoverBorderColor = System.Drawing.Color.IndianRed
        Me.browse.OnHoverForeColor = System.Drawing.SystemColors.HighlightText
        Me.browse.OnHoverImage = Nothing
        Me.browse.OnPressedColor = System.Drawing.Color.MistyRose
        Me.browse.Size = New System.Drawing.Size(119, 29)
        Me.browse.TabIndex = 365
        Me.browse.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.browse, "Browse Picture")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1378, 5)
        Me.Panel1.TabIndex = 359
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HmsDataSet
        '
        Me.HmsDataSet.DataSetName = "HmsDataSet"
        Me.HmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BaseColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedImage = CType(resources.GetObject("btnSave.CheckedImage"), System.Drawing.Image)
        Me.btnSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.Image = Global.HMS_Project.My.Resources.Resources.clipart1155738
        Me.btnSave.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(1192, 401)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.Fuchsia
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.MediumBlue
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.btnSave.Size = New System.Drawing.Size(108, 45)
        Me.btnSave.TabIndex = 363
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save Details")
        '
        'btnClear
        '
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BaseColor = System.Drawing.Color.Transparent
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnClear.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnClear.CheckedForeColor = System.Drawing.Color.White
        Me.btnClear.CheckedImage = CType(resources.GetObject("btnClear.CheckedImage"), System.Drawing.Image)
        Me.btnClear.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.Image = Global.HMS_Project.My.Resources.Resources.clear
        Me.btnClear.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnClear.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(1192, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.Fuchsia
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.MediumBlue
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClear.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.btnClear.Size = New System.Drawing.Size(108, 45)
        Me.btnClear.TabIndex = 364
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear all")
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
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
        'newreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1378, 710)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newreg"
        Me.Text = "newreg"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Student_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OccupationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Annual_IncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mobile_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Permanant_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Female_btn As System.Windows.Forms.RadioButton
    Friend WithEvents Male_btn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents Room_NoComboBox As System.Windows.Forms.ComboBox
    Private WithEvents YOADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents browse As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ACardNo As System.Windows.Forms.TextBox
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInfoTableAdapter As HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents TableAdapterManager As HMS_Project.HmsDataSetTableAdapters.TableAdapterManager
End Class

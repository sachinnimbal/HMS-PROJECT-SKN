<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchrecords
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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim Annual_IncomeLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Permanant_AddressLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim Room_NoLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim YOALabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchrecords))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.YOA = New System.Windows.Forms.TextBox()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.DOB = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.Annual_IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Permanant_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Room_NoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureTextBox = New System.Windows.Forms.TextBox()
        Me.StudentInfoTableAdapter = New HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.search = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Stud_IdSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnProfile = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnClear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnEdit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        Annual_IncomeLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Permanant_AddressLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Room_NoLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        YOALabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(24, 45)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(93, 19)
        First_NameLabel.TabIndex = 28
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(518, 50)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(94, 19)
        Last_NameLabel.TabIndex = 30
        Last_NameLabel.Text = "Last Name:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OccupationLabel.Location = New System.Drawing.Point(24, 77)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(106, 19)
        OccupationLabel.TabIndex = 32
        OccupationLabel.Text = "Occupation:"
        '
        'Annual_IncomeLabel
        '
        Annual_IncomeLabel.AutoSize = True
        Annual_IncomeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Annual_IncomeLabel.Location = New System.Drawing.Point(518, 82)
        Annual_IncomeLabel.Name = "Annual_IncomeLabel"
        Annual_IncomeLabel.Size = New System.Drawing.Size(134, 19)
        Annual_IncomeLabel.TabIndex = 34
        Annual_IncomeLabel.Text = "Annual Income:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(24, 109)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(92, 19)
        Mobile_NoLabel.TabIndex = 36
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Permanant_AddressLabel
        '
        Permanant_AddressLabel.AutoSize = True
        Permanant_AddressLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Permanant_AddressLabel.Location = New System.Drawing.Point(24, 141)
        Permanant_AddressLabel.Name = "Permanant_AddressLabel"
        Permanant_AddressLabel.Size = New System.Drawing.Size(164, 19)
        Permanant_AddressLabel.TabIndex = 38
        Permanant_AddressLabel.Text = "Permanant Address:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(30, 74)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(89, 19)
        Student_IDLabel.TabIndex = 28
        Student_IDLabel.Text = "Student ID:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(529, 74)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(92, 19)
        Full_NameLabel.TabIndex = 30
        Full_NameLabel.Text = "Full Name:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NoLabel.Location = New System.Drawing.Point(30, 101)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(88, 19)
        Phone_NoLabel.TabIndex = 32
        Phone_NoLabel.Text = "Phone No:"
        '
        'Room_NoLabel
        '
        Room_NoLabel.AutoSize = True
        Room_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Room_NoLabel.Location = New System.Drawing.Point(529, 106)
        Room_NoLabel.Name = "Room_NoLabel"
        Room_NoLabel.Size = New System.Drawing.Size(84, 19)
        Room_NoLabel.TabIndex = 34
        Room_NoLabel.Text = "Room No:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(30, 133)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(72, 19)
        GenderLabel.TabIndex = 36
        GenderLabel.Text = "Gender:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(529, 139)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(46, 19)
        DOBLabel.TabIndex = 38
        DOBLabel.Text = "DOB:"
        '
        'YOALabel
        '
        YOALabel.AutoSize = True
        YOALabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YOALabel.Location = New System.Drawing.Point(531, 171)
        YOALabel.Name = "YOALabel"
        YOALabel.Size = New System.Drawing.Size(48, 19)
        YOALabel.TabIndex = 40
        YOALabel.Text = "YOA:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PictureLabel.Location = New System.Drawing.Point(30, 166)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(65, 19)
        PictureLabel.TabIndex = 42
        PictureLabel.Text = "Picture:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.YOA)
        Me.GroupBox1.Controls.Add(Me.DOB)
        Me.GroupBox1.Controls.Add(Me.Gender)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Student_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Student_IDTextBox)
        Me.GroupBox1.Controls.Add(Full_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Full_NameTextBox)
        Me.GroupBox1.Controls.Add(Phone_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Phone_NoTextBox)
        Me.GroupBox1.Controls.Add(Room_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Room_NoTextBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(DOBLabel)
        Me.GroupBox1.Controls.Add(YOALabel)
        Me.GroupBox1.Controls.Add(PictureLabel)
        Me.GroupBox1.Controls.Add(Me.PictureTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(51, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1077, 452)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Records"
        '
        'YOA
        '
        Me.YOA.BackColor = System.Drawing.Color.White
        Me.YOA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "YOA", True))
        Me.YOA.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YOA.Location = New System.Drawing.Point(772, 167)
        Me.YOA.Name = "YOA"
        Me.YOA.ReadOnly = True
        Me.YOA.Size = New System.Drawing.Size(235, 27)
        Me.YOA.TabIndex = 47
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
        'DOB
        '
        Me.DOB.BackColor = System.Drawing.Color.White
        Me.DOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "DOB", True))
        Me.DOB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(772, 135)
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        Me.DOB.Size = New System.Drawing.Size(235, 27)
        Me.DOB.TabIndex = 46
        '
        'Gender
        '
        Me.Gender.BackColor = System.Drawing.Color.White
        Me.Gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Gender", True))
        Me.Gender.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.Location = New System.Drawing.Point(273, 130)
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        Me.Gender.Size = New System.Drawing.Size(235, 27)
        Me.Gender.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(First_NameLabel)
        Me.GroupBox2.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox2.Controls.Add(Last_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox2.Controls.Add(OccupationLabel)
        Me.GroupBox2.Controls.Add(Me.OccupationTextBox)
        Me.GroupBox2.Controls.Add(Annual_IncomeLabel)
        Me.GroupBox2.Controls.Add(Me.Annual_IncomeTextBox)
        Me.GroupBox2.Controls.Add(Mobile_NoLabel)
        Me.GroupBox2.Controls.Add(Me.Mobile_NoTextBox)
        Me.GroupBox2.Controls.Add(Permanant_AddressLabel)
        Me.GroupBox2.Controls.Add(Me.Permanant_AddressTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1045, 204)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parents/Guardian Details"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.BackColor = System.Drawing.Color.White
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(267, 42)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.ReadOnly = True
        Me.First_NameTextBox.Size = New System.Drawing.Size(235, 27)
        Me.First_NameTextBox.TabIndex = 29
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(761, 47)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.ReadOnly = True
        Me.Last_NameTextBox.Size = New System.Drawing.Size(235, 27)
        Me.Last_NameTextBox.TabIndex = 31
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.BackColor = System.Drawing.Color.White
        Me.OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Occupation", True))
        Me.OccupationTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OccupationTextBox.Location = New System.Drawing.Point(267, 74)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.ReadOnly = True
        Me.OccupationTextBox.Size = New System.Drawing.Size(235, 27)
        Me.OccupationTextBox.TabIndex = 33
        '
        'Annual_IncomeTextBox
        '
        Me.Annual_IncomeTextBox.BackColor = System.Drawing.Color.White
        Me.Annual_IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Annual_Income", True))
        Me.Annual_IncomeTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Annual_IncomeTextBox.Location = New System.Drawing.Point(761, 79)
        Me.Annual_IncomeTextBox.Name = "Annual_IncomeTextBox"
        Me.Annual_IncomeTextBox.ReadOnly = True
        Me.Annual_IncomeTextBox.Size = New System.Drawing.Size(235, 27)
        Me.Annual_IncomeTextBox.TabIndex = 35
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.BackColor = System.Drawing.Color.White
        Me.Mobile_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Mobile_No", True))
        Me.Mobile_NoTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(267, 106)
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.ReadOnly = True
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(235, 27)
        Me.Mobile_NoTextBox.TabIndex = 37
        '
        'Permanant_AddressTextBox
        '
        Me.Permanant_AddressTextBox.BackColor = System.Drawing.Color.White
        Me.Permanant_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Permanant_Address", True))
        Me.Permanant_AddressTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Permanant_AddressTextBox.Location = New System.Drawing.Point(267, 138)
        Me.Permanant_AddressTextBox.Multiline = True
        Me.Permanant_AddressTextBox.Name = "Permanant_AddressTextBox"
        Me.Permanant_AddressTextBox.ReadOnly = True
        Me.Permanant_AddressTextBox.Size = New System.Drawing.Size(416, 56)
        Me.Permanant_AddressTextBox.TabIndex = 39
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.BackColor = System.Drawing.Color.White
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Student_ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(273, 66)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.ReadOnly = True
        Me.Student_IDTextBox.Size = New System.Drawing.Size(235, 27)
        Me.Student_IDTextBox.TabIndex = 29
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Full_Name", True))
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(772, 71)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.ReadOnly = True
        Me.Full_NameTextBox.Size = New System.Drawing.Size(235, 27)
        Me.Full_NameTextBox.TabIndex = 31
        '
        'Phone_NoTextBox
        '
        Me.Phone_NoTextBox.BackColor = System.Drawing.Color.White
        Me.Phone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Phone_No", True))
        Me.Phone_NoTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NoTextBox.Location = New System.Drawing.Point(273, 98)
        Me.Phone_NoTextBox.Name = "Phone_NoTextBox"
        Me.Phone_NoTextBox.ReadOnly = True
        Me.Phone_NoTextBox.Size = New System.Drawing.Size(235, 27)
        Me.Phone_NoTextBox.TabIndex = 33
        '
        'Room_NoTextBox
        '
        Me.Room_NoTextBox.BackColor = System.Drawing.Color.White
        Me.Room_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Room_No", True))
        Me.Room_NoTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_NoTextBox.Location = New System.Drawing.Point(772, 103)
        Me.Room_NoTextBox.Name = "Room_NoTextBox"
        Me.Room_NoTextBox.ReadOnly = True
        Me.Room_NoTextBox.Size = New System.Drawing.Size(235, 27)
        Me.Room_NoTextBox.TabIndex = 35
        '
        'PictureTextBox
        '
        Me.PictureTextBox.BackColor = System.Drawing.Color.White
        Me.PictureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Picture", True))
        Me.PictureTextBox.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureTextBox.Location = New System.Drawing.Point(273, 163)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.ReadOnly = True
        Me.PictureTextBox.Size = New System.Drawing.Size(235, 27)
        Me.PictureTextBox.TabIndex = 43
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(1134, 105)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(208, 244)
        Me.GroupBox5.TabIndex = 359
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.search)
        Me.GroupBox3.Controls.Add(Me.Stud_IdSearch)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(452, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(369, 87)
        Me.GroupBox3.TabIndex = 360
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'search
        '
        Me.search.AnimationHoverSpeed = 0.07!
        Me.search.AnimationSpeed = 0.03!
        Me.search.BaseColor = System.Drawing.Color.Transparent
        Me.search.BorderColor = System.Drawing.Color.Black
        Me.search.CheckedBaseColor = System.Drawing.Color.Gray
        Me.search.CheckedBorderColor = System.Drawing.Color.Black
        Me.search.CheckedForeColor = System.Drawing.Color.White
        Me.search.CheckedImage = CType(resources.GetObject("search.CheckedImage"), System.Drawing.Image)
        Me.search.CheckedLineColor = System.Drawing.Color.DimGray
        Me.search.DialogResult = System.Windows.Forms.DialogResult.None
        Me.search.FocusedColor = System.Drawing.Color.Empty
        Me.search.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.SystemColors.Highlight
        Me.search.Image = Global.HMS_Project.My.Resources.Resources.search
        Me.search.ImageSize = New System.Drawing.Size(45, 45)
        Me.search.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.search.Location = New System.Drawing.Point(253, 36)
        Me.search.Name = "search"
        Me.search.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search.OnHoverBorderColor = System.Drawing.Color.SlateBlue
        Me.search.OnHoverForeColor = System.Drawing.Color.White
        Me.search.OnHoverImage = Nothing
        Me.search.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.search.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.search.Size = New System.Drawing.Size(112, 42)
        Me.search.TabIndex = 366
        Me.search.Text = "Search"
        Me.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.search, "Search Records")
        '
        'Stud_IdSearch
        '
        Me.Stud_IdSearch.BackColor = System.Drawing.Color.White
        Me.Stud_IdSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Stud_IdSearch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Student_ID", True))
        Me.Stud_IdSearch.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stud_IdSearch.Location = New System.Drawing.Point(12, 52)
        Me.Stud_IdSearch.MaxLength = 4
        Me.Stud_IdSearch.Name = "Stud_IdSearch"
        Me.Stud_IdSearch.Size = New System.Drawing.Size(235, 26)
        Me.Stud_IdSearch.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1378, 5)
        Me.Panel1.TabIndex = 361
        '
        'BtnProfile
        '
        Me.BtnProfile.AnimationHoverSpeed = 0.07!
        Me.BtnProfile.AnimationSpeed = 0.03!
        Me.BtnProfile.BaseColor = System.Drawing.Color.Transparent
        Me.BtnProfile.BorderColor = System.Drawing.Color.Black
        Me.BtnProfile.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BtnProfile.CheckedBorderColor = System.Drawing.Color.Black
        Me.BtnProfile.CheckedForeColor = System.Drawing.Color.White
        Me.BtnProfile.CheckedImage = CType(resources.GetObject("BtnProfile.CheckedImage"), System.Drawing.Image)
        Me.BtnProfile.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BtnProfile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnProfile.FocusedColor = System.Drawing.Color.Empty
        Me.BtnProfile.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BtnProfile.Image = Global.HMS_Project.My.Resources.Resources.User
        Me.BtnProfile.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnProfile.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnProfile.Location = New System.Drawing.Point(1174, 476)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnProfile.OnHoverBorderColor = System.Drawing.Color.SlateBlue
        Me.BtnProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnProfile.OnHoverImage = Nothing
        Me.BtnProfile.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnProfile.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.BtnProfile.Size = New System.Drawing.Size(118, 45)
        Me.BtnProfile.TabIndex = 366
        Me.BtnProfile.Text = "Profile"
        Me.BtnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BtnProfile, "Print Profile")
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
        Me.btnClear.Location = New System.Drawing.Point(1174, 415)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.SlateBlue
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClear.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.btnClear.Size = New System.Drawing.Size(118, 45)
        Me.btnClear.TabIndex = 365
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear all")
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
        Me.btnEdit.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnEdit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(1174, 355)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.SlateBlue
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Gainsboro
        Me.btnEdit.Size = New System.Drawing.Size(118, 45)
        Me.btnEdit.TabIndex = 364
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btnEdit, "Edit Details")
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
        '
        'searchrecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 730)
        Me.Controls.Add(Me.BtnProfile)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "searchrecords"
        Me.Text = "searchrecords"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OccupationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Annual_IncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mobile_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Permanant_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gender As System.Windows.Forms.TextBox
    Friend WithEvents YOA As System.Windows.Forms.TextBox
    Friend WithEvents DOB As System.Windows.Forms.TextBox
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInfoTableAdapter As HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Stud_IdSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents search As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BtnProfile As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

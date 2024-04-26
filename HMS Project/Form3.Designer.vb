<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaLineTextBox6 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox7 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox8 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox9 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox10 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.YOA2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.DOB2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PhoneNo2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.FullName2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.StudentID2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.RoomNo = New Guna.UI.WinForms.GunaComboBox()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HmsDataSet = New HMS_Project.HmsDataSet()
        Me.YOA = New Guna.UI.WinForms.GunaLineTextBox()
        Me.DOB = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PhoneNo = New Guna.UI.WinForms.GunaLineTextBox()
        Me.FullName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.StudentID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentInfoTableAdapter = New HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(21, 90)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(84, 19)
        Label3.TabIndex = 405
        Label3.Text = "Room No:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(21, 270)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 19)
        Label1.TabIndex = 404
        Label1.Text = "YOA:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(17, 127)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(89, 19)
        Student_IDLabel.TabIndex = 396
        Student_IDLabel.Text = "Student ID:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(23, 234)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(46, 19)
        DOBLabel.TabIndex = 395
        DOBLabel.Text = "DOB:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NoLabel.Location = New System.Drawing.Point(17, 198)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(88, 19)
        Phone_NoLabel.TabIndex = 394
        Phone_NoLabel.Text = "Phone No:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(17, 162)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(92, 19)
        Full_NameLabel.TabIndex = 393
        Full_NameLabel.Text = "Full Name:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(368, 269)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(48, 19)
        Label4.TabIndex = 417
        Label4.Text = "YOA:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(364, 126)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(89, 19)
        Label5.TabIndex = 411
        Label5.Text = "Student ID:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(370, 233)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(46, 19)
        Label6.TabIndex = 410
        Label6.Text = "DOB:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(364, 197)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(88, 19)
        Label7.TabIndex = 409
        Label7.Text = "Phone No:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(364, 161)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(92, 19)
        Label8.TabIndex = 408
        Label8.Text = "Full Name:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(708, 270)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(48, 19)
        Label9.TabIndex = 427
        Label9.Text = "YOA:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(704, 127)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(89, 19)
        Label10.TabIndex = 421
        Label10.Text = "Student ID:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(710, 234)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(46, 19)
        Label11.TabIndex = 420
        Label11.Text = "DOB:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(704, 198)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(88, 19)
        Label12.TabIndex = 419
        Label12.Text = "Phone No:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(704, 162)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(92, 19)
        Label13.TabIndex = 418
        Label13.Text = "Full Name:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Snow
        Me.Panel4.Controls.Add(Label9)
        Me.Panel4.Controls.Add(Me.GunaLineTextBox6)
        Me.Panel4.Controls.Add(Me.GunaLineTextBox7)
        Me.Panel4.Controls.Add(Me.GunaLineTextBox8)
        Me.Panel4.Controls.Add(Me.GunaLineTextBox9)
        Me.Panel4.Controls.Add(Me.GunaLineTextBox10)
        Me.Panel4.Controls.Add(Label10)
        Me.Panel4.Controls.Add(Label11)
        Me.Panel4.Controls.Add(Label12)
        Me.Panel4.Controls.Add(Label13)
        Me.Panel4.Controls.Add(Label4)
        Me.Panel4.Controls.Add(Me.YOA2)
        Me.Panel4.Controls.Add(Me.DOB2)
        Me.Panel4.Controls.Add(Me.PhoneNo2)
        Me.Panel4.Controls.Add(Me.FullName2)
        Me.Panel4.Controls.Add(Me.StudentID2)
        Me.Panel4.Controls.Add(Label5)
        Me.Panel4.Controls.Add(Label6)
        Me.Panel4.Controls.Add(Label7)
        Me.Panel4.Controls.Add(Label8)
        Me.Panel4.Controls.Add(Label3)
        Me.Panel4.Controls.Add(Label1)
        Me.Panel4.Controls.Add(Me.RoomNo)
        Me.Panel4.Controls.Add(Me.YOA)
        Me.Panel4.Controls.Add(Me.DOB)
        Me.Panel4.Controls.Add(Me.PhoneNo)
        Me.Panel4.Controls.Add(Me.FullName)
        Me.Panel4.Controls.Add(Me.StudentID)
        Me.Panel4.Controls.Add(Student_IDLabel)
        Me.Panel4.Controls.Add(DOBLabel)
        Me.Panel4.Controls.Add(Phone_NoLabel)
        Me.Panel4.Controls.Add(Full_NameLabel)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1059, 368)
        Me.Panel4.TabIndex = 395
        '
        'GunaLineTextBox6
        '
        Me.GunaLineTextBox6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GunaLineTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox6.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox6.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox6.LineColor = System.Drawing.Color.RoyalBlue
        Me.GunaLineTextBox6.LineSize = 1
        Me.GunaLineTextBox6.Location = New System.Drawing.Point(815, 259)
        Me.GunaLineTextBox6.Name = "GunaLineTextBox6"
        Me.GunaLineTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox6.ReadOnly = True
        Me.GunaLineTextBox6.SelectedText = ""
        Me.GunaLineTextBox6.Size = New System.Drawing.Size(144, 30)
        Me.GunaLineTextBox6.TabIndex = 426
        '
        'GunaLineTextBox7
        '
        Me.GunaLineTextBox7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GunaLineTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox7.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox7.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox7.LineColor = System.Drawing.Color.RoyalBlue
        Me.GunaLineTextBox7.LineSize = 1
        Me.GunaLineTextBox7.Location = New System.Drawing.Point(815, 223)
        Me.GunaLineTextBox7.Name = "GunaLineTextBox7"
        Me.GunaLineTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox7.ReadOnly = True
        Me.GunaLineTextBox7.SelectedText = ""
        Me.GunaLineTextBox7.Size = New System.Drawing.Size(144, 30)
        Me.GunaLineTextBox7.TabIndex = 425
        '
        'GunaLineTextBox8
        '
        Me.GunaLineTextBox8.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GunaLineTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox8.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox8.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox8.LineColor = System.Drawing.Color.RoyalBlue
        Me.GunaLineTextBox8.LineSize = 1
        Me.GunaLineTextBox8.Location = New System.Drawing.Point(815, 187)
        Me.GunaLineTextBox8.Name = "GunaLineTextBox8"
        Me.GunaLineTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox8.ReadOnly = True
        Me.GunaLineTextBox8.SelectedText = ""
        Me.GunaLineTextBox8.Size = New System.Drawing.Size(144, 30)
        Me.GunaLineTextBox8.TabIndex = 424
        '
        'GunaLineTextBox9
        '
        Me.GunaLineTextBox9.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GunaLineTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox9.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox9.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox9.LineColor = System.Drawing.Color.RoyalBlue
        Me.GunaLineTextBox9.LineSize = 1
        Me.GunaLineTextBox9.Location = New System.Drawing.Point(815, 151)
        Me.GunaLineTextBox9.Name = "GunaLineTextBox9"
        Me.GunaLineTextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox9.ReadOnly = True
        Me.GunaLineTextBox9.SelectedText = ""
        Me.GunaLineTextBox9.Size = New System.Drawing.Size(211, 30)
        Me.GunaLineTextBox9.TabIndex = 423
        '
        'GunaLineTextBox10
        '
        Me.GunaLineTextBox10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GunaLineTextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GunaLineTextBox10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox10.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox10.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox10.LineColor = System.Drawing.Color.RoyalBlue
        Me.GunaLineTextBox10.LineSize = 1
        Me.GunaLineTextBox10.Location = New System.Drawing.Point(815, 115)
        Me.GunaLineTextBox10.Name = "GunaLineTextBox10"
        Me.GunaLineTextBox10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox10.SelectedText = ""
        Me.GunaLineTextBox10.Size = New System.Drawing.Size(105, 30)
        Me.GunaLineTextBox10.TabIndex = 422
        '
        'YOA2
        '
        Me.YOA2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.YOA2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.YOA2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.YOA2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YOA2.LineColor = System.Drawing.Color.RoyalBlue
        Me.YOA2.LineSize = 1
        Me.YOA2.Location = New System.Drawing.Point(475, 258)
        Me.YOA2.Name = "YOA2"
        Me.YOA2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YOA2.ReadOnly = True
        Me.YOA2.SelectedText = ""
        Me.YOA2.Size = New System.Drawing.Size(144, 30)
        Me.YOA2.TabIndex = 416
        '
        'DOB2
        '
        Me.DOB2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DOB2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DOB2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DOB2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB2.LineColor = System.Drawing.Color.RoyalBlue
        Me.DOB2.LineSize = 1
        Me.DOB2.Location = New System.Drawing.Point(475, 222)
        Me.DOB2.Name = "DOB2"
        Me.DOB2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DOB2.ReadOnly = True
        Me.DOB2.SelectedText = ""
        Me.DOB2.Size = New System.Drawing.Size(144, 30)
        Me.DOB2.TabIndex = 415
        '
        'PhoneNo2
        '
        Me.PhoneNo2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PhoneNo2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneNo2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneNo2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNo2.LineColor = System.Drawing.Color.RoyalBlue
        Me.PhoneNo2.LineSize = 1
        Me.PhoneNo2.Location = New System.Drawing.Point(475, 186)
        Me.PhoneNo2.Name = "PhoneNo2"
        Me.PhoneNo2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneNo2.ReadOnly = True
        Me.PhoneNo2.SelectedText = ""
        Me.PhoneNo2.Size = New System.Drawing.Size(144, 30)
        Me.PhoneNo2.TabIndex = 414
        '
        'FullName2
        '
        Me.FullName2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.FullName2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FullName2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FullName2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName2.LineColor = System.Drawing.Color.RoyalBlue
        Me.FullName2.LineSize = 1
        Me.FullName2.Location = New System.Drawing.Point(475, 150)
        Me.FullName2.Name = "FullName2"
        Me.FullName2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullName2.ReadOnly = True
        Me.FullName2.SelectedText = ""
        Me.FullName2.Size = New System.Drawing.Size(211, 30)
        Me.FullName2.TabIndex = 413
        '
        'StudentID2
        '
        Me.StudentID2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.StudentID2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentID2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentID2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentID2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentID2.LineColor = System.Drawing.Color.RoyalBlue
        Me.StudentID2.LineSize = 1
        Me.StudentID2.Location = New System.Drawing.Point(475, 114)
        Me.StudentID2.Name = "StudentID2"
        Me.StudentID2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentID2.SelectedText = ""
        Me.StudentID2.Size = New System.Drawing.Size(105, 30)
        Me.StudentID2.TabIndex = 412
        '
        'RoomNo
        '
        Me.RoomNo.BackColor = System.Drawing.Color.Transparent
        Me.RoomNo.BaseColor = System.Drawing.Color.White
        Me.RoomNo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoomNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Room_No", True))
        Me.RoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoomNo.FocusedColor = System.Drawing.Color.Empty
        Me.RoomNo.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNo.ForeColor = System.Drawing.Color.Black
        Me.RoomNo.FormattingEnabled = True
        Me.RoomNo.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
        Me.RoomNo.Location = New System.Drawing.Point(128, 81)
        Me.RoomNo.Name = "RoomNo"
        Me.RoomNo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoomNo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.RoomNo.Size = New System.Drawing.Size(144, 28)
        Me.RoomNo.TabIndex = 407
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
        'YOA
        '
        Me.YOA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.YOA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.YOA.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.YOA.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YOA.LineColor = System.Drawing.Color.RoyalBlue
        Me.YOA.LineSize = 1
        Me.YOA.Location = New System.Drawing.Point(128, 259)
        Me.YOA.Name = "YOA"
        Me.YOA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YOA.ReadOnly = True
        Me.YOA.SelectedText = ""
        Me.YOA.Size = New System.Drawing.Size(144, 30)
        Me.YOA.TabIndex = 402
        '
        'DOB
        '
        Me.DOB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DOB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DOB.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DOB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.LineColor = System.Drawing.Color.RoyalBlue
        Me.DOB.LineSize = 1
        Me.DOB.Location = New System.Drawing.Point(128, 223)
        Me.DOB.Name = "DOB"
        Me.DOB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DOB.ReadOnly = True
        Me.DOB.SelectedText = ""
        Me.DOB.Size = New System.Drawing.Size(144, 30)
        Me.DOB.TabIndex = 400
        '
        'PhoneNo
        '
        Me.PhoneNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneNo.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneNo.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNo.LineColor = System.Drawing.Color.RoyalBlue
        Me.PhoneNo.LineSize = 1
        Me.PhoneNo.Location = New System.Drawing.Point(128, 187)
        Me.PhoneNo.Name = "PhoneNo"
        Me.PhoneNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneNo.ReadOnly = True
        Me.PhoneNo.SelectedText = ""
        Me.PhoneNo.Size = New System.Drawing.Size(144, 30)
        Me.PhoneNo.TabIndex = 399
        '
        'FullName
        '
        Me.FullName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.FullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FullName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FullName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.LineColor = System.Drawing.Color.RoyalBlue
        Me.FullName.LineSize = 1
        Me.FullName.Location = New System.Drawing.Point(128, 151)
        Me.FullName.Name = "FullName"
        Me.FullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullName.ReadOnly = True
        Me.FullName.SelectedText = ""
        Me.FullName.Size = New System.Drawing.Size(211, 30)
        Me.FullName.TabIndex = 398
        '
        'StudentID
        '
        Me.StudentID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.StudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentID.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentID.LineColor = System.Drawing.Color.RoyalBlue
        Me.StudentID.LineSize = 1
        Me.StudentID.Location = New System.Drawing.Point(128, 115)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentID.SelectedText = ""
        Me.StudentID.Size = New System.Drawing.Size(105, 30)
        Me.StudentID.TabIndex = 397
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 308)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1059, 60)
        Me.Panel2.TabIndex = 392
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1059, 5)
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
        Me.btnSearch.Location = New System.Drawing.Point(121, 6)
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
        Me.Panel5.Size = New System.Drawing.Size(1059, 57)
        Me.Panel5.TabIndex = 391
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1059, 5)
        Me.Panel6.TabIndex = 367
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Centaur", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(93, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Room Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 368)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RoomNo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents YOA As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents DOB As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PhoneNo As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents FullName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents StudentID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox6 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox7 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox8 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox9 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox10 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents YOA2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents DOB2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PhoneNo2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents FullName2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents StudentID2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents HmsDataSet As HMS_Project.HmsDataSet
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInfoTableAdapter As HMS_Project.HmsDataSetTableAdapters.StudentInfoTableAdapter
End Class

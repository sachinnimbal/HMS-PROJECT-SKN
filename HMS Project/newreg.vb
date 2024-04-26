Imports System.Data
Imports System.Data.OleDb

Public Class newreg



    Private Sub newreg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.StudentInfo' table. You can move, or remove it, as needed.

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "Select Student_ID from StudentInfo where Student_ID=(Select MAX(Student_ID) from StudentInfo)"
        Dim cmd As New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        Student_IDTextBox.Text = dr("Student_ID")
        con.Close()
        DOBDateTimePicker.Text = "01-01-2000"
        YOADateTimePicker.Text = Now
    End Sub

    Private Sub Female_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Female_btn.CheckedChanged
        If Female_btn.Checked Then
            GenderTextBox.Text = Female_btn.Text
        End If
    End Sub

    Private Sub Male_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Male_btn.CheckedChanged
        If Male_btn.Checked Then
            GenderTextBox.Text = Male_btn.Text
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save Data
        If Len(Trim(Student_IDTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Student ID", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        
        If Len(Trim(Full_NameTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Student Full Name", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Phone_NoTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Student Phone Number", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(GenderTextBox.Text)) = 0 Then
            MessageBox.Show("Select Student Gender", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Permanant_AddressTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Address", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(First_NameTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Parent/Guardian First Name", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Last_NameTextBox.Text)) = 0 Then
            MessageBox.Show("Enter  Parent/Guardian Last Name", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Mobile_NoTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Mobile number of  Parent/Guardian", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            Dim Exists As Boolean = False
            con.Open()
            Using cmd As OleDbCommand = New OleDbCommand("Select Count(*) FROM StudentInfo WHERE Student_ID = '" & Student_IDTextBox.Text & "'", con)
                Dim result As Integer = DirectCast(cmd.ExecuteScalar(), Integer)
                If result > 0 Then
                    Exists = True
                    MsgBox(Student_IDTextBox.Text + " already exists")
                    Student_IDTextBox.Text = ""
                    Student_IDTextBox.Focus()
                    Exit Sub
                End If
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Try
            Dim Exists As Boolean = False
            con.Open()
            Using cmd As OleDbCommand = New OleDbCommand("Select Count(*) FROM StudentInfo WHERE Room_No = '" & Room_NoComboBox.Text & "'", con)
                Dim result As Integer = DirectCast(cmd.ExecuteScalar(), Integer)
                If result = 4 Then
                    Exists = True
                    MsgBox(Room_NoComboBox.Text + " Per Room only 4 Persons")
                    Room_NoComboBox.Text = ""
                    Room_NoComboBox.Focus()
                    Exit Sub
                End If
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Try
            Dim Exists As Boolean = False
            con.Open()
            Using cmd As OleDbCommand = New OleDbCommand("Select Count(*) FROM StudentInfo WHERE Full_Name = '" & Full_NameTextBox.Text & "'", con)
                Dim result As Integer = DirectCast(cmd.ExecuteScalar(), Integer)
                If result > 0 Then
                    Exists = True
                    MsgBox(Full_NameTextBox.Text + " already exists")
                    Full_NameTextBox.Text = ""
                    Full_NameTextBox.Focus()
                    Exit Sub
                End If
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Try
            con.Open()
            sql = "INSERT INTO StudentInfo VALUES('" & Student_IDTextBox.Text & "', '" & Full_NameTextBox.Text & "','" & Phone_NoTextBox.Text & "','" & Room_NoComboBox.Text & "','" & GenderTextBox.Text & "', '" & DOBDateTimePicker.Value & "','" & YOADateTimePicker.Value & "','" & PictureTextBox.Text & "','" & First_NameTextBox.Text & "','" & Last_NameTextBox.Text & "', '" & OccupationTextBox.Text & "','" & Annual_IncomeTextBox.Text & "','" & ACardNo.Text & "','" & Mobile_NoTextBox.Text & "','" & Permanant_AddressTextBox.Text & "');"
            cmd.Connection = con
            cmd.CommandText = Sql
            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox(Full_NameTextBox.Text + " has been Saved Successfully!")

                viewreg.loaddata()
                Attendance.loadattendancedata()
            Else
                MsgBox("No record has been Saved!!!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
           
        Finally
            con.Close()
        End Try
        Full_NameTextBox.Clear()
        GenderTextBox.Clear()
        Phone_NoTextBox.Clear()
        PictureTextBox.Clear()
        Permanant_AddressTextBox.Clear()
        First_NameTextBox.Clear()
        Last_NameTextBox.Clear()
        Mobile_NoTextBox.Clear()
        OccupationTextBox.Clear()
        Annual_IncomeTextBox.Clear()
        PictureBox1.Image = Nothing
        Me.Refresh()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub



    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Full_NameTextBox.Clear()
        GenderTextBox.Clear()
        Phone_NoTextBox.Clear()
        PictureTextBox.Clear()
        First_NameTextBox.Clear()
        Last_NameTextBox.Clear()
        Mobile_NoTextBox.Clear()
        OccupationTextBox.Clear()
        Annual_IncomeTextBox.Clear()
        Permanant_AddressTextBox.Clear()
        PictureBox1.Image = Nothing
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub


    Private Sub Phone_NoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Phone_NoTextBox.KeyPress
        If Phone_NoTextBox.Text.Length = 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Phone Number Should be only 10 digits", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub Full_NameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Full_NameTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Only Letters Accepted", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Mobile_NoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Mobile_NoTextBox.KeyPress
        If Mobile_NoTextBox.Text.Length = 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Phone Number Should be only 10 digits", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub First_NameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles First_NameTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Only Letters Accepted", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Last_NameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Last_NameTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Only Letters Accepted", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Permanant_AddressTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Permanant_AddressTextBox.KeyPress
        If Permanant_AddressTextBox.Text.Length >= 120 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Address Should be not more than 120 words", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse.Click

        OpenFileDialog1.Filter = "JPEGs|*.jpg|PNG|*.png"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureTextBox.Text = OpenFileDialog1.FileName()
        End If
    End Sub


End Class
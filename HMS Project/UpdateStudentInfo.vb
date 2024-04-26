Imports System.Data.OleDb

Public Class UpdateStudentInfo
  


    Private Sub UpdateStudentInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DOB.Text = "01-01-2000"
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Len(Trim(StudentID.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            
            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Phone_No,DOB,Picture,First_Name,Last_Name,Mobile_No,Permanant_Address from StudentInfo where Student_ID='" + StudentID.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            StudentID.Text = myreader("Student_ID")
            FullName.Text = myreader("Full_Name")
            PhoneNo.Text = myreader("Phone_No")
            DOB.Text = myreader("DOB")
            PictureTextBox.Text = myreader("Picture")
            FirstName.Text = myreader("First_Name")
            LastName.Text = myreader("Last_Name")
            MobileNo.Text = myreader("Mobile_No")
            Address.Text = myreader("Permanant_Address")
            Picture.Refresh()
            Picture.ImageLocation = PictureTextBox.Text
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Enter a valid Student ID to Search Records!!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(FullName.Text)) = 0 Then
            MessageBox.Show("Enter Student Full Name", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(PhoneNo.Text)) = 0 Then
            MessageBox.Show("Enter Student Phone Number", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(DOB.Text)) = 0 Then
            MessageBox.Show("Enter DOB", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(FirstName.Text)) = 0 Then
            MessageBox.Show("Enter First Name", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(LastName.Text)) = 0 Then
            MessageBox.Show("Enter Last Name", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(MobileNo.Text)) = 0 Then
            MessageBox.Show("Enter Mobile No", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Address.Text)) = 0 Then
            MessageBox.Show("Enter Address", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try

            conn.Open()
            sql = "UPDATE StudentInfo SET Full_Name='" & FullName.Text & "', Phone_No='" & PhoneNo.Text & "', DOB='" & DOB.Text & "', Picture='" & PictureTextBox.Text & "', First_Name='" & FirstName.Text & "', Last_Name='" & LastName.Text & "', Mobile_No='" & MobileNo.Text & "', Permanant_Address='" & Address.Text & "' WHERE Student_ID='" + StudentID.Text + "'"
            cmd.Connection = conn
            cmd.CommandText = sql
            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox(FullName.Text + " has been Updated successfully!")
                conn.Close()
                Me.Hide()
                viewreg.loaddata()
                Attendance.loadattendancedata()
            Else
                MsgBox("No record has been UPDATED!")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        FullName.Clear()
        PhoneNo.Clear()
        DOB.Clear()
        PictureTextBox.Clear()
        Picture.Image = Nothing
        FirstName.Clear()
        LastName.Clear()
        MobileNo.Clear()
        Address.Clear()
        StudentID.Clear()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub PhoneNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneNo.KeyPress
        If PhoneNo.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Phone Number Should be only 10 digits", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub MobileNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MobileNo.KeyPress
        If MobileNo.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Mobile Number Should be only 10 digits", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub DOB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DOB.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "-" And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub LastName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FullName.KeyPress, LastName.KeyPress, FirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Only Letters Accepted", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateStudentInfo_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StudentID.Text = "H001"
    End Sub

    Private Sub Address_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Address.Text.Length >= 120 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Address Should be not more than 120 words", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse.Click

        OpenFileDialog1.Filter = "JPEGs|*.jpg|PNG|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Picture.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureTextBox.Text = OpenFileDialog1.FileName()
        End If
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub
End Class
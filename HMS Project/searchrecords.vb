Imports System.Data.OleDb

Public Class searchrecords
   

    Private Sub searchrecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Stud_IdSearch.Text = "H001"
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.Full_NameTextBox.Clear()
        Me.Gender.Clear()
        Me.Phone_NoTextBox.Clear()
        Me.Student_IDTextBox.Clear()
        Me.PictureTextBox.Clear()
        Me.Permanant_AddressTextBox.Clear()
        Me.First_NameTextBox.Clear()
        Me.Room_NoTextBox.Clear()
        Me.YOA.Clear()
        Me.DOB.Clear()
        Me.Last_NameTextBox.Clear()
        Me.Mobile_NoTextBox.Clear()
        Me.OccupationTextBox.Clear()
        Me.Annual_IncomeTextBox.Clear()
        Me.PictureBox1.Image = Nothing
        UpdateStudentInfo.ShowDialog()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Full_NameTextBox.Clear()
        Gender.Clear()
        Phone_NoTextBox.Clear()
        Student_IDTextBox.Clear()
        PictureTextBox.Clear()
        First_NameTextBox.Clear()
        Last_NameTextBox.Clear()
        DOB.Clear()
        YOA.Clear()
        Room_NoTextBox.Clear()
        PictureBox1.Refresh()
        Mobile_NoTextBox.Clear()
        OccupationTextBox.Clear()
        Annual_IncomeTextBox.Clear()
        Permanant_AddressTextBox.Clear()
        PictureBox1.Image = Nothing
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click

        If Len(Trim(Stud_IdSearch.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            
            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Phone_No,Room_No,Gender,DOB,YOA,Picture,First_Name,Last_Name,Occupation,Annual_Income,Mobile_No,Permanant_Address from StudentInfo where Student_ID='" + Stud_IdSearch.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Student_IDTextBox.Text = myreader("Student_ID")
            Full_NameTextBox.Text = myreader("Full_Name")
            Phone_NoTextBox.Text = myreader("Phone_No")
            Room_NoTextBox.Text = myreader("Room_No")
            Gender.Text = myreader("Gender")
            DOB.Text = myreader("DOB")
            YOA.Text = myreader("YOA")
            PictureTextBox.Text = myreader("Picture")
            First_NameTextBox.Text = myreader("First_Name")
            Last_NameTextBox.Text = myreader("Last_Name")
            OccupationTextBox.Text = myreader("Occupation")
            Annual_IncomeTextBox.Text = myreader("Annual_Income")
            Mobile_NoTextBox.Text = myreader("Mobile_No")
            Permanant_AddressTextBox.Text = myreader("Permanant_Address")
            PictureBox1.Refresh()
            PictureBox1.ImageLocation = PictureTextBox.Text
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Enter a valid Student ID to Search Records!!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub BtnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProfile.Click
        Me.Full_NameTextBox.Clear()
        Me.Gender.Clear()
        Me.Phone_NoTextBox.Clear()
        Me.Student_IDTextBox.Clear()
        Me.PictureTextBox.Clear()
        Me.Permanant_AddressTextBox.Clear()
        Me.First_NameTextBox.Clear()
        Me.Room_NoTextBox.Clear()
        Me.YOA.Clear()
        Me.DOB.Clear()
        Me.Last_NameTextBox.Clear()
        Me.Mobile_NoTextBox.Clear()
        Me.OccupationTextBox.Clear()
        Me.Annual_IncomeTextBox.Clear()
        Me.PictureBox1.Image = Nothing
        Profile.ShowDialog()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub
End Class
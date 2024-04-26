Imports System.Data.OleDb

Public Class Profile
   


    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click

        If Len(Trim(StudentID.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            
            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Phone_No,Room_No,DOB,YOA,Picture,First_Name,Last_Name,Mobile_No,Permanant_Address from StudentInfo where Student_ID='" + StudentID.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            StudentID.Text = myreader("Student_ID")
            FullName.Text = myreader("Full_Name")
            PhoneNo.Text = myreader("Phone_No")
            RoomNo.Text = myreader("Room_No")
            DOB.Text = myreader("DOB")
            YOA.Text = myreader("YOA")
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
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.Print()
        Me.Close()
        FullName.Clear()
        PhoneNo.Clear()
        DOB.Clear()
        YOA.Clear()
        RoomNo.Clear()
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

    Private Sub Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StudentID.Text = "H001"
    End Sub

    Private Sub GunaLineTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomNo.TextChanged

    End Sub

    Private Sub Picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture.Click
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub
End Class
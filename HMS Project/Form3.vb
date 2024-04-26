Imports System.Data.OleDb

Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me.HmsDataSet.StudentInfo)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\HMS Project\HMS Project\Hms.accdb")
            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Phone_No,Room_No,DOB,YOA from StudentInfo where Room_No='" + RoomNo.Text + "'"
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
            StudentID.Text = myreader("StudentId2")
            FullName.Text = myreader("FullName2")
            PhoneNo.Text = myreader("PhoneNo2")
            DOB.Text = myreader("DOB2")
            YOA.Text = myreader("YOA2")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Enter a!!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
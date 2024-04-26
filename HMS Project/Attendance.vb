Imports System.Data
Imports System.Data.OleDb

Public Class Attendance

  
    'SKN
    Sub loadattendancedata()
        con.Open()
        Dim cmd As New OleDbCommand("Select Student_ID, Full_Name From StudentInfo", con)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
        DataGridView1.Refresh()
    End Sub

    Private Sub Attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Text = Now
        loadattendancedata()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For item As Integer = 0 To DataGridView1.RowCount - 1
            DataGridView1.Rows(item).Cells(0).Value = False
        Next
    End Sub


    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cmd As New OleDbCommand("Select date_attendance from attendance where date_attendance = @date1", conn)
        cmd.Parameters.AddWithValue("date1", DateTimePicker1.Value.Date)
        conn.Open()
        Dim myreader As OleDbDataReader = cmd.ExecuteReader
        If myreader.Read() Then
            conn.Close()
            MessageBox.Show("Already Inserted!!, Please try again tomorrow", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            conn.Close()
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim cmd1 As New OleDbCommand("Insert into attendance(Student_ID,Full_Name,date_attendance,status_attendance) values (@Student_ID,@Full_Name,@date1,@status1)", conn)
                cmd1.Parameters.AddWithValue("Student_ID", row.Cells("Student_ID").Value)
                cmd1.Parameters.AddWithValue("Full_Name", row.Cells("Full_Name").Value)
                cmd1.Parameters.AddWithValue("date1", DateTimePicker1.Value.Date)
                Dim statuscolumn As Integer
                If Convert.ToBoolean(row.Cells("status_attendance").Value) Then

                    statuscolumn = 1
                    Else

                    statuscolumn = 0
                    End If
                cmd1.Parameters.AddWithValue("status1", statuscolumn)
                conn.Open()
                cmd1.ExecuteNonQuery()
                conn.Close()
            Next
            MessageBox.Show("Records inserted successfully", "Attendance", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub


  
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
Imports System.Data.OleDb

Public Class Form2


    'SKN
    Sub loadform(ByVal PANEL As Form)
        Base_Body.Controls.Clear()
        PANEL.TopLevel = False
        Base_Body.Controls.Add(PANEL)
        PANEL.Show()
    End Sub

    Private Sub AddStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentsToolStripMenuItem.Click
        newreg.Refresh()
        loadform(newreg)
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub ViewStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentsToolStripMenuItem.Click
        viewreg.Refresh()
        loadform(viewreg)
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub CanteenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanteenToolStripMenuItem.Click
        canteen.Refresh()
        loadform(canteen)
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click

        Dim d As String
        d = MsgBox("Are you sure want to exit?", vbYesNo + vbQuestion)
        If d = vbYes Then
            Application.Restart()
        Else
            Exit Sub
        End If
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordsToolStripMenuItem.Click
        searchrecords.Full_NameTextBox.Clear()
        searchrecords.Gender.Clear()
        searchrecords.Phone_NoTextBox.Clear()
        searchrecords.Student_IDTextBox.Clear()
        searchrecords.PictureTextBox.Clear()
        searchrecords.Permanant_AddressTextBox.Clear()
        searchrecords.First_NameTextBox.Clear()
        searchrecords.Room_NoTextBox.Clear()
        searchrecords.YOA.Clear()
        searchrecords.DOB.Clear()
        searchrecords.Last_NameTextBox.Clear()
        searchrecords.Mobile_NoTextBox.Clear()
        searchrecords.OccupationTextBox.Clear()
        searchrecords.Annual_IncomeTextBox.Clear()
        searchrecords.PictureBox1.Image = Nothing
        loadform(searchrecords)
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub


    Private Sub FrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrToolStripMenuItem.Click
        Attendance.Refresh()
        loadform(Attendance)
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadform(newreg)
        Try
            con.Open()
            lbl_connection.Text = "Connected"
            lbl_connection.ForeColor = Color.Green
        Catch ex As Exception
            lbl_connection.Text = "Dis-Connected"
            lbl_connection.ForeColor = Color.Red
        End Try
        con.Close()
        ToolStripStatusLabel2.Text = Now
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub RegistrationToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem.MouseHover

    End Sub

    Private Sub LblShowUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblShowUsername.Click
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub
End Class
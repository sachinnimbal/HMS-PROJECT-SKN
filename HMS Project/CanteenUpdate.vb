Imports System.Data.OleDb

Public Class CanteenUpdate

    'SKN

    Private Sub CanteenUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(MorningTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Morning", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(AfternoonTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Afternoon", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(EveningTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Evening", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(NightTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Night", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try

            conn.Open()
            sql = "UPDATE Canteen SET Morning='" & MorningTextBox.Text & "', Afternoon='" & AfternoonTextBox.Text & "', Evening='" & EveningTextBox.Text & "', Night='" & NightTextBox.Text & "' WHERE Days='" + Days.Text + "'"
            cmd.Connection = conn
            cmd.CommandText = sql
            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox(Days.Text + " has been Updated successfully!")
                canteen.loaddata()
                conn.Close()
                MorningTextBox.Clear()
                AfternoonTextBox.Clear()
                EveningTextBox.Clear()
                NightTextBox.Clear()
                Me.Hide()
            Else
                MsgBox("No record has been UPDATED!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
       

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Len(Trim(Days.Text)) = 0 Then
            MessageBox.Show("Select Valid Days to Search", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            conn.Open()
            Dim sql As String
            sql = "Select * from Canteen where Days='" + Days.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            MorningTextBox.Text = myreader("Morning")
            AfternoonTextBox.Text = myreader("Afternoon")
            EveningTextBox.Text = myreader("Evening")
            NightTextBox.Text = myreader("Night")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Select Valid Days!!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub


    Private Sub MorningTextBox_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NightTextBox.KeyPress, MorningTextBox.KeyPress, EveningTextBox.KeyPress, AfternoonTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Only Letters Accepted", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
﻿Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    'SKN
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            lbl_connection.Text = "Connected"
            lbl_connection.ForeColor = Color.DarkOliveGreen
        Catch ex As Exception
            lbl_connection.Text = "Dis-Connected"
            lbl_connection.ForeColor = Color.Red
        End Try
        con.Close()
        txtPassword.UseSystemPasswordChar = True
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
       
        txtUserName.Clear()
        txtPassword.Clear()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM Users WHERE UserName = '" & txtUserName.Text & "' AND Password = '" & txtPassword.Text & "' ", con)
            Dim user As String = ""
            Dim pass As String = ""
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                user = sdr("UserName")
                pass = sdr("Password")
                Me.Hide()
                Form2.LblShowUsername.Text = txtUserName.Text
                txtUserName.Clear()
                txtPassword.Clear()
                Form2.Show()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Username or Password!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            con.Close()

        End Try
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCheckBox1.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT
        If GunaCheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress, txtPassword.KeyPress, MyBase.KeyPress
        If txtUserName.Text.Length >= 5 Then
            If txtPassword.Text.Length >= 5 Then
                If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
                    e.Handled = True
                    MessageBox.Show("Only Letters Accepted", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub


End Class

Imports System.Data


Public Class viewreg

    Sub loaddata()
        Me.StudentInfoTableAdapter.Fill(Me.HmsDataSet.StudentInfo)

    End Sub

    Private Sub viewreg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.StudentInfo' table. You can move, or remove it, as needed.
        loaddata()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        savedregPrint.ShowDialog()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub StudentInfoDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentInfoDataGridView.CellContentClick
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub
End Class
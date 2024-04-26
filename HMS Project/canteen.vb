Public Class canteen
    'SKN
    Sub loaddata()
        Me.CanteenTableAdapter.Fill(Me.HmsDataSet.Canteen)
    End Sub

    Private Sub canteen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.Canteen' table. You can move, or remove it, as needed.
        loaddata()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        canteenprint.ShowDialog()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        CanteenUpdate.ShowDialog()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        CanteenUpdate.ShowDialog()
        Dim url As String = "https://sachinskn.blogspot.com"
        Process.Start(url)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
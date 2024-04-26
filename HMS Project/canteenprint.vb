Public Class canteenprint
    'SKN
    Private Sub canteenprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.Canteen' table. You can move, or remove it, as needed.
        Me.CanteenTableAdapter.Fill(Me.HmsDataSet.Canteen)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub canteenprint_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub
End Class
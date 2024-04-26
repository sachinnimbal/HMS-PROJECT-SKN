Public Class savedregPrint

    Private Sub savedregPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me.HmsDataSet.StudentInfo)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub savedregprint_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub

End Class
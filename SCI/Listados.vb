Public Class Listados

    Private Sub Listados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim d As New IO.DirectoryInfo("C:\Users\IRAIC\Desktop\gymv2\gym\reportes")
        Dim d As New IO.DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory & "\reportes")
        For Each F As IO.FileInfo In d.GetFiles("*.rpt")
            Dim l As New ListViewItem
            l.Text = F.Name
            l.Tag = F.FullName
            l.ImageIndex = 0
            ListView1.Items.Add(l)
        Next
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        'Dim r As New Reporte
        'r.CrystalReportViewer1.ReportSource = ListView1.SelectedItems(0).Tag

        'r.CrystalReportViewer1.RefreshReport()
        'r.Show()
    End Sub

End Class
Public Class Reporte_Pega3
    Private _Origen As List(Of EacumuladoP3)

    Sub New(_Datos As List(Of EacumuladoP3))
        _Origen = _Datos
        InitializeComponent()
    End Sub

    Private Sub Reporte_Pega3_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load



    End Sub

    Private Sub Reporte_Pega3_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer2_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer2.Load
        Dim _Reporte As New AcumuladoPega3ContY
        _Reporte.SetDataSource(_Origen)
        CrystalReportViewer2.ReportSource = _Reporte
    End Sub
End Class
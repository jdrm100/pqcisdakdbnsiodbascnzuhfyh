Public Class AcumladoPega3



    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        Try
            Dim _Datos As New CcccAcumuladoPega3
            Dim _Entidad As List(Of EacumuladoP3) = _Datos.acumuladoPega3(dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date)

            Dim _Representar As New Reporte_Pega3(_Entidad)
            _Representar.Show()
        Catch ex As Exception
            MessageBox.Show("Error al  llamar el Procedimiento", "Llamar los Metodos ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AcumladoPega3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

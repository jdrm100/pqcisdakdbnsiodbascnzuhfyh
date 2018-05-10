Public Class FRMReporte_Recarga
    Private _Dt As New DataTable
    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click

        reporteRecargaResumido()
        reporteRecargaDetallada()
        reporteRecargaTrans()





    End Sub

    Public Sub reporteRecargaDetallada()
        If rd_detalla.Checked = True Then
            Try



                If txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then

                    Dim _Buscar As New CCCRecargaDetallado
                    Dim _Lista As List(Of Erecargadetalla) = _Buscar.recargarDetallada(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))


                    Dim _Mostar As New frm_Sistema_de_Facturacion_Reporte_de_Recargas(_Lista)
                    _Mostar.Show()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al  llamar el Procedimiento,No se puede ingresar LETRAS", "Llamar los Metodos y Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Public Sub reporteRecargaResumido()
        If Me.ValidateChildren = True And txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then


            Try
                If rd_resumida.Checked = True Then
                    If txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
                        Dim _Buscar As New CccReporteRecargaResumido
                        Dim _Lista As List(Of Ereporterecargaresumido) = _Buscar.reporteRecargaResumido(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))

                        Dim _Mostrar As New frmSistema_de_Facturacion_Reporte_de_Recarga(_Lista)
                        _Mostrar.Show()

                    End If

                End If


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("Introduzca el numero del agente por favor,Este campo es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Public Sub reporteRecargaTrans()

        If rd_transacciones.Checked = True Then

            Try


                If txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
                    Dim _todos As String = "1"
                    If chktodos.Checked = True Then
                        _todos = "2"
                    Else
                        _todos = "1"
                    End If
                    Dim _Buscar As New CCCReporteRecargaTrancciones
                    Dim _Lista As List(Of Ereporterecargatran) = _Buscar.reporteRecargaTran(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text), cbo_operadora.SelectedValue, _todos)

                    Dim _Mostar As New Ssitema_de_Facturacion_Transanciones(_Lista)
                    _Mostar.Show()



                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("Error al  llamar el Procedimiento,No se puede ingresar LETRAS", "Llamar los Metodos y Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Public Sub mostrarProveedorComboz()

        Dim _Mostrar As New CCCRecargaTransCombo
        _Dt = _Mostrar.mostrar


        cbo_operadora.DisplayMember = "proveedor"
        cbo_operadora.ValueMember = "codigo"

        cbo_operadora.DataSource = _Dt

    End Sub


    '    Private Sub Reporte_Recarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        'mostrar()
    '        txt_agente.Select()
    '        cargarCmbRecarga()
    '    End Sub







    'Private Sub cargarCmbRecarga()
    '    Dim _Buscar As New CCCRecargaDetallado
    '    Dim lista As DataTable = _Buscar.CargarProveedor()
    '    cbo_operadora.DataSource = lista
    '    cbo_operadora.DisplayMember = "d"
    '    cbo_operadora.ValueMember = "codigojuego"
    'End Sub



    Private Sub txt_agente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_agente.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                'txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
                Errorvalicion.SetError(sender, "")
            Else
                Errorvalicion.SetError(sender, "introduzca el numero del agente por favor,Este campo es obligatorio")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al valida los CAMPOS", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub FRMReporte_Recarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarProveedorComboz()

    End Sub

    Private Sub rd_transacciones_CheckedChanged(sender As Object, e As EventArgs) Handles rd_transacciones.CheckedChanged

    End Sub

    Private Sub chktodos_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            cbo_operadora.Enabled = False
        Else
            cbo_operadora.Enabled = True
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Dispose()
    End Sub
End Class
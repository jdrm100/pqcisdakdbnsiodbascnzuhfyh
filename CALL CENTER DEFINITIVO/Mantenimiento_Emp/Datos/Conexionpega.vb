Imports System.Data.SqlClient

Public Class Conexionpega

    Protected _ccn As SqlConnection
    Protected Function _conectar()
        Try
            ''
            _ccn = New SqlConnection("Data Source=10.0.0.8\SERVERR2;Initial Catalog=lrc_r4;User ID=lrc;password=lrc12345")
            _ccn.Open()
            Return True

        Catch ex As Exception
            'MsgBox("Error en la conexion en la Base de Datos", "Conexion")
        End Try

        Return False


    End Function
    Protected Function _descconectar()
        Try

            If _ccn.State = ConnectionState.Open Then
                _ccn.Close()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("No se ha se Cerrado la Conexion")
        End Try
        Return False
    End Function

End Class

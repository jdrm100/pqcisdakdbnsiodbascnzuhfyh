
Imports System.Data.SqlClient

Public Class CcccAcumuladoPega3
    Inherits Conexionpega
    Protected _Cmd As New SqlCommand



    Public Function acumuladoPega3(_FechaInicial As Date, FechaFinal As Date) As List(Of EacumuladoP3)

        _conectar()

        Dim _Acumulado As New List(Of EacumuladoP3)

        _Cmd = New SqlCommand("REPORTEPEGA3DOS")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.CommandTimeout = 1200000
        _Cmd.Connection = _ccn

        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 20).Value = _FechaInicial
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 20).Value = FechaFinal

        Dim _Reader As SqlDataReader = _Cmd.ExecuteReader
        Dim _total As Decimal = 0
        While _Reader.Read

            Dim _Acumulados As New EacumuladoP3
            Dim _SumaTerminales As Integer
            Dim _ReservaJacTotal As Decimal
            Dim _Totaldecontribucciones As Decimal
            Dim _TotalPocientoter As Decimal
            Dim _TotadePorciTerm As Decimal
            Dim _TotalLotorea As Decimal
            Dim _TotalContribupor As Decimal
            Dim TotalPorcienCuar As Decimal

            Dim _PorcientoTerminales As Decimal

            _Acumulados._Provincias = _Reader("Provincias").ToString
            _Acumulados._TotalTerminalesPr = _Reader("Totaldeterminales")
            _Acumulados._PorcientoporTerminalPro = _Reader("PorcientodeTotaldeterminales")
            _Acumulados._Lotoreal = _Reader("VENTAS")
            _Acumulados._TotaldeContribuccion = _Reader("PorcientodeTotaldeterminalespocuarenta")
            _Acumulados._Terminales = _Reader("Terminales")
            '_Acumulados._porcientoTotalAcumulado = _Reader("")
            '_Acumulados._ReservadeAcumulado = _Reader("")
            '_Acumulados._TotaldeContribuccion = _Reader("")
            _Acumulados._FechaID = _FechaInicial
            _Acumulados._FechaDE = FechaFinal

            '`Las sumas de la terminales
            _SumaTerminales += (_Acumulados._Terminales)
            _Acumulados._Total1 = _SumaTerminales


            '``Calcular el porciento de Terminales

            _PorcientoTerminales = _Acumulados._Terminales

            _Acumulados._Total2 = (_PorcientoTerminales / _Acumulados._TotalTerminalesPr)

            'Suma total de Porciento de Terminales
            _TotadePorciTerm += _Acumulados._Total2
            _Acumulados._TotalporcientoTer = _TotadePorciTerm


            '``Calcular el porciento de contribuccion al Jackpot

            _Acumulados._Total3 = _Acumulados._Lotoreal * 50 / 100

            _total += _Acumulados._Total3

            'Calcular la Reserva Jackpot
            _Acumulados._ReservadeAcumulado = _Acumulados._Lotoreal * 1 / 100

            'Total de Reserva de Jackpot
            _ReservaJacTotal += _Acumulados._ReservadeAcumulado
            _Acumulados._Total8 = _ReservaJacTotal


            _Totaldecontribucciones = _Acumulados._Total3 + _Acumulados._ReservadeAcumulado
            _Acumulados._TotaldeContribuccion = _Totaldecontribucciones

            'Total de porciento de terminales
            _TotalPocientoter += _Acumulados._Total2
            _Acumulados._TotalporcientoTer = _TotalPocientoter

            'Total de Lotoreal

            _TotalLotorea += _Acumulados._Lotoreal
            _Acumulados._TotaldeLotoreal = _TotalLotorea


            'Suma total de Contribuccion 

            _TotalContribupor += _Acumulados._TotaldeContribuccion
            _Acumulados._Totala = _TotalContribupor

            ''Suma total de por ciento contribuccion JACKPORT al ladoC:\Users\Ing Jose Olivo\Desktop\Acumulado Pega3 y Antiguedad\Visual Studio 2013\Projects\AcumuladoPega3\AcumuladoPega3\Logica\CcccAcumuladoPega3.vb
            '_TotalPorcienAL = _Acumulados._PorcientoContJackpot
            '_Acumulados._Totalb = _TotalPorcienAL


            'TotalPorcienJac += _Acumulados._ReservadeAcumulado
            '_Acumulados._Total7 = TotalPorcienJac

            TotalPorcienCuar += _Acumulados._Total3
            _Acumulados._Totaljac = TotalPorcienCuar


            _Acumulado.Add(_Acumulados)



        End While

        ''Dim _Incremento As Integer = -1

        ''For Each _Elemento In _Acumulado
        ''    _Incremento += 1
        ''    _Acumulado.Item(_Incremento)._PorcientoContJackpot = _Acumulado.Item(_Incremento)._Total3 / _total
        ''    'MsgBox(_Acumulado.Item(_Incremento)._Total3 & " / " & _total & " = " & _Acumulado.Item(_Incremento)._PorcientoContJackpot)

        'Next
        Dim _TotaldeTerminales As Decimal
        Dim _TotalPorcienAL As Decimal
        Dim __TotalPorcienJac As Decimal
        Dim i As Integer = 0
        For i = 0 To _Acumulado.Count - 1
            '``Calcular  contribuccion al Jackpot por ciento
            _Acumulado.Item(i)._PorcientoContJackpot = _Acumulado.Item(i)._Total3 / _total

            'Total  Por ciento al contribuccion al Jackpot
            _Acumulado.Item(i)._Total7 += _Acumulado.Item(i)._PorcientoContJackpot

            _TotaldeTerminales += _Acumulado.Item(i)._Total2
            _Acumulado.Item(i)._TotalporcientoTer = _TotaldeTerminales

            'Suma total de por ciento contribuccion JACKPORT al ladoC:\Users\Ing Jose Olivo\Desktop\Acumulado Pega3 y Antiguedad\Visual Studio 2013\Projects\AcumuladoPega3\AcumuladoPega3\Logica\CcccAcumuladoPega3.vb
            _TotalPorcienAL += _Acumulado.Item(i)._PorcientoContJackpot
            _Acumulado.Item(i)._Totalb = _TotalPorcienAL

            'Sumar el porciento al Jackport
            __TotalPorcienJac += _Acumulado.Item(i)._ReservadeAcumulado
            _Acumulado.Item(i)._Total7 = __TotalPorcienJac
        Next

        _Reader.Close()
        _descconectar()


        Return _Acumulado

    End Function

    Protected Function tranformarFecha(_Fecha As Date) As String

        Dim _Ano, _Mes, _Dia As String

        _Ano = _Fecha.Year
        _Mes = _Fecha.Month.ToString
        _Dia = _Fecha.Day.ToString.PadLeft(0, "2")


        Return _Ano & _Mes & _Dia





    End Function



End Class

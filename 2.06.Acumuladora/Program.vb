Imports System

Module Program
    Sub Main(args As String())
        Dim valor As Decimal

        subruina(valor)
        subruina(valor)
        subruina(valor)
    End Sub
    Private Sub subruina(ByRef valor As Decimal)
        valor += 1
        Console.WriteLine("El acumulador es :" & valor)
    End Sub
End Module

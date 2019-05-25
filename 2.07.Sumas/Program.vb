Imports System.Math

Module Program
    Sub Main(args As String())
        Dim valor1 As Integer = 5
        Dim valor2 As Integer = 4
        Dim valor3 As Integer = 2
        Dim valor4 As Integer = 20
        Console.WriteLine(" :" & sumas(valor1, valor2))
        Console.WriteLine(" :" & sumas(valor1, valor2, valor3))
        Console.WriteLine(" :" & sumas(valor1, valor2, valor3, valor4))
    End Sub
    Private Function Sumas(valor1 As Integer, valor2 As Integer) As Integer
        Return valor1 + valor2
    End Function
    Private Function sumas(valor1 As Integer, valor2 As Integer, valor3 As Integer) As Integer
        Return valor1 + valor2 + valor3
    End Function
    Private Function sumas(valor1 As Integer, valor2 As Integer, valor3 As Integer, Valor4 As Integer) As Integer
        Return valor1 + valor2 + valor3 + Valor4
    End Function
End Module

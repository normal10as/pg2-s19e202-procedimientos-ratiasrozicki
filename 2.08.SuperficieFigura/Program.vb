Imports System.Math

Module Program
    Sub Main(args As String())
        Dim base As Integer = 3
        Dim altura As Integer = 4
        Dim basemayor As Integer = 7
        Console.WriteLine(" :" & superficie(base))
        Console.WriteLine(" :" & superficie(basemayor, altura))
        Console.WriteLine(" :" & superficie(basemayor, base, altura))
    End Sub
    Private Function superficie(base As Integer) As Integer
        Return base * base
    End Function
    Private Function superficie(basemayor As Integer, altura As Integer) As Integer
        Return basemayor * altura
    End Function
    Private Function superficie(basemayor As Integer, base As Integer, altura As Integer) As Integer
        Return ((basemayor + base) / 2) * altura
    End Function
End Module

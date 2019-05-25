Imports System.Math

Module Program

    Sub Main(args As String())
        Dim potencia As Integer
        Console.WriteLine("Ingrese un numero para calcular su Potencia :")
        Potencia = Console.ReadLine()
        Console.WriteLine("La potencia elevado a la 5ta es : " & potenciatres(potencia))
        Console.WriteLine("La potencia al Cuadrado es : " & potenciados(potencia))
        Console.WriteLine("La potencia al Cubo es : " & potenciauno(potencia))
    End Sub
    Function potenciatres(potencia As Integer) As Integer
        Return (Pow(potencia, 5))
    End Function
    Function potenciados(potencia As Integer) As Integer
        Return (Pow(potencia, 2))
    End Function
    Function potenciauno(potencia As Integer) As Integer
        Return (Pow(potencia, 3))
    End Function
End Module

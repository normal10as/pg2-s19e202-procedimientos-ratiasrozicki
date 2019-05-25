Imports System.Math

Module Program
    Sub Main(args As String())
        Dim a, b As UInt16

        Console.Write("ingrese el primer lado")
        a = Console.ReadLine()
        Console.Write("ingrese el Segundo lado")
        b = Console.ReadLine()
        Console.WriteLine("La Hipotenuza es :" & CalculoC(a, b))
        'ingresar los valores, llamar la funcion, imprimir resultado

    End Sub
    Function CalculoC(a As UInt16, b As UInt16) As UInt16
        Dim ladoxlado = Pow(a, 2) + Pow(b, 2)
        Return Sqrt(ladoxlado)
    End Function

End Module

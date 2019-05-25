Imports System.Math

Module Program

    Sub Main(args As String())
        Dim radio, altura As Single
        Console.Write("Ingrese el radio del Cilindro :")
        radio = Console.ReadLine()
        Console.Write("Ingrese la Altura :")
        altura = Console.ReadLine()
        Console.WriteLine("El volumen del Cilindro es: " & VolumenCilindro(radio, altura))

    End Sub
    Function VolumenCilindro(radio As Single, altura As Single) As Single
        Return Sqrt((Math.PI) * Pow(radio, 2) * altura)
    End Function
End Module

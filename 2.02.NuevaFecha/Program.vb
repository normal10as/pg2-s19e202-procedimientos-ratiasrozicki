Imports System
Module Program
    Sub Main(args As String())
        Dim fecha As Date
        Dim dia As Integer

        Console.WriteLine("Ingrese el dia de la fecha :")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese un dia a sumar")
        dia = Console.ReadLine()
        Console.WriteLine("Sumado los dias es :" & nuevafecha(fecha, dia))
    End Sub
    Function nuevafecha(fecha As Date, dia As Integer) As Date
        Return fecha.AddDays(dia)
    End Function
End Module

Imports TelefoniaEntidades

Module LineaTest

    Sub main()
        Dim linea_1 As New Linea
        Dim linea_2 As New Linea
        Dim linea_3 As New Linea
        Dim linea_4 As New Linea(372, 4456789)

        linea_1.CodiogoArea = 376
        linea_1.Numero = 4564212
        linea_1.Reactivar()
        'por debajo del rango permitido
        linea_2.CodiogoArea = 37
        linea_2.Numero = 64212
        linea_2.Suspender()
        'por encima del rango permitido
        linea_3.CodiogoArea = 37643
        linea_3.Numero = 154564212

        Console.WriteLine("Cod de Area Linea1: " & linea_1.CodiogoArea)
        Console.WriteLine("Numero Linea1: " & linea_1.Numero)
        Console.WriteLine("Estado de Linea1: " & linea_1.Estado & vbCrLf)

        Console.WriteLine("Cod de Area Linea2: " & linea_2.CodiogoArea)
        Console.WriteLine("Numero Linea2: " & linea_2.Numero)
        Console.WriteLine("Estado de Linea2: " & linea_2.Estado & vbCrLf)

        Console.WriteLine("Cod de Area Linea3: " & linea_3.CodiogoArea)
        Console.WriteLine("Numero Linea3: " & linea_3.Numero)
        Console.WriteLine("Estado de Linea3: " & linea_3.Estado & vbCrLf)
        'sobrecarga
        Console.WriteLine("Cod de Area Linea4: " & linea_4.CodiogoArea)
        Console.WriteLine("Numero Linea4: " & linea_4.Numero)
        linea_4.Reactivar()
        Console.WriteLine("Estado de Linea4: " & linea_4.Estado & vbCrLf)

        Console.ReadKey()
    End Sub
End Module

Imports TelefoniaEntidades

Module MegaByteTest
    Sub main()

        Dim megaByte_1 As New MegaByte
        Dim megaByte_2 As New MegaByte(680, "Megas Intermedio", 5)
        Dim megaByte_3 As New MegaByte

        megaByte_1.Nombre = "Megas Basico"
        megaByte_1.Precio = 375.63
        megaByte_1.Credito = 3

        MostrarDatosCargados(megaByte_1)

        MostrarPrueba(megaByte_1, 1048576)
        'MostrarPrueba(megaByte_1, 150)
        'MostrarPrueba(megaByte_1, 200)
        'MostrarPrueba(megaByte_1, 50)

        'MostrarDatosCargados(megaByte_2)

        'MostrarPrueba(megaByte_2, 130)
        'MostrarPrueba(megaByte_2, 150)
        'MostrarPrueba(megaByte_2, 200)
        'MostrarPrueba(megaByte_2, 50)
        'MostrarPrueba(megaByte_2, 160)
        ''probando cadena vacia para el campo Nombre
        'megaByte_3.Nombre = ""
        'MostrarDatosCargados(megaByte_3)

        Console.ReadKey()

    End Sub

    Private Sub MostrarDatosCargados(objeto As Plan)
        Console.WriteLine("Nombre del Paquete MegaByte: " & objeto.Nombre)
        Console.WriteLine("Precio del Paquete MegaByte: " & objeto.Precio)
        Console.WriteLine("MegaBytes del Paquete: " & objeto.Credito)
        Console.WriteLine("MegaBytes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
        Console.WriteLine("ToString: " & objeto.ToString & vbCrLf)
    End Sub

    Private Sub MostrarPrueba(objeto As Plan, valor As UInt32)
        objeto.addConsumo(valor)
        Console.WriteLine("MegaBytes Consumidos: " & valor)
        Console.WriteLine("MegaBytes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
    End Sub
End Module

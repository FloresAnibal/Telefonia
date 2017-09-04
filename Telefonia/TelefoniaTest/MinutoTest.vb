Imports TelefoniaEntidades

Module MinutoTest
    Sub main()

        Dim minuto_1 As New Minuto
        Dim minuto_2 As New Minuto(680, "Minuto Intermedio", 480)
        Dim minuto_3 As New Minuto

        minuto_1.Nombre = "Minuto Basico"
        minuto_1.Precio = 375.63
        minuto_1.Credito = 500

        MostrarDatosCargados(minuto_1)

        MostrarPrueba(minuto_1, 130)
        MostrarPrueba(minuto_1, 150)
        MostrarPrueba(minuto_1, 200)
        MostrarPrueba(minuto_1, 50)

        MostrarDatosCargados(minuto_2)

        MostrarPrueba(minuto_2, 130)
        MostrarPrueba(minuto_2, 150)
        MostrarPrueba(minuto_2, 200)
        MostrarPrueba(minuto_2, 50)
        MostrarPrueba(minuto_2, 160)
        'probando cadena vacia para el campo Nombre
        minuto_3.Nombre = ""
        MostrarDatosCargados(minuto_3)

        Console.ReadKey()

    End Sub

    Private Sub MostrarDatosCargados(objeto As Plan)
        Console.WriteLine("Nombre del Paquete Minuto: " & objeto.Nombre)
        Console.WriteLine("Precio del Paquete Minuto: " & objeto.Precio)
        Console.WriteLine("Minutos del Paquete: " & objeto.Credito)
        Console.WriteLine("Minutos Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
        Console.WriteLine("ToString: " & objeto.ToString & vbCrLf)
    End Sub

    Private Sub MostrarPrueba(objeto As Plan, valor As UInt32)
        objeto.addConsumo(valor)
        Console.WriteLine("Minutos Consumidos: " & valor)
        Console.WriteLine("Minutos Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
    End Sub
End Module

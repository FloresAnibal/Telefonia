Imports TelefoniaEntidades

Module MinutoTest
    Sub main()

        Dim minuto_1 As New Minuto
        Dim minuto_2 As New Minuto(680, "Paquete de Minutos 2", 480)

        minuto_1.Nombre = "Paquete de Minutos 1"
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

        Dim minuto_3 As Plan
        minuto_3 = New Minuto()
        minuto_3.Nombre = "Paquete de Minutos 3"
        minuto_3.Precio = 570
        minuto_3.Credito = 800
        MostrarDatosCargados(minuto_3)
        MostrarPrueba(minuto_3, 130)
        MostrarPrueba(minuto_3, 356)

        Dim minuto_4 As Plan
        minuto_4 = New Minuto(1200, "Paquete de Minutos 4", 765)
        MostrarDatosCargados(minuto_4)
        MostrarPrueba(minuto_4, 630)
        MostrarPrueba(minuto_4, 356)

        Console.ReadKey()

    End Sub

    Private Sub MostrarDatosCargados(objeto As Plan)
        Console.WriteLine("Nombre: " & objeto.Nombre)
        Console.WriteLine("Precio del Paquete: " & objeto.Precio)
        Console.WriteLine("Minutos en el Paquete: " & objeto.Credito)
        Console.WriteLine("Minutos Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
        Console.WriteLine("ToString: " & objeto.ToString & vbCrLf)
    End Sub

    Private Sub MostrarPrueba(objeto As Plan, valor As UInt32)
        objeto.addConsumo(valor)
        Console.WriteLine("Minutos Consumidos: " & valor)
        Console.WriteLine("Minutos Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
    End Sub

End Module

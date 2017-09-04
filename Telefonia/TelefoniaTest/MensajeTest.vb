Imports TelefoniaEntidades

Module MensajeTest
    Sub main()

        Dim mensaje_1 As New Mensaje
        Dim mensaje_2 As New Mensaje(680, "Mensaje Intermedio", 480)
        Dim mensaje_3 As New Mensaje

        mensaje_1.Nombre = "Mensaje Basico"
        mensaje_1.Precio = 375.63
        mensaje_1.Credito = 500

        MostrarDatosCargados(mensaje_1)

        MostrarPrueba(mensaje_1, 130)
        MostrarPrueba(mensaje_1, 150)
        MostrarPrueba(mensaje_1, 200)
        MostrarPrueba(mensaje_1, 50)

        MostrarDatosCargados(mensaje_2)

        MostrarPrueba(mensaje_2, 130)
        MostrarPrueba(mensaje_2, 150)
        MostrarPrueba(mensaje_2, 200)
        MostrarPrueba(mensaje_2, 50)
        MostrarPrueba(mensaje_2, 160)
        'probando cadena vacia para el campo Nombre
        mensaje_3.Nombre = ""
        MostrarDatosCargados(mensaje_3)

        Console.ReadKey()

    End Sub

    Private Sub MostrarDatosCargados(objeto As Plan)
        Console.WriteLine("Nombre del Paquete Mensaje: " & objeto.Nombre)
        Console.WriteLine("Precio del Paquete Mensaje: " & objeto.Precio)
        Console.WriteLine("Mensajes del Paquete: " & objeto.Credito)
        Console.WriteLine("Mensajes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
        Console.WriteLine("ToString: " & objeto.ToString & vbCrLf)
    End Sub

    Private Sub MostrarPrueba(objeto As Plan, valor As UInt32)
        objeto.addConsumo(valor)
        Console.WriteLine("Mensajes Consumidos: " & valor)
        Console.WriteLine("Mensajes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
    End Sub
End Module

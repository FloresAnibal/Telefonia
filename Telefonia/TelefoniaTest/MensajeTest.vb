Imports TelefoniaEntidades

Module MensajeTest
    Sub main()

        Dim mensaje_1 As New Mensaje
        Dim mensaje_2 As New Mensaje(680, "Paquete de Mensajes 2", 480)

        mensaje_1.Nombre = "Paquete de Mensajes 1"
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

        Dim mensaje_3 As Plan
        mensaje_3 = New Mensaje()
        mensaje_3.Nombre = "Paquete de Mensajes 3"
        mensaje_3.Precio = 450
        mensaje_3.Credito = 750
        MostrarDatosCargados(mensaje_3)
        MostrarPrueba(mensaje_3, 330)
        MostrarPrueba(mensaje_3, 530)

        Dim mensaje_4 As Plan
        mensaje_4 = New Mensaje(1000, "Paquete de Mensaje 4", 930)
        MostrarDatosCargados(mensaje_4)
        MostrarPrueba(mensaje_4, 330)
        MostrarPrueba(mensaje_4, 530)

        Console.ReadKey()

    End Sub

    Private Sub MostrarDatosCargados(objeto As Plan)
        Console.WriteLine("Nombre: " & objeto.Nombre)
        Console.WriteLine("Precio del Paquete: " & objeto.Precio)
        Console.WriteLine("Mensajes en el Paquete: " & objeto.Credito)
        Console.WriteLine("Mensajes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
        Console.WriteLine("ToString: " & objeto.ToString & vbCrLf)
    End Sub

    Private Sub MostrarPrueba(objeto As Plan, valor As UInt32)
        objeto.addConsumo(valor)
        Console.WriteLine("Mensajes Consumidos: " & valor)
        Console.WriteLine("Mensajes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
    End Sub

End Module

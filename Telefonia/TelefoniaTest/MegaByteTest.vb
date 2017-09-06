Imports TelefoniaEntidades

Module MegaByteTest
    Sub main()

        Dim megaByte_1 As New MegaByte
        Dim megaByte_2 As New MegaByte(5, "Megas Intermedio", 680)

        megaByte_1.Nombre = "Megas Basico"
        megaByte_1.Precio = 375.63
        megaByte_1.Credito = 3

        MostrarDatosCargados(megaByte_1)

        MostrarPrueba(megaByte_1, 1048576) '1MB
        MostrarPrueba(megaByte_1, 1048576) '1MB
        MostrarPrueba(megaByte_1, 524288)  '1/2MB
        MostrarPrueba(megaByte_1, 524288)  '1/2MB

        MostrarDatosCargados(megaByte_2)

        MostrarPrueba(megaByte_2, 2097152)  '2MB
        MostrarPrueba(megaByte_2, 262144)   '1/4MB
        MostrarPrueba(megaByte_2, 1048576)  '1MB
        MostrarPrueba(megaByte_2, 262144)   '1/4MB
        MostrarPrueba(megaByte_2, 524288)   '1/2MB
        MostrarPrueba(megaByte_2, 2097152)  '2MB
        MostrarPrueba(megaByte_2, 1048576)  '1MB

        Dim megaByte_3 As Plan
        megaByte_3 = New MegaByte()
        megaByte_3.Nombre = "Megas Plus"
        megaByte_3.Precio = 500
        megaByte_3.Credito = 10
        MostrarDatosCargados(megaByte_3)
        MostrarPrueba(megaByte_3, 2097152)  '2MB

        Dim megaByte_4 As Plan
        megaByte_4 = New MegaByte(15, "Megas Ultra", 750)
        MostrarDatosCargados(megaByte_4)
        MostrarPrueba(megaByte_4, 4194304)  '4MB
        MostrarPrueba(megaByte_4, 4456448)  '4 1/4MB

        Console.ReadKey()

    End Sub

    Private Sub MostrarDatosCargados(objeto As Object)
        Console.WriteLine("Nombre del Paquete MegaByte: " & objeto.Nombre)
        Console.WriteLine("Precio del Paquete MegaByte: " & objeto.Precio)
        Console.WriteLine("MegaBytes del Paquete: " & objeto.Credito)
        Console.WriteLine("MegaBytes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
        Console.WriteLine("ToString: " & objeto.ToString & vbCrLf)
    End Sub

    Private Sub MostrarPrueba(objeto As Plan, valor As UInt32)
        objeto.addConsumo(valor)
        Console.WriteLine("MegaBytes Consumidos: " & valor / 1048576)
        Console.WriteLine("MegaBytes Disponibles en el Paquete: " & objeto.disponible & vbCrLf)
    End Sub
End Module

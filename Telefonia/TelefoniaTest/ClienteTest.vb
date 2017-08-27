Imports TelefoniaEntidades

Module ClienteTest
    Sub main()

        Dim cliente_1 As New Cliente

        cliente_1.Id = 3245

        Console.WriteLine("ID de Cliente: " & cliente_1.Id)

        Console.ReadKey()

    End Sub
End Module

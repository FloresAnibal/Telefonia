Imports TelefoniaEntidades

Module EmpresaTest
    Sub main()

        Dim empresa_1 As New Empresa
        Dim empresa_2 As New Empresa
        Dim empresa_3 As New Empresa("Sistemas", "30-23454786-1")

        empresa_1.RazonSocial = "Programacion"
        empresa_1.Cuit = "30-897456-0"
        'fuera del rango permitido
        empresa_2.RazonSocial = ""
        empresa_2.Cuit = 30897456098732

        Console.WriteLine("Razon Social: " & empresa_1.RazonSocial)
        Console.WriteLine("CUIT: " & empresa_1.Cuit & vbCrLf)

        Console.WriteLine("Razon Social2: " & empresa_2.RazonSocial)
        Console.WriteLine("CUIT2: " & empresa_2.Cuit & vbCrLf)
        'sobrecarga
        Console.WriteLine("Razon Social3: " & empresa_3.RazonSocial)
        Console.WriteLine("CUIT3: " & empresa_3.Cuit)

        Console.ReadKey()

    End Sub
End Module

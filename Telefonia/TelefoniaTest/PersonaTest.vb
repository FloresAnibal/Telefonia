Imports TelefoniaEntidades

Module PersonaTest
    Sub main()

        Dim persona_1 As New Persona
        Dim persona_2 As New Persona
        Dim persona_3 As New Persona("Ruiz Diaz", "Carmen", 34567423)

        persona_1.Nombre = "Diego"
        persona_1.Apellido = "Rodriguez"
        persona_1.Documento = 23456765
        'fuera del rango permitido
        persona_2.Nombre = ""
        persona_2.Apellido = "RodriguezRodriguezRodriguezRodriguez"
        persona_2.Documento = 23456765

        Console.WriteLine("Nombre: " & persona_1.Nombre)
        Console.WriteLine("Apellido: " & persona_1.Apellido)
        Console.WriteLine("Documento: " & persona_1.Documento & vbCrLf)

        Console.WriteLine("Nombre2: " & persona_2.Nombre)
        Console.WriteLine("Apellido2: " & persona_2.Apellido)
        Console.WriteLine("Documento2: " & persona_2.Documento & vbCrLf)
        'sobrecarga
        Console.WriteLine("Nombre3: " & persona_3.Nombre)
        Console.WriteLine("Apellido3: " & persona_3.Apellido)
        Console.WriteLine("Documento3: " & persona_3.Documento & vbCrLf)

        Console.ReadKey()
    End Sub
End Module

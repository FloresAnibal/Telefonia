Imports TelefoniaEntidades

Module PlanTest
    Sub main()

        'Dim plan_1 As New Plan
        'Dim plan_2 As New Plan(680, "Plan Intermedio", 480)
        'Dim plan_3 As New Plan

        'plan_1.Nombre = "Plan Basico"
        'plan_1.Precio = 375.63
        'plan_1.Credito = 500

        'MostrarDatosCargados(plan_1)

        'MostrarPrueba(plan_1, 130)
        'MostrarPrueba(plan_1, 150)
        'MostrarPrueba(plan_1, 200)
        'MostrarPrueba(plan_1, 50)

        'MostrarDatosCargados(plan_2)

        'MostrarPrueba(plan_2, 130)
        'MostrarPrueba(plan_2, 150)
        'MostrarPrueba(plan_2, 200)
        'MostrarPrueba(plan_2, 50)
        'MostrarPrueba(plan_2, 160)
        ''probando cadena vacia para el campo Nombre
        'plan_3.Nombre = ""
        'MostrarDatosCargados(plan_3)

        Console.ReadKey()

    End Sub

    Private Sub MostrarDatosCargados(objeto As Plan)
        Console.WriteLine("Nombre del Plan: " & objeto.Nombre)
        Console.WriteLine("Precio del Plan: " & objeto.Precio)
        Console.WriteLine("Credito del Plan: " & objeto.Credito)
        Console.WriteLine("Credito Disponible en el Plan: " & objeto.disponible & vbCrLf)
    End Sub

    Private Sub MostrarPrueba(objeto As Plan, valor As UInt32)
        objeto.addConsumo(valor)
        Console.WriteLine("Consumo: " & valor)
        Console.WriteLine("Credito Disponible en el Plan: " & objeto.disponible & vbCrLf)
    End Sub
End Module



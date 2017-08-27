Imports TelefoniaEntidades

Module EquipoTest

    Sub Main()
        Dim equipo_1 As New Equipo
        Dim equipo_2 As New Equipo
        Dim equipo_3 As New Equipo("Motorola", "XT 1032", "G")

        equipo_1.Marca = "Huawei"
        equipo_1.Modelo = "Honor"
        equipo_1.Serie = "5X"
        equipo_1.Vender(Today)
        'exediendo rango permitido
        equipo_2.Marca = "HuaweiHuaweiHuaweiHuaweiHuaweiHuawei"
        equipo_2.Modelo = "HonorHonorHonorHonorHonorHonorHonorHonorHonorHonorHonorHonor"
        equipo_2.Serie = "5X5X5X5X5X5X5X5X"

        Console.WriteLine("Nombre de equipo: " & equipo_1.Marca)
        Console.WriteLine("Modelo de equipo: " & equipo_1.Modelo)
        Console.WriteLine("Serie de equipo: " & equipo_1.Serie)
        Console.WriteLine("Fecha de venta de equipo: " & equipo_1.FechaVenta & vbCrLf)
        'exediendo rango permitido
        Console.WriteLine("Nombre de equipo2: " & equipo_2.Marca)
        Console.WriteLine("Modelo de equipo2: " & equipo_2.Modelo)
        Console.WriteLine("Serie de equipo2: " & equipo_2.Serie)
        Console.WriteLine("Fecha de venta de equipo2: " & equipo_2.FechaVenta & vbCrLf)
        'sobrecarga
        Console.WriteLine("Nombre de equipo3: " & equipo_3.Marca)
        Console.WriteLine("Modelo de equipo3: " & equipo_3.Modelo)
        Console.WriteLine("Serie de equipo3: " & equipo_3.Serie)
        equipo_3.Vender(#09-08-2014#)
        Console.WriteLine("Fecha de venta de equipo3: " & equipo_3.FechaVenta & vbCrLf)

        Console.ReadKey()
    End Sub

End Module

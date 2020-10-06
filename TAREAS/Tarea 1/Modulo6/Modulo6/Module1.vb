Imports Modulo6_Biblioteca
Module Module1

    Sub Main()
        'Modulo6_Biblioteca.Herramientas
        'Dim Rutina = New Herramientas
        'Rutina.MiRutina()
        'Console.Write(Rutina.NombreCompleto)

        Dim DatosUsuario As New Usuario
        'Obtener un dato por medio del teclado
        Console.Write("Ingresa el nombre de usuario: ")
        DatosUsuario.Nombre = Console.ReadLine()

        Console.Write("Ingresa el correo: ")
        DatosUsuario.Correo = Console.ReadLine()

        Console.Write("Ingresa la contraseña: ")
        DatosUsuario.Contraseña = Console.ReadLine()
        'Length obtiene el numero de carecteres de un string
        If DatosUsuario.Contraseña.Length < 8 Then
            Console.WriteLine("La contraseña no puede tener menos de 8 caracteres")
        Else
            If DatosUsuario.Contraseña = DatosUsuario.Password Then
                Console.WriteLine("Acceso exitoso")
                'Obtener un dato y mostrarlo en consola
                Console.WriteLine("El usuario es: " & DatosUsuario.Nombre)
                'Obtener un dato y mostrarlo en consola
                Console.WriteLine("El usuario es: " & DatosUsuario.Correo)
                'Obtener un dato y mostrarlo en consola
                Console.WriteLine("El usuario es: " & DatosUsuario.Contraseña)
            Else
                Console.WriteLine("Acceso no valido")
            End If
        End If



        Console.ReadKey()
    End Sub

End Module

Imports MODULO6_BIBLIOTECA
Module Module1

    Sub Main()
        'Dim Rutina = New MODULO6_BIBLIOTECA.Herramientas
        'Rutina.MiRutina()
        'Console.Write(Rutina.NombreCompleto)
        'Console.ReadKey()

        Dim DatosUsuario As New Usuario
        'Obtener un Dato por medio del teclado
        Console.WriteLine("Ingresa el nombre de usuario: ")
        DatosUsuario.Nombre = Console.ReadLine()
        'Obtener un Dato y mostrarlo en consola

        If DatosUsuario.Nombre.Length < 5 Or DatosUsuario.Nombre.Length > 50 Then
            Console.WriteLine("El nombre no puede tener menos de 5 caracteres o más de 50 caracteres")
            Console.ReadKey()

        Else
            Console.WriteLine("Apellido paterno: ")
            DatosUsuario.ApellidoPaterno = Console.ReadLine()


            If DatosUsuario.ApellidoPaterno.Length < 5 Or DatosUsuario.ApellidoPaterno.Length > 50 Then
                Console.WriteLine("El apellido paterno no puede tener menos de 5 caracteres o más de 50 caracteres")
                Console.ReadKey()

            Else





                Console.WriteLine("Apellido materno: ")
                DatosUsuario.ApellidoMaterno = Console.ReadLine()

                If DatosUsuario.ApellidoMaterno.Length < 5 Or DatosUsuario.ApellidoMaterno.Length > 50 Then
                    Console.WriteLine("El apellido materno no puede tener menos de 5 caracteres o más de 50 caracteres")
                    Console.ReadKey()

                Else



                    Console.WriteLine("Ingresa el correo: ")
                    DatosUsuario.Correo = Console.ReadLine()



                    If DatosUsuario.Correo.Length < 10 Or DatosUsuario.Correo.Length > 50 Then
                        Console.WriteLine("El correo no puede tener menos de 10 caracteres o más de 50 caracteres")
                        Console.ReadKey()




                    Else



                        Console.WriteLine("Ingresa la contraseña: ")
                        DatosUsuario.Contraseña = Console.ReadLine()





                        'Length obtiene el número de caracteres de un string
                        If DatosUsuario.Contraseña.Length < 8 Then
                            Console.WriteLine("La contraseña no puede tener menos de 8 caracteres")
                            Console.ReadKey()



                        Else
                            If DatosUsuario.Contraseña = DatosUsuario.Password Then
                                Console.WriteLine("Acceso exitoso")
                                'Obtener un Dato y mostrarlo en consola
                                Console.WriteLine("Bienvenido: " & DatosUsuario.Nombre & " " & DatosUsuario.ApellidoPaterno & " " & DatosUsuario.ApellidoMaterno)
                                'Obtener un dato y mostrarlo en consola



                                Console.WriteLine("El usuario es: " & DatosUsuario.Nombre)
                                'Obtener un dato y mostrarlo en consola
                                Console.WriteLine("Apellido paterno: " & DatosUsuario.ApellidoPaterno)
                                'Obtener un dato y mostrarlo en consola
                                Console.WriteLine("Apellido materno: " & DatosUsuario.ApellidoMaterno)
                                'Obtener un dato y mostrarlo en consola



                                Console.WriteLine("El correo es: " & DatosUsuario.Correo)
                                'Obtener un dato y mostrarlo en consola


                                Console.WriteLine("La contraseña es: " & DatosUsuario.Contraseña)
                                Console.ReadKey()


                            Else
                                Console.WriteLine("Acceso no Válido")
                                Console.ReadKey()
                            End If

                        End If
                        If DatosUsuario.Contraseña = DatosUsuario.Password Then
                            Console.WriteLine()
                        End If



                    End If
                End If
            End If
        End If
    End Sub

End Module

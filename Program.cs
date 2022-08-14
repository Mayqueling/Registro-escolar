using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEscuela;

namespace RegistroCalificaciones
{
    class Program
    {
        public static int Grado;
        public static int BuscarGrado;
        static EstudianteRegistrado Logueado;
        static EstudianteRegistrado EstudianteLogueado;


        static void Main(string[] args)
        {
            BaseDatos.EstudiantesRegistrados = new List<EstudianteRegistrado>(); //inicializo la lista de Usuarios
    
            Inicio();
        }

        public static void Inicio()
        {
            int[] CodigosEst = new int[100];
            int NClases, CodigoEst;
            string CodiEntrada = "";
            bool logueado;
            bool LogueadoEs;
            string entrada = "";
            int respuesta, i = 0;

            do
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("          ╔════════════════════════╗");
                    Console.WriteLine("                    M E N U      ");
                    Console.WriteLine("          ╚════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("   1.-Registrar Nuevo Estudiante ");
                    Console.WriteLine("   2.-Registrar Calificaciones ");
                    Console.WriteLine("   3.-Visualizar información ");
                    Console.WriteLine("   4.-Salir ");


                    Console.WriteLine("   Elige su opción: ");
                    entrada = Console.ReadLine();
                    respuesta = Convert.ToInt32(entrada);

                    if (respuesta <= 0 || respuesta > 5)
                    {
                        Console.WriteLine("Error. Dato incorecto... ");
                    }
                } while (respuesta <= 0 || respuesta > 5);

                switch (respuesta)
                {
                    case 1:
                        {
                            // try
                            //{
                            
                            Estudiante Estudiante = new Estudiante();
                            Calificacion Calificacion = new Calificacion();
                            EstudianteRegistrado EstudianteRegistrado = new EstudianteRegistrado();

                            Calificacion.CodigoEst = Guid.NewGuid();
                            Estudiante.CodigoEst = Guid.NewGuid();
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("          ╔═════════════════════════════════╗");
                            Console.WriteLine("              Registrando Nuevo Estudiante      ");
                            Console.WriteLine("          ╚═════════════════════════════════╝");
                            Console.WriteLine();

                            // Valida que el código estudiantíl sea unico
                                 int Auxi = 0;
                                do
                                {
                                    Console.Write("Código Estudiantíl:");
                                    CodiEntrada = Console.ReadLine();
                                    CodigoEst = Convert.ToInt32(CodiEntrada);
                                    
                                    if (CodigoEst > 900 || CodigoEst < 100)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Error. El código Estudiantil es invalido... ");
                                        Console.WriteLine();
                                        Console.WriteLine("..::Los Códigos Estudiantiles se Conforman por sifras de tres::..");

                                        for (int j = 1; j < 100; j++)
                                        {

                                            if (CodigosEst[j] == CodigoEst)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Error...");
                                                Console.WriteLine("..::El codigo ingresado Pertenece a otro estudiante::..");
                                                Auxi = Auxi + 1;
                                            }

                                        }
                                    }
                                    Console.WriteLine("..::El codigo ingresado Pertenece a otro estudiante::..");       

                                } while (CodigoEst > 999 || CodigoEst < 100 || CodigosEst[Auxi] == CodigoEst);
                                

                            CodigosEst[i] = Convert.ToInt32(CodiEntrada);
                            EstudianteRegistrado.CodigoEst = CodiEntrada;
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("          ╔═════════════════════════════════╗");
                            Console.WriteLine("              Registrando Nuevo Estudiante      ");
                            Console.WriteLine("          ╚═════════════════════════════════╝");
                            Console.WriteLine();
                            Console.Write("Nombres del Estudiante:");
                            EstudianteRegistrado.NombreEstudiante = Console.ReadLine();

                            Console.WriteLine();
                            Console.Write("Apellidos del Estudiante:");
                            EstudianteRegistrado.Apellidos = Console.ReadLine();

                            Console.WriteLine();
                            Console.Write("Fecha de Nacimiento:");
                            EstudianteRegistrado.FechaN = Console.ReadLine();

                            do
                            {
                                Console.WriteLine();
                                Console.Write("Grado Cursando:");
                                entrada = Console.ReadLine();
                                NClases = Convert.ToInt32(entrada);
                                
                                if (NClases > 6 || NClases <= 0 )
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Error. Dato invalido... ");
                                    Console.WriteLine();
                                    Console.WriteLine("..::Los Grados Estudiantiles Disponibles Son de 1ro a 6to ::..");
                                }
                            } while (NClases > 6 || NClases <= 0);

                            EstudianteRegistrado.GradoCur = entrada;
                             

                           // Console.Clear();
                            switch (NClases)
                            {
                                case 1:
                                    {
                                        Grado1();
                                    }
                                    break;

                                case 2:
                                    {
                                        Grado2();
                                    }
                                    break;

                                case 3:
                                    {
                                        Grado3();
                                    }
                                    break;

                                case 4:
                                    {
                                        Grado4();
                                    }
                                    break;

                                case 5:
                                    {
                                        Grado5();
                                    }
                                    break;

                                case 6:
                                    {
                                        Grado6();
                                    }
                                    break;
                            }

                            EstudianteRegistrado.Estudiante = Estudiante;
                            EstudianteRegistrado.registrar();
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("          ╔═════════════════════════════════╗");
                            Console.WriteLine("              Registrando Nuevo Estudiante      ");
                            Console.WriteLine("          ╚═════════════════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("[El/La estudiante {0} ha sido registrado satisfactoriamente] ", EstudianteRegistrado.NombreEstudiante);
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine();

                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("          ╔═════════════════════════════╗");
                            Console.WriteLine("             Registro de Calificaciones      ");
                            Console.WriteLine("          ╚═════════════════════════════╝");
                            Console.WriteLine();
                            BaseDatos.ListaTodosLosEstuidantes();
                            Console.ReadKey();
                             logueado = Login();

                             if (logueado)
                             {
                                 EstudianteEdicionNota();
                             }
                             else
                             {
                                 Console.WriteLine("Error. El Nombre o contraseña del estudiante es invalido.");
                             }
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            int Opcion;
                            Console.WriteLine();
                            Console.WriteLine("          ╔═══════════════════════════════════════════╗");
                            Console.WriteLine("              Visualización de información Estudianí      ");
                            Console.WriteLine("          ╚═══════════════════════════════════════════╝");
                            Console.WriteLine();
                            Console.WriteLine("   1.-Calificación por Listado de Grado");
                            Console.WriteLine("   2.-Calificación por Estudiante");
                            Console.WriteLine();
                            Opcion = int.Parse(Console.ReadLine());

                            switch(Opcion)
                            {
                                case 1:
                                    {
                                    
                                        LogueadoEs = LoginEstudiantes();
                                        if (LogueadoEs)
                                        {
                                            BaseDatos.EstudiantesClasesN();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Grado invalido");
                                            Console.ReadKey();
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        logueado = Login();

                                        if (logueado)
                                        {
                                            Console.Clear();
                                            Console.WriteLine();
                                            Console.WriteLine("          ╔══════════════════════════╗");
                                            Console.WriteLine("               Registro Estudiantíl      ");
                                            Console.WriteLine("          ╚══════════════════════════╝");
                                            Console.WriteLine();
                                            Console.WriteLine("Nombre de Estudiante " + Logueado.NombreEstudiante);
                                            Console.WriteLine("Apellidos " + Logueado.Apellidos);

                                            //Poner Detalles de Calificació
                                        }
                                        else
                                        {
                                            Console.WriteLine("Estudiante o Codigo estudiantil invalidos");
                                            Console.ReadKey();
                                        }
                                    }
                                    break;


                            }

                            Console.ReadKey();
                        }
                        break;
                }

                i = i + 1;
                do
                {
                  
                    Console.WriteLine("  ¿Desea salir?");
                    Console.WriteLine("   [Sí]- 1   [No]- 2");
                    entrada = Console.ReadLine();
                    respuesta = Convert.ToInt32(entrada);

                    if (respuesta <= 0 || respuesta > 2)
                    {
                        Console.WriteLine("Error. Dato incorecto... ");
                    }
                } while (respuesta <= 0 || respuesta > 2);
            } while (respuesta <=3);
       
        }


        static bool Login()
        {
            EstudianteRegistrado EstudianteRegistrado = new EstudianteRegistrado();
            string entradaGrado;
            string NombreEstudiante, CodigoEst;

            Console.Clear();


            Console.Write("Estudiante: ");
            NombreEstudiante = Console.ReadLine();

            Console.Write("Codigo Estudiantil: ");
            CodigoEst = Console.ReadLine();

            EstudianteRegistrado = EstudianteRegistrado.login(NombreEstudiante, CodigoEst);

            if (EstudianteRegistrado == null)
            {
                return false;
            }
            else
            {
                Logueado = EstudianteRegistrado;
                entradaGrado = EstudianteRegistrado.GradoCur;
                Grado = Convert.ToInt32(entradaGrado);
                
                return true;
            }

        }


        //Valida que el estudiante y el codigo estudiantil Coincidan
              static bool LoginEstudiantes()
        {
            EstudianteRegistrado EstudianteRegistrado = new EstudianteRegistrado();


            string GradoCur;
           
            Console.Clear();


            Console.Write("Digite el grado de la lista de clase que desa visualizar: ");
            GradoCur = Console.ReadLine();
            BuscarGrado = Convert.ToInt32(GradoCur);

            
            EstudianteRegistrado = EstudianteRegistrado.loginEstudiantes(GradoCur);

            if (EstudianteRegistrado == null)
            {
                return false;
            }
            else
            {
                EstudianteLogueado = EstudianteRegistrado;
                return true;
            }

        }

              public static void Grado1()
              {
                  Console.WriteLine();
                  Console.WriteLine("          ╔═══════════════════════════════════╗");
                  Console.WriteLine("              Clases Ofertadas para 1er grado      ");
                  Console.WriteLine("          ╚═══════════════════════════════════╝");
                  Console.WriteLine();
                  Console.WriteLine("   1.-Español");
                  Console.WriteLine("   2.-Matemáticas ");
                  Console.WriteLine("   3.-Artes plasticas");
                  Console.WriteLine();
                  Console.WriteLine("..::Precione Intro para registrar al estudiante::..");
                  Console.ReadKey();
                  
              }

              public static void Grado2()
              {
                  Console.WriteLine();
                  Console.WriteLine("          ╔═══════════════════════════════════╗");
                  Console.WriteLine("              Clases Ofertadas para 2do grado      ");
                  Console.WriteLine("          ╚═══════════════════════════════════╝");
                  Console.WriteLine();
                  Console.WriteLine("   1.-Español");
                  Console.WriteLine("   2.-Matemáticas ");
                  Console.WriteLine("   3.-Estudios Sociales");
                  Console.WriteLine("   4.-Educació Física");
                  Console.WriteLine();
                  Console.WriteLine("..::Precione Intro para registrar al estudiante::..");
                  Console.ReadKey();
              }

              public static void Grado3()
              {
                  Console.WriteLine();
                  Console.WriteLine("          ╔═══════════════════════════════════╗");
                  Console.WriteLine("             Clases Ofertadas para 3ro grado      ");
                  Console.WriteLine("          ╚═══════════════════════════════════╝");
                  Console.WriteLine();
                  Console.WriteLine("   1.-Español");
                  Console.WriteLine("   2.-Matemáticas ");
                  Console.WriteLine("   3.-Estudios Sociales");
                  Console.WriteLine("   4.-Educació Física");
                  Console.WriteLine("   5.-A.E.P");
                  Console.WriteLine();
                  Console.WriteLine("..::Precione Intro para registrar al estudiante::..");
                  Console.ReadKey();
              }

              public static void Grado4()
              {
                  Console.WriteLine();
                  Console.WriteLine("          ╔═══════════════════════════════════╗");
                  Console.WriteLine("             Clases Ofertadas para 4to grado      ");
                  Console.WriteLine("          ╚═══════════════════════════════════╝");
                  Console.WriteLine();
                  Console.WriteLine("   1.-Lengua y Literatura");
                  Console.WriteLine("   2.-Matemáticas ");
                  Console.WriteLine("   3.-Estudios Sociales");
                  Console.WriteLine("   4.-Educació Física");
                  Console.WriteLine("   5.-A.E.P");
                  Console.WriteLine("   6.-E.C.A");
                  Console.WriteLine("   7.-Ciencias Naturales");
                  Console.WriteLine();
                  Console.WriteLine("..::Precione Intro para registrar al estudiante::..");
                  Console.ReadKey();
              }

              public static void Grado5()
              {
                  Console.WriteLine();
                  Console.WriteLine("          ╔═══════════════════════════════════╗");
                  Console.WriteLine("             Clases Ofertadas para 5to grado      ");
                  Console.WriteLine("          ╚═══════════════════════════════════╝");
                  Console.WriteLine();
                  Console.WriteLine("   1.-Lengua y Literatura");
                  Console.WriteLine("   2.-Matemáticas ");
                  Console.WriteLine("   3.-Estudios Sociales");
                  Console.WriteLine("   4.-Educació Física");
                  Console.WriteLine("   5.-A.E.P");
                  Console.WriteLine("   6.-E.C.A");
                  Console.WriteLine("   7.-Ciencias Naturales");
                  Console.WriteLine("   8.-Geografíá");
                  Console.WriteLine();
                  Console.WriteLine("..::Precione Intro para registrar al estudiante::..");
                  Console.ReadKey();
              }

              public static void Grado6()
              {
                  Console.WriteLine();
                  Console.WriteLine("          ╔═══════════════════════════════════╗");
                  Console.WriteLine("             Clases Ofertadas para 6to grado      ");
                  Console.WriteLine("          ╚═══════════════════════════════════╝");
                  Console.WriteLine();
                  Console.WriteLine("   1.-Lengua y Literatura");
                  Console.WriteLine("   2.-Aritmetica ");
                  Console.WriteLine("   3.-Estudios Sociales");
                  Console.WriteLine("   4.-Educació Física");
                  Console.WriteLine("   5.-A.E.P");
                  Console.WriteLine("   6.-E.C.A");
                  Console.WriteLine("   7.-Ciencias Naturales");
                  Console.WriteLine("   8.-Geografíá");
                  Console.WriteLine();
                  Console.WriteLine("..::Precione Intro para registrar al estudiante::..");
                  Console.ReadKey();
              }

              public static void EstudianteEdicionNota()
              {
                  switch (Grado)
                   {
                                     case 1:
                                         {
                                             Console.WriteLine("╔════════════╦═══════════════════════════════════════════════╗");
                                             Console.WriteLine("║  Nombre:   ║" + Logueado.NombreEstudiante);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║  Apellidos:║" + Logueado.Apellidos);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║   Grado:   ║" + Logueado.GradoCur);
                                             Console.WriteLine("╠════════════╩═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║                      [Clases Cursando]                     ║");
                                             Console.WriteLine("║                                                            ║");
                                             Console.WriteLine("║      1.-Español                                            ║");
                                             Console.WriteLine("║      2.-Matemáticas                                        ║");
                                             Console.WriteLine("║      3.-Artes plasticas                                    ║");
                                             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
                                             Console.WriteLine();
                                         }
                                         break;

                                     case 2:
                                         {
                                             Console.WriteLine("╔════════════╦═══════════════════════════════════════════════╗");
                                             Console.WriteLine("║  Nombre:   ║" + Logueado.NombreEstudiante);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║  Apellidos:║" + Logueado.Apellidos);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║   Grado:   ║" + Logueado.GradoCur);
                                             Console.WriteLine("╠════════════╩═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║                      [Clases Cursando]                     ║");
                                             Console.WriteLine("║                                                            ║");
                                             Console.WriteLine("║      1.-Español                                            ║");
                                             Console.WriteLine("║      2.-Matemáticas                                        ║");
                                             Console.WriteLine("║      3.-Estudios Sociales                                  ║");
                                             Console.WriteLine("║      4.-Educació Física                                    ║");
                                             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
                                             Console.WriteLine();
                                         }
                                         break;

                                     case 3:
                                         {
                                             Console.WriteLine("╔════════════╦═══════════════════════════════════════════════╗");
                                             Console.WriteLine("║  Nombre:   ║" + Logueado.NombreEstudiante);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║  Apellidos:║" + Logueado.Apellidos);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║   Grado:   ║" + Logueado.GradoCur);
                                             Console.WriteLine("╠════════════╩═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║                      [Clases Cursando]                     ║");
                                             Console.WriteLine("║                                                            ║");
                                             Console.WriteLine("║      1.-Español                                            ║");
                                             Console.WriteLine("║      2.-Matemáticas                                        ║");
                                             Console.WriteLine("║      3.-Estudios Sociales                                  ║");
                                             Console.WriteLine("║      4.-Educació Física                                    ║");
                                             Console.WriteLine("║      5.-A.E.P                                              ║");
                                             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
                                             Console.WriteLine();
                                         }
                                         break;

                                     case 4:
                                         {
                                             Console.WriteLine("╔════════════╦═══════════════════════════════════════════════╗");
                                             Console.WriteLine("║  Nombre:   ║" + Logueado.NombreEstudiante);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║  Apellidos:║" + Logueado.Apellidos);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║   Grado:   ║" + Logueado.GradoCur);
                                             Console.WriteLine("╠════════════╩═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║                      [Clases Cursando]                     ║");
                                             Console.WriteLine("║                                                            ║");
                                             Console.WriteLine("║      1.-Español                                            ║");
                                             Console.WriteLine("║      2.-Matemáticas                                        ║");
                                             Console.WriteLine("║      3.-Estudios Sociales                                  ║");
                                             Console.WriteLine("║      4.-Educació Física                                    ║");
                                             Console.WriteLine("║      5.-A.E.P                                              ║");
                                             Console.WriteLine("║      6.-E.C.A                                              ║");
                                             Console.WriteLine("║      7.-Ciencias Naturales                                 ║");
                                             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
                                             Console.WriteLine();
                                         }
                                         break;

                                     case 5:
                                         {
                                             Console.WriteLine("╔════════════╦═══════════════════════════════════════════════╗");
                                             Console.WriteLine("║  Nombre:   ║" + Logueado.NombreEstudiante);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║  Apellidos:║" + Logueado.Apellidos);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║   Grado:   ║" + Logueado.GradoCur);
                                             Console.WriteLine("╠════════════╩═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║                      [Clases Cursando]                     ║");
                                             Console.WriteLine("║                                                            ║");
                                             Console.WriteLine("║      1.-Español                                            ║");
                                             Console.WriteLine("║      2.-Matemáticas                                        ║");
                                             Console.WriteLine("║      3.-Estudios Sociales                                  ║");
                                             Console.WriteLine("║      4.-Educació Física                                    ║");
                                             Console.WriteLine("║      5.-A.E.P                                              ║");
                                             Console.WriteLine("║      6.-E.C.A                                              ║");
                                             Console.WriteLine("║      7.-Ciencias Naturales                                 ║");
                                             Console.WriteLine("║      8.-Geografia                                          ║");
                                             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
                                             Console.WriteLine();
                                         }
                                         break;

                                     case 6:
                                         {
                                             Console.WriteLine("╔════════════╦═══════════════════════════════════════════════╗");
                                             Console.WriteLine("║  Nombre:   ║" + Logueado.NombreEstudiante);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║  Apellidos:║" + Logueado.Apellidos);
                                             Console.WriteLine("╠════════════╬═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║   Grado:   ║" + Logueado.GradoCur);
                                             Console.WriteLine("╠════════════╩═══════════════════════════════════════════════╣");
                                             Console.WriteLine("║                      [Clases Cursando]                     ║");
                                             Console.WriteLine("║                                                            ║");
                                             Console.WriteLine("║      1.-Español                                            ║");
                                             Console.WriteLine("║      2.-Aritmetica                                         ║");
                                             Console.WriteLine("║      3.-Estudios Sociales                                  ║");
                                             Console.WriteLine("║      4.-Educació Física                                    ║");
                                             Console.WriteLine("║      5.-A.E.P                                              ║");
                                             Console.WriteLine("║      6.-E.C.A                                              ║");
                                             Console.WriteLine("║      7.-Ciencias Naturales                                 ║");
                                             Console.WriteLine("║      8.-Geografia                                          ║");
                                             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
                                             Console.WriteLine();
                                         }
                                         break;
                                 
                             }
              }
    }
}


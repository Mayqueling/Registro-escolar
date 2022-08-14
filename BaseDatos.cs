using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEscuela
{
    using RegistroCalificaciones;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

     static class BaseDatos
    {
        public static List<EstudianteRegistrado> EstudiantesRegistrados { get; set; }
        public static List<Calificacion> Calificaciones  { get; set; }

        
        public static void EstudiantesClasesN()
        {
            int BuscaGrado;
            string GradoCur;
            BuscaGrado = Program.BuscarGrado;

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("          ╔══════════════════════════╗");
            Console.WriteLine("               Registro Estudiantíl      ");
            Console.WriteLine("          ╚══════════════════════════╝");
            Console.WriteLine();

            switch (BuscaGrado)
            {
                case 1:
                    {
                        Console.WriteLine("╔═════════════════════╦══════════════════════╦═══════════╦═══════════════╦═════════════════╗");
                        Console.WriteLine("║     Nombres         ║      Apellidos       ║  Español  ║  Matemáticas  ║ Artes plasticas ║ ");
                        Console.WriteLine("╚═════════════════════╩══════════════════════╩═══════════╩═══════════════╩═════════════════╝");
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("╔═════════════════════╦══════════════════════╦═════════╦═════════════╦═══════════════════╦═════════════════╗");
                        Console.WriteLine("║     Nombres         ║      Apellidos       ║ Español ║ Matemáticas ║ Estudios Sociales ║ Educació Física ║ ");
                        Console.WriteLine("╚═════════════════════╩══════════════════════╩═════════╩═════════════╩═══════════════════╩═════════════════╝");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("╔═════════════════════╦══════════════════════╦═════════╦═════════════╦═══════════════════╦═════════════════╦═══════╗");
                        Console.WriteLine("║     Nombres         ║      Apellidos       ║ Español ║ Matemáticas ║ Estudios Sociales ║ Educació Física ║ A.E.P ║ ");
                        Console.WriteLine("╚═════════════════════╩══════════════════════╩═════════╩═════════════╩═══════════════════╩═════════════════╩═══════╝");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("╔═════════════════════╦══════════════════════╦═════════╦═════════════╦═══════════════════╦═════════════════╦═══════╦═══════╦════════════════════╗");
                        Console.WriteLine("║     Nombres         ║      Apellidos       ║ Español ║ Matemáticas ║ Estudios Sociales ║ Educació Física ║ A.E.P ║ E.C.A ║ Ciencias Naturales ║");
                        Console.WriteLine("╚═════════════════════╩══════════════════════╩═════════╩═════════════╩═══════════════════╩═════════════════╩═══════╩═══════╩════════════════════╝");
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("╔═════════════════════╦══════════════════════╦═════════╦═════════════╦═══════════════════╦═════════════════╦═══════╦═══════╦════════════════════╦═══════════╗");
                        Console.WriteLine("║     Nombres         ║      Apellidos       ║ Español ║ Matemáticas ║ Estudios Sociales ║ Educació Física ║ A.E.P ║ E.C.A ║ Ciencias Naturales ║ Geografia ║");
                        Console.WriteLine("╚═════════════════════╩══════════════════════╩═════════╩═════════════╩═══════════════════╩═════════════════╩═══════╩═══════╩════════════════════╩═══════════╝");
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine("╔═════════════════════╦══════════════════════╦═════════╦════════════╦═══════════════════╦═════════════════╦═══════╦═══════╦════════════════════╦═══════════╗");
                        Console.WriteLine("║     Nombres         ║      Apellidos       ║ Español ║ Aritmetica ║ Estudios Sociales ║ Educació Física ║ A.E.P ║ E.C.A ║ Ciencias Naturales ║ Geografia ║");
                        Console.WriteLine("╚═════════════════════╩══════════════════════╩═════════╩════════════╩═══════════════════╩═════════════════╩═══════╩═══════╩════════════════════╩═══════════╝");
                    }
                    break;
            }

            GradoCur = Convert.ToString(BuscaGrado);
            foreach (var EstudianteRegistrado in BaseDatos.EstudiantesRegistrados)
            {
                //EstudianteRegistrado.GradoCur;

                if (BuscaGrado == 1)
                {
                   
                    if (EstudianteRegistrado.GradoCur == GradoCur)
                    {             
                        Console.WriteLine(" {0}  -       {1}                  ",  EstudianteRegistrado.NombreEstudiante, EstudianteRegistrado.Apellidos);
                    
                        //Falta agregar al mandar a llamara las notas

                    }
                }
                else if (BuscaGrado == 2)
                {
                    //GradoCur = Convert.ToString(BuscaGrado);
                    if (EstudianteRegistrado.GradoCur == GradoCur)
                    {
                        Console.WriteLine(" {0}  -       {1}                  ", EstudianteRegistrado.NombreEstudiante, EstudianteRegistrado.Apellidos);
                        
                    }
                }
                else if (BuscaGrado == 3)
                {
                   // GradoCur = Convert.ToString(BuscaGrado);
                    if (EstudianteRegistrado.GradoCur == GradoCur)
                    {
                        Console.WriteLine(" {0}  -       {1}                  ", EstudianteRegistrado.NombreEstudiante, EstudianteRegistrado.Apellidos);
                    }
                }
                else if (BuscaGrado == 4)
                {
                    //GradoCur = Convert.ToString(BuscaGrado);
                    if (EstudianteRegistrado.GradoCur == GradoCur)
                    {
                        Console.WriteLine(" {0}  -       {1}                  ", EstudianteRegistrado.NombreEstudiante, EstudianteRegistrado.Apellidos);                        
                    }
                }
                else if (BuscaGrado == 5)
                {
                    //GradoCur = Convert.ToString(BuscaGrado);
                    if (EstudianteRegistrado.GradoCur == GradoCur)
                    {
                        Console.WriteLine(" {0}  -       {1}                  ", EstudianteRegistrado.NombreEstudiante, EstudianteRegistrado.Apellidos);
                    }
                    Program.Grado5();
                }
                else if (BuscaGrado == 6)
                {
                    //GradoCur = Convert.ToString(BuscaGrado);
                    if (EstudianteRegistrado.GradoCur == GradoCur)
                    {
                        Console.WriteLine(" {0}  -       {1}                  ", EstudianteRegistrado.NombreEstudiante, EstudianteRegistrado.Apellidos);                        
                    }
                }    
            }
        }

         //Función para visualizar a todos los estudiantes
            public static void ListaTodosLosEstuidantes()
           {
               Console.WriteLine("╔═════════════════════╦══════════════════════╦═══════════╦═════════════╗");
               Console.WriteLine("║     Nombres         ║      Apellidos       ║  Grado    ║ Código.Est  ║  ");
               Console.WriteLine("╚═════════════════════╩══════════════════════╩═══════════╩═════════════╝");
                    
               foreach (var EstudianteRegistrado in BaseDatos.EstudiantesRegistrados)
               {
                   Console.WriteLine(" {0}  -       {1}  -       {2}  -       {3}", EstudianteRegistrado.NombreEstudiante, EstudianteRegistrado.Apellidos, EstudianteRegistrado.GradoCur, EstudianteRegistrado.CodigoEst);

               }
           }

    }

}

using RegistroCalificaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEscuela
{
    class EstudianteRegistrado
    {
        public string CodigoEst { get; set; }
        public string NombreEstudiante { get; set; }
        public string Apellidos { get; set; }
        public string FechaN { get; set; }
        public string GradoCur { get; set; }
        public Estudiante Estudiante { get; set; }
        public List<Calificacion> Calificacion { get; set; } //Declarando lista de objetos


        public EstudianteRegistrado login(string NombreEstudiante, string CodigoEst)
        {
            foreach (EstudianteRegistrado EstudianteRegistrado in BaseDatos.EstudiantesRegistrados)
            {
                if (EstudianteRegistrado.NombreEstudiante == NombreEstudiante && EstudianteRegistrado.CodigoEst == CodigoEst)
                {

                    return EstudianteRegistrado;
                }
            }

            return null;
        }


        public EstudianteRegistrado loginEstudiantes(string GradoCur)
        {
            int G;
             G = Program.BuscarGrado;
            foreach (EstudianteRegistrado EstudianteRegistrado in BaseDatos.EstudiantesRegistrados)
            {

                GradoCur = Convert.ToString(G);
                if (EstudianteRegistrado.GradoCur == GradoCur)
                {
                    return EstudianteRegistrado;
                }
            }
            return null;
        }


        public EstudianteRegistrado registrar()
        {
            BaseDatos.EstudiantesRegistrados.Add(this);
            return this;
        }
    }
}

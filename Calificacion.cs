using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEscuela
{
    class Calificacion
    {
        public Guid CodigoEst { get; set; }
        public string MateriaCalif1 { get; set; }
        public string MateriaCalif2 { get; set; }
        public string MateriaCalif3 { get; set; }
        public string MateriaCalif4 { get; set; }
        public string MateriaCalif5 { get; set; }
        public string MateriaCalif6 { get; set; }
        public string MateriaCalif7 { get; set; }
        public string MateriaCalif8 { get; set; }


        public void registrarCalificaciones()
        {
            BaseDatos.Calificaciones.Add(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class EstudianteVistaModelo
    {
        public int Id_estudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public Nullable<bool> Estado { get; set; }

        //concatenar Nombre y Apellido
        /*public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }*/

       
    }
}

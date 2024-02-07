using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class HistorialVistaModelo
    {
        public int Id_historial { get; set; }
        public Nullable<System.DateTime> Fecha_reserva { get; set; }
        public Nullable<int> Id_ruta { get; set; }
        public Nullable<int> Id_estudiante { get; set; }

        public string Nombre_estudiante { get; set; }
        public string Nombre_ruta { get; set; }
    }
}

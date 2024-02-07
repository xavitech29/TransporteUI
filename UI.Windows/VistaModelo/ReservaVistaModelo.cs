using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class ReservaVistaModelo
    {
        public int Id_reserva { get; set; }
        public Nullable<int> Id_estudiante { get; set; }
        public Nullable<int> Id_ruta { get; set; }
        public Nullable<System.DateTime> Fecha_reserva { get; set; }
        public Nullable<System.TimeSpan> Hora_reserva { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<int> Id_vehiculo { get; set; }

       
    }
}

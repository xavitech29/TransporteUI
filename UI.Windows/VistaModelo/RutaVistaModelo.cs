using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class RutaVistaModelo
    {
        public int Id_ruta { get; set; }
        public string Nombre_ruta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public Nullable<System.TimeSpan> Hora_salida { get; set; }
        public Nullable<System.TimeSpan> Hora_llegada { get; set; }
        public Nullable<System.DateTime> Fecha_ruta { get; set; }
        public string Capacidad { get; set; }
    }
}

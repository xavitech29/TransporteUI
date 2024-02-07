using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class VehiculoVistaModelo
    {
        public int Id_vehiculo { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Motor { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Chasis { get; set; }
        public int Numero_pasajeros { get; set; }
        public bool Estado { get; set; }
    }
}

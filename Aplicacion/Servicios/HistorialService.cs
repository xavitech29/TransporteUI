using Dominio.Modelo.Abstracciones;
using Dominio.Modelo.Entidades;
using Infraestructura.AccesoDatos.Repositiorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class HistorialService
    {
        readonly IHistorialRepository historialRepository = new HistorialRepository();
       /* public HistorialService()
        {
            historialRepository = new HistorialRepository();
        }*/
        public void InsertarHistorial(Historial nuevo)
        {
            historialRepository.Add(nuevo);
        }

        public void ActualizarHistorial(Historial historial)
        {
            historialRepository.Update(historial);
        }

        public IEnumerable<Historial> ListarHistoriales()
        {
            return historialRepository.GetAll();
        }
        //DELETE PARA FINES EDUCATIVO
        public void EliminarHistorial(int id)
        {
            historialRepository.Delete(id);
        }

        
    }
}

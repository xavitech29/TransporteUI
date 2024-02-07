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
    public class RutaService
    {
        readonly IRutaRepository rutaRepository;
        public RutaService()
        {
            rutaRepository = new RutaRepository();
        }
        public void InsertarRuta(Ruta nueva)
        {
            rutaRepository.Add(nueva);
        }

        public void ActualizarRuta(Ruta ruta)
        {
            rutaRepository.Update(ruta);
        }

        public IEnumerable<Ruta> ListarRutas()
        {
            return rutaRepository.GetAll();
        }

        // DELETE PARA FINES EDUCATIVOS
        public void EliminarRuta(int id)
        {
            rutaRepository.Delete(id);
        }

        public string buscarNombreRuta(int idEstudiante)
        {
            return rutaRepository.buscarNombreRuta(idEstudiante);
        }
    }
}

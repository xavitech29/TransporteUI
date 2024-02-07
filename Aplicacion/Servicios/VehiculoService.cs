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
    public class VehiculoService
    {
        readonly IVehiculoRepository vehiculoRepository;
        public VehiculoService()
        {
            vehiculoRepository = new VehiculoRepository();
        }
        public void InsertarVehiculo(Vehiculo nueva)
        {
            vehiculoRepository.Add(nueva);
        }

        public void ActualizarVehiculo(Vehiculo vehiculo)
        {
            vehiculoRepository.Update(vehiculo);
        }

        public IEnumerable<Vehiculo> ListarVehiculos()
        {
            return vehiculoRepository.GetAll();
        }

        // DELETE PARA FINES EDUCATIVOS
        public void EliminarVehiculo(int id)
        {
            vehiculoRepository.Delete(id);
        }
    }
}

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
    public class ReservaService
    {
        readonly IReservaRepository reservaRepository = new ReservaRepository();
        /*public ReservaService()
        {
            reservaRepository = new ReservaRepository();
        }*/
        public void InsertarReserva(Reserva nuevo)
        {
            reservaRepository.Add(nuevo);
        }

        public void ActualizarReserva(Reserva reserva)
        {
            reservaRepository.Update(reserva);
        }

        public IEnumerable<Reserva> ListarReservas()
        {
            return reservaRepository.GetAll();
        }

        // DELETE PARA FINES EDUCATIVOS
        public void EliminarReserva(int id)
        {
            reservaRepository.Delete(id);
        }
    }
}

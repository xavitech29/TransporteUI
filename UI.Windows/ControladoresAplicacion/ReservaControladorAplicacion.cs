using Aplicacion.Servicios;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.VistaModelo;

namespace UI.Windows.ControladoresAplicacion
{
    public class ReservaControladorAplicacion
    {
        private ReservaService reservaServices;
       
        public ReservaControladorAplicacion()
        {
            reservaServices = new ReservaService();
        }

        public bool InsertarReserva(ReservaVistaModelo nuevoReservaVM)
        {
            Reserva nuevoReservaET = new Reserva();
            try
            {
                nuevoReservaET.id_estudiante = nuevoReservaVM.Id_estudiante;
                nuevoReservaET.id_ruta = nuevoReservaVM.Id_ruta;
                nuevoReservaET.id_vehiculo = nuevoReservaVM.Id_vehiculo;
                nuevoReservaET.fecha_reserva = nuevoReservaVM.Fecha_reserva;
                nuevoReservaET.hora_reserva = nuevoReservaVM.Hora_reserva;
                nuevoReservaET.estado = nuevoReservaVM.Estado;
                
                reservaServices.InsertarReserva(nuevoReservaET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        //Quitar int idReserva
        public bool ActualizarReserva(ReservaVistaModelo nuevoReservaVM)
        {
            Reserva nuevoReservaET = new Reserva();
            try
            {
                nuevoReservaET.id_reserva = nuevoReservaVM.Id_reserva;
                nuevoReservaET.id_estudiante = nuevoReservaVM.Id_estudiante;
                nuevoReservaET.id_ruta = nuevoReservaVM.Id_ruta;
                nuevoReservaET.id_vehiculo = nuevoReservaVM.Id_vehiculo;
                nuevoReservaET.fecha_reserva = nuevoReservaVM.Fecha_reserva;
                nuevoReservaET.hora_reserva = nuevoReservaVM.Hora_reserva;
                nuevoReservaET.estado = nuevoReservaVM.Estado;
                
                reservaServices.ActualizarReserva(nuevoReservaET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<ReservaVistaModelo> ListarReserva()
        {
            List<ReservaVistaModelo> resultadoVistaModelo = new List<ReservaVistaModelo>();
 

            var resultadoBD = reservaServices.ListarReservas();
            try
            {
                foreach (Reserva item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new ReservaVistaModelo
                    {
                        Id_reserva = item.id_reserva,
                        Fecha_reserva = item.fecha_reserva,
                        Hora_reserva = item.hora_reserva,
                        Id_estudiante = item.id_estudiante,
                        Id_ruta = item.id_ruta,
                        Id_vehiculo = item.id_vehiculo,
                        Estado = item.estado,
                        
                    });
                }
                return resultadoVistaModelo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
                return null; 
            }
        }
    }
}

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
    public class RutaControladorAplicacion
    {
        private RutaService rutaServices;

        public RutaControladorAplicacion()
        {
            rutaServices = new RutaService();
        }

        public bool InsertarRuta(RutaVistaModelo nuevoRutaVM)
        {
            Ruta nuevoRutaET = new Ruta();
            try
            {
                nuevoRutaET.nombre_ruta = nuevoRutaVM.Nombre_ruta;
                nuevoRutaET.origen = nuevoRutaVM.Origen;
                nuevoRutaET.destino = nuevoRutaVM.Destino;
                nuevoRutaET.hora_salida = nuevoRutaVM.Hora_salida;
                nuevoRutaET.hora_llegada = nuevoRutaVM.Hora_llegada;
                nuevoRutaET.fecha_ruta = nuevoRutaVM.Fecha_ruta;
                nuevoRutaET.capacidad = nuevoRutaVM.Capacidad;
                rutaServices.InsertarRuta(nuevoRutaET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarRuta(RutaVistaModelo nuevoRutaVM)
        {
            Ruta nuevoRutaET = new Ruta();
            try
            {
                nuevoRutaET.id_ruta = nuevoRutaVM.Id_ruta;
                nuevoRutaET.nombre_ruta = nuevoRutaVM.Nombre_ruta;
                nuevoRutaET.origen = nuevoRutaVM.Origen;
                nuevoRutaET.destino = nuevoRutaVM.Destino;
                nuevoRutaET.hora_salida = nuevoRutaVM.Hora_salida;
                nuevoRutaET.hora_llegada = nuevoRutaVM.Hora_llegada;
                nuevoRutaET.fecha_ruta = nuevoRutaVM.Fecha_ruta;
                nuevoRutaET.capacidad = nuevoRutaVM.Capacidad;
                rutaServices.ActualizarRuta(nuevoRutaET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<RutaVistaModelo> ListarRuta()
        {
            List<RutaVistaModelo> resultadoVistaModelo = new List<RutaVistaModelo>();
            var resultadoBD = rutaServices.ListarRutas();
            try
            {
                foreach (Ruta item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new RutaVistaModelo
                    {
                        Id_ruta = item.id_ruta,
                        Nombre_ruta = item.nombre_ruta,
                        Origen = item.origen,
                        Destino = item.destino,
                        Hora_salida = item.hora_salida,
                        Hora_llegada = item.hora_llegada,
                        Fecha_ruta = item.fecha_ruta,
                        Capacidad = item.capacidad
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

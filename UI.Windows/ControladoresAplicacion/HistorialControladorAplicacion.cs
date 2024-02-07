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
    public class HistorialControladorAplicacion
    {
        private HistorialService historialServices;
        private EstudianteService estudianteServices;
        private RutaService rutaServices;
        public HistorialControladorAplicacion()
        {
            historialServices = new HistorialService();

        }

        public bool InsertarHistorial(HistorialVistaModelo nuevoHistorialVM)
        {
            Historial nuevoHistorialET = new Historial();
            try
            {
                nuevoHistorialET.fecha_reserva = nuevoHistorialVM.Fecha_reserva;
                nuevoHistorialET.id_ruta = nuevoHistorialVM.Id_ruta;
                nuevoHistorialET.id_estudiante = nuevoHistorialVM.Id_estudiante;
                historialServices.InsertarHistorial(nuevoHistorialET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarHistorial(HistorialVistaModelo nuevoHistorialVM)
        {
            Historial nuevoHistorialET = new Historial();
            try
            {
                nuevoHistorialET.id_historial = nuevoHistorialVM.Id_historial;
                nuevoHistorialET.fecha_reserva = nuevoHistorialVM.Fecha_reserva;
                nuevoHistorialET.id_ruta = nuevoHistorialVM.Id_ruta;
                nuevoHistorialET.id_estudiante = nuevoHistorialVM.Id_estudiante;
                historialServices.ActualizarHistorial(nuevoHistorialET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<HistorialVistaModelo> ListarHistorial()
        {
            List<HistorialVistaModelo> resultadoVistaModelo = new List<HistorialVistaModelo>();
            //Para Visualizar nombre estudiante y ruta
            estudianteServices = new EstudianteService();
            rutaServices = new RutaService();

            var resultadoBD = historialServices.ListarHistoriales();
            try
            {
                foreach (Historial item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new HistorialVistaModelo
                    {
                        Id_historial = item.id_historial,
                        Fecha_reserva = item.fecha_reserva,
                        Id_ruta = item.id_ruta,
                        Id_estudiante = item.id_estudiante,
                        Nombre_estudiante = estudianteServices.buscarNombrePorId(item.id_estudiante.Value),
                        Nombre_ruta = rutaServices.buscarNombreRuta(item.id_ruta.Value),

                    });; ;
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

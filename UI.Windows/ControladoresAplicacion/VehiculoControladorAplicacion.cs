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
    public class VehiculoControladorAplicacion
    {
        private VehiculoService vehiculoServices;

        public VehiculoControladorAplicacion()
        {
            vehiculoServices = new VehiculoService();
        }

        public bool InsertarVehiculo(VehiculoVistaModelo nuevoVehiculoVM)
        {
            Vehiculo nuevoVehiculoET = new Vehiculo();
            try
            {
                nuevoVehiculoET.placa = nuevoVehiculoVM.Placa;
                nuevoVehiculoET.marca = nuevoVehiculoVM.Marca;
                nuevoVehiculoET.motor = nuevoVehiculoVM.Motor;
                nuevoVehiculoET.modelo = nuevoVehiculoVM.Modelo;
                nuevoVehiculoET.anio = nuevoVehiculoVM.Anio;
                nuevoVehiculoET.chasis = nuevoVehiculoVM.Chasis;
                nuevoVehiculoET.numero_pasajeros = nuevoVehiculoVM.Numero_pasajeros;
                nuevoVehiculoET.estado = nuevoVehiculoVM.Estado;

                vehiculoServices.InsertarVehiculo(nuevoVehiculoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarVehiculo(VehiculoVistaModelo nuevoVehiculoVM)
        {
            Vehiculo nuevoVehiculoET = new Vehiculo();
            try
            {
                nuevoVehiculoET.id_vehiculo = nuevoVehiculoVM.Id_vehiculo;
                nuevoVehiculoET.placa = nuevoVehiculoVM.Placa;
                nuevoVehiculoET.marca = nuevoVehiculoVM.Marca;
                nuevoVehiculoET.motor = nuevoVehiculoVM.Motor;
                nuevoVehiculoET.modelo = nuevoVehiculoVM.Modelo;
                nuevoVehiculoET.anio = nuevoVehiculoVM.Anio;
                nuevoVehiculoET.chasis = nuevoVehiculoVM.Chasis;
                nuevoVehiculoET.numero_pasajeros = nuevoVehiculoVM.Numero_pasajeros;
                nuevoVehiculoET.estado = nuevoVehiculoVM.Estado;

                vehiculoServices.ActualizarVehiculo(nuevoVehiculoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<VehiculoVistaModelo> ListarVehiculo()
        {
            List<VehiculoVistaModelo> resultadoVistaModelo = new List<VehiculoVistaModelo>();
            var resultadoBD = vehiculoServices.ListarVehiculos();
            try
            {
                foreach (Vehiculo item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new VehiculoVistaModelo
                    {
                        Id_vehiculo = item.id_vehiculo,
                        Placa = item.placa,
                        Marca = item.marca,
                        Motor = item.motor,
                        Modelo = item.modelo,
                        Anio = item.anio,
                        Chasis = item.chasis,
                        Numero_pasajeros = item.numero_pasajeros,
                        Estado = item.estado
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

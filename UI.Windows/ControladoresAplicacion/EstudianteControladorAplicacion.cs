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
    public class EstudianteControladorAplicacion
    {
        private  EstudianteService estudianteServices;

        public EstudianteControladorAplicacion()
        {
            estudianteServices = new EstudianteService();
        }

        public bool InsertarEstudiante(EstudianteVistaModelo nuevoEstudianteVM)
        {
            Estudiante nuevoEstudianteET = new Estudiante();
            try
            {
                nuevoEstudianteET.nombre = nuevoEstudianteVM.Nombre;
                nuevoEstudianteET.apellido = nuevoEstudianteVM.Apellido;
                nuevoEstudianteET.cedula = nuevoEstudianteVM.Cedula;
                nuevoEstudianteET.direccion = nuevoEstudianteVM.Direccion;
                nuevoEstudianteET.email = nuevoEstudianteVM.Email;
                nuevoEstudianteET.celular = nuevoEstudianteVM.Celular;
                nuevoEstudianteET.estado = nuevoEstudianteVM.Estado;
                
                estudianteServices.InsertarEstudiante(nuevoEstudianteET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarEstudiante(EstudianteVistaModelo nuevoEstudianteVM)
        {
            Estudiante nuevoEstudianteET = new Estudiante();
            try
            {
                nuevoEstudianteET.id_estudiante = nuevoEstudianteVM.Id_estudiante;
                nuevoEstudianteET.nombre = nuevoEstudianteVM.Nombre;
                nuevoEstudianteET.apellido = nuevoEstudianteVM.Apellido;
                nuevoEstudianteET.cedula = nuevoEstudianteVM.Cedula;
                nuevoEstudianteET.direccion = nuevoEstudianteVM.Direccion;
                nuevoEstudianteET.email = nuevoEstudianteVM.Email;
                nuevoEstudianteET.celular = nuevoEstudianteVM.Celular;
                nuevoEstudianteET.estado = nuevoEstudianteVM.Estado;
                estudianteServices.ActualizarEstudiante(nuevoEstudianteET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<EstudianteVistaModelo> ListarEstudiante()
        {
            List<EstudianteVistaModelo> resultadoVistaModelo = new List<EstudianteVistaModelo>();
            var resultadoBD = estudianteServices.ListarEstudiantes();
            try
            {
                foreach (Estudiante item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new EstudianteVistaModelo
                    {
                        Id_estudiante = item.id_estudiante,
                        Nombre = item.nombre,
                        Apellido = item.apellido,
                        Cedula = item.cedula,
                        Direccion = item.direccion,
                        Email = item.email,
                        Celular = item.celular,
                        Estado=item.estado

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

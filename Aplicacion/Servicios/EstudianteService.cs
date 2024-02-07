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
    public class EstudianteService
    {
        readonly IEstudianteRepository estudianteRepository;
        public EstudianteService()
        {
            estudianteRepository = new EstudianteRepository();
        }
        public void InsertarEstudiante(Estudiante nuevo)
        {
            estudianteRepository.Add(nuevo);
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            estudianteRepository.Update(estudiante);
        }

        public IEnumerable<Estudiante> ListarEstudiantes()
        {
            return estudianteRepository.GetAll();
        }
        //DELETE PARA FINES EDUCATIVO
        public void EliminarEstudiante(int id)
        {
            estudianteRepository.Delete(id);
        }

        public string buscarNombrePorId(int idEstudiante)
        {
            return estudianteRepository.buscarNombrePorId(idEstudiante);
        }
    }
}

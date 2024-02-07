using Dominio.Modelo.Abstracciones;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.AccesoDatos.Repositiorio
{
    public class EstudianteRepository : BaseRepository<Estudiante>, IEstudianteRepository
    {
        public string buscarNombrePorId(int idEstudiante)
        {
            try
            {
                using (var context = new TransporteDBEntities())
                {
                    var resultado = from estudiante in context.Estudiante
                                    where estudiante.id_estudiante == idEstudiante
                                    select estudiante.nombre;

                    return resultado.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo visualizar nombre estudiante", ex);
            }
        }
    }
}

using Dominio.Modelo.Abstracciones;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.AccesoDatos.Repositiorio
{
    public class RutaRepository : BaseRepository<Ruta>, IRutaRepository
    {
        public string buscarNombreRuta(int idEstudiante)
        {
            try
            {
                using (var context = new TransporteDBEntities())
                {
                    var resultado = from ruta in context.Ruta
                                    where ruta.id_ruta == idEstudiante
                                    select ruta.nombre_ruta;

                    return resultado.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo visualizar nombre ruta", ex);
            }
        }
    }
}

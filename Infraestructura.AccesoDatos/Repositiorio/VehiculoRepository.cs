﻿using Dominio.Modelo.Abstracciones;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.AccesoDatos.Repositiorio
{
    public class VehiculoRepository : BaseRepository<Vehiculo>, IVehiculoRepository
    {
    }
}

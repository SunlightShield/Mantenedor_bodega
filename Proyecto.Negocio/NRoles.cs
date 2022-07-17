using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proyecto.Datos;

namespace Proyecto.Negocio
{
    public class NRoles
    {
        public static DataTable Listar()
        {
            DRoles d = new DRoles();
            return d.Listar();
        }

    }
}

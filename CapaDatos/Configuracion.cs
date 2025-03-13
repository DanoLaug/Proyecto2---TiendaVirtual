using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Configuracion
    {
        static string cadenaConexion = @"Data Source=DANOLAUG\SQLEXPRESS; Initial Catalog=TiendaVirtual; Integrated Security=True";
        public static string CadenaConexion
        {
            get
            {
                return cadenaConexion;
            }
        }
    }
}




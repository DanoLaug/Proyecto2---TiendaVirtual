using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class CategoriasVO
    {
        private int _Id;
        private string _Nombre;

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        
        public CategoriasVO()
        {
            Id = 0;
            Nombre = string.Empty;
        }

        public CategoriasVO(DataRow dr)
        {
            Id = int.Parse(dr["Id"].ToString());
            Nombre = dr["Nombre"].ToString();
        }
    }
}

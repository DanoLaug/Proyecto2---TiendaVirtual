using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class ProductosVO
    {
        private int _Id;
        private string _Nombre;
        private string _Descripcion;
        private decimal _Precio;
        private bool _Disponibilidad;
        private string _UrlFoto;
        private int _CategoriaId;

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public bool Disponibilidad { get => _Disponibilidad; set => _Disponibilidad = value; } 
        public string UrlFoto { get => _UrlFoto; set => _UrlFoto = value; }
        public int CategoriaId { get => _CategoriaId; set => _CategoriaId = value; }

        public ProductosVO()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
            Disponibilidad = true;
            UrlFoto = string.Empty;
            CategoriaId = 0;
        }

        public ProductosVO(DataRow dr)
        {
            Id = int.Parse(dr["Id"].ToString());
            Nombre = dr["Nombre"].ToString();
            Descripcion = dr["Descripcion"].ToString();
            Precio = decimal.Parse(dr["Precio"].ToString());
            Disponibilidad = bool.Parse(dr["Disponibilidad"].ToString());
            CategoriaId = int.Parse(dr["CategoriaID"].ToString());
        }
    }
}

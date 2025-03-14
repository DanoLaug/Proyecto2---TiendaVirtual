using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class UsuariosVO
    {
        private int _Id;
        private string _Nombre;
        private string _Correo;
        private string _Telefono;
        private string _Direccion;
        private string _UrlFoto;

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string UrlFoto { get => _UrlFoto; set => _UrlFoto = value; }

        public UsuariosVO()
        {
            Id = 0;
            Nombre = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            UrlFoto = string.Empty;
        }

        public UsuariosVO(DataRow dr)
        {
            Id = int.Parse(dr["Id"].ToString());
            Nombre = dr["Nombre"].ToString();
            Correo = dr["Correo"].ToString();
            Telefono = dr["Telefono"].ToString();
            Direccion = dr["Direccion"].ToString();
            UrlFoto = dr["UrlFoto"].ToString();
        }
    }
}


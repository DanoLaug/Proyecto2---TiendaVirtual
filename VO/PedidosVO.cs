using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class PedidosVO
    {
        private int _Id;
        private string _UsuarioId;
        private DateTime _Fecha;
        private decimal _Total;
        private string _Estado;


        public int Id { get => _Id; set => _Id = value; }
        public string UsuarioId { get => _UsuarioId; set => _UsuarioId = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        public PedidosVO()
        {
            Id = 0;
            UsuarioId = string.Empty;
            Fecha = DateTime.Parse("1900-01-01");
            Total = 0;
            Estado = string.Empty;
        }

        public PedidosVO(DataRow dr)
        {
            Id = int.Parse(dr["Id"].ToString());
            UsuarioId = dr["UsuarioId"].ToString();
            Fecha = DateTime.Parse(dr["Fecha"].ToString());
            Total = decimal.Parse(dr["Total"].ToString());
            Estado = dr["Estado"].ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class DetallePedidosVO
    {
        private int _PedidoId;
        private string _ProductoId;
        private int _Cantidad;
        private decimal _PrecioUnitario;

        public int PedidoId { get => _PedidoId; set => _PedidoId = value; }
        public string ProductoId { get => _ProductoId; set => _ProductoId = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal PrecioUnitario { get => _PrecioUnitario; set => _PrecioUnitario = value; }

        public DetallePedidosVO()
        {
            PedidoId = 0;
            ProductoId = string.Empty;
            Cantidad = 0;
            PrecioUnitario = 0;
        }

        public DetallePedidosVO(DataRow dr)
        {
            PedidoId = int.Parse(dr["PedidoId"].ToString());
            ProductoId = dr["ProductoId"].ToString();
            Cantidad = int.Parse(dr["Cantidad"].ToString());
            PrecioUnitario = decimal.Parse(dr["PrecioUnitario"].ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalDetallePedidos
    {
        public static List<DetallePedidosVO> GetListaPedidos()
        {
            try
            {
                DataSet dsPedidos = MetodoDatos.ExecuteDataSet("ObtenerTodosDetallePedidos");
                List<DetallePedidosVO> listaPedidos = new List<DetallePedidosVO>();

                foreach (DataRow dr in dsPedidos.Tables[0].Rows)
                {
                    listaPedidos.Add(new DetallePedidosVO(dr));
                }
                return listaPedidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Insertar DetallePedido
        public static void InsertarDetallePedido(string PedidoId, string ProductoId, decimal Cantidad, int PrecioUnitario)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarDetallePedido",
                    "@PedidoId", PedidoId,
                    "@ProductoId", ProductoId,
                    "@Cantidad", Cantidad,
                    "@PrecioUnitario", PrecioUnitario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar DetallePedido
        public static void ActualizarDetallePedido(int DetallePedidoIds, string PedidoId, string ProductoId, decimal Cantidad, int PrecioUnitario)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarDetallePedido",
                    "@Id", DetallePedidoIds,
                    "@PedidoId", PedidoId,
                    "@ProductoId", ProductoId,
                    "@Cantidad", Cantidad,
                    "@PrecioUnitario", PrecioUnitario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar DetallePedido
        public static void EliminarDetallePedido(int DetallePedidoIds)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarDetallePedido", "@Id", DetallePedidoIds);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener DetallePedido por ID
        public static DetallePedidosVO GetDetallePedidoById(int DetallePedidoIds)
        {
            try
            {
                DataSet dsDetallePedido = MetodoDatos.ExecuteDataSet("ObtenerDetallePedidoPorId", "@Id", DetallePedidoIds);
                if (dsDetallePedido.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsDetallePedido.Tables[0].Rows[0];
                    return new DetallePedidosVO(dr);
                }
                else
                {
                    return new DetallePedidosVO();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

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
        public static void InsertarDetallePedido(string paramPedidoId, string paramProductoId, decimal paramCantidad, int paramPrecioUnitario)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarDetallePedido",
                    "@PedidoId", paramPedidoId,
                    "@ProductoId", paramProductoId,
                    "@Cantidad", paramCantidad,
                    "@PrecioUnitario", paramPrecioUnitario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar DetallePedido
        public static void ActualizarDetallePedido(int paramDetallePedidoIds, string paramPedidoId, string paramProductoId, decimal paramCantidad, int paramPrecioUnitario)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarDetallePedido",
                    "@Id", paramDetallePedidoIds,
                    "@PedidoId", paramPedidoId,
                    "@ProductoId", paramProductoId,
                    "@Cantidad", paramCantidad,
                    "@PrecioUnitario", paramPrecioUnitario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar DetallePedido
        public static void EliminarDetallePedido(int paramDetallePedidoIds)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarDetallePedido", "@Id", paramDetallePedidoIds);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener DetallePedido por ID
        public static DetallePedidosVO GetDetallePedidoById(int paramDetallePedidoIds)
        {
            try
            {
                DataSet dsDetallePedido = MetodoDatos.ExecuteDataSet("ObtenerDetallePedidoPorId", "@Id", paramDetallePedidoIds);
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

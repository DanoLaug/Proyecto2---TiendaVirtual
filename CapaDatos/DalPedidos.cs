using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    class DalPedidos
    {
        public static List<PedidosVO> GetListaPedidos()
        {
            try
            {
                DataSet dsPedidos = MetodoDatos.ExecuteDataSet("ObtenerTodosPedidos");
                List<PedidosVO> listaPedidos = new List<PedidosVO>();

                foreach (DataRow dr in dsPedidos.Tables[0].Rows)
                {
                    listaPedidos.Add(new PedidosVO(dr));
                }
                return listaPedidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Insertar Pedido
        public static void InsertarPedido(string paramUsuarioId, DateTime paramFecha, decimal paramTotal, string paramUrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarPedido",
                    "@UsuarioId", paramUsuarioId,
                    "@Fecha", paramFecha,
                    "@Total", paramTotal,
                    "@UrlFoto", paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar Pedido
        public static void ActualizarPedido(int paramIdPedido, string paramUsuarioId, DateTime paramFecha, decimal paramTotal, string paramUrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarUsuarios",
                    "@Id", paramIdPedido,
                    "@UsuarioId", paramUsuarioId,
                    "@Fecha", paramFecha,
                    "@Total", paramTotal,
                    "@UrlFoto", paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar Pedido
        public static void EliminarPedido(int paramIdPedido)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarPedido", "@Id", paramIdPedido);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener Pedido por ID
        public static PedidosVO GetPedidoById(int paramIdPedido)
        {
            try
            {
                DataSet dsPedido = MetodoDatos.ExecuteDataSet("ObtenerPedidoPorId", "@Id", paramIdPedido);
                if (dsPedido.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsPedido.Tables[0].Rows[0];
                    return new PedidosVO(dr);
                }
                else
                {
                    return new PedidosVO();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

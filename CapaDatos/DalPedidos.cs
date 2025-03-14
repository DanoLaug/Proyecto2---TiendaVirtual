using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalPedidos
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
        public static void InsertarPedido(string UsuarioId, DateTime Fecha, decimal Total, string UrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarPedido",
                    "@UsuarioId", UsuarioId,
                    "@Fecha", Fecha,
                    "@Total", Total,
                    "@UrlFoto", UrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar Pedido
        public static void ActualizarPedido(int PedidoId, string UsuarioId, DateTime Fecha, decimal Total, string UrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarUsuarios",
                    "@Id", PedidoId,
                    "@UsuarioId", UsuarioId,
                    "@Fecha", Fecha,
                    "@Total", Total,
                    "@UrlFoto", UrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar Pedido
        public static void EliminarPedido(int PedidoId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarPedido", "@Id", PedidoId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener Pedido por ID
        public static PedidosVO GetPedidoById(int PedidoId)
        {
            try
            {
                DataSet dsPedido = MetodoDatos.ExecuteDataSet("ObtenerPedidoPorId", "@Id", PedidoId);
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

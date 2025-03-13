using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    class DalProductos
    {
        public static List<ProductosVO> GetLstProductos(bool? Disponibilidad)
        {
            string Query = "ObtenerTodosProductos";
            DataSet dsProductos = new DataSet();

            try
            {
                if (Disponibilidad == null)
                {
                    dsProductos = MetodoDatos.ExecuteDataSet(Query);
                }
                else
                {
                    dsProductos = MetodoDatos.ExecuteDataSet(Query, "@Disponibilidad", Disponibilidad);
                }

                if (dsProductos.Tables[0].Rows.Count > 0)
                {
                    List<ProductosVO> LstProductos = new List<ProductosVO>();

                    foreach (DataRow dr in dsProductos.Tables[0].Rows)
                    {
                        LstProductos.Add(new ProductosVO(dr));
                    }
                    return LstProductos;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Insertar Producto
        public static void InsertarProducto(string paramNombre, string paramDescripcion, decimal paramPrecio, string paramUrlFoto,  int paramCategoriaId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarProducto",
                    "@Nombre", paramNombre,
                    "@Descripcion", paramDescripcion,
                    "@Precio", paramPrecio,
                    "@UrlFoto", paramUrlFoto,
                    "@CategoriaId", paramCategoriaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar Productos
        public static void ActualizarProducto(int paramIdProductos, string paramNombre, string paramDescripcion, decimal paramPrecio, string paramUrlFoto, int paramCategoriaId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarProducto",
                    "@Id", paramIdProductos,
                    "@Nombre", paramNombre,
                    "@Descripcion", paramDescripcion,
                    "@Precio", paramPrecio,
                    "@UrlFoto", paramUrlFoto,
                    "@CategoriaId", paramCategoriaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar Producto
        public static void EliminarProducto(int paramIdProducto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarProducto", "@Id", paramIdProducto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener Producto por ID
        public static ProductosVO GetProductoById(int paramIdProducto)
        {
            try
            {
                DataSet dsProducto = MetodoDatos.ExecuteDataSet("ObtenerProductoPorId", "@Id", paramIdProducto);
                if (dsProducto.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsProducto.Tables[0].Rows[0];
                    return new ProductosVO(dr);
                }
                else
                {
                    return new ProductosVO();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

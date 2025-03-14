using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalProductos
    {
        public static List<ProductosVO> GetListaProductos(bool? Disponibilidad)
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
        public static void InsertarProducto(string Nombre, string Descripcion, decimal Precio, string UrlFoto,  int CategoriaId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarProducto",
                    "@Nombre", Nombre,
                    "@Descripcion", Descripcion,
                    "@Precio", Precio,
                    "@UrlFoto", UrlFoto,
                    "@CategoriaId", CategoriaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar Productos
        public static void ActualizarProducto(int ProductoIds, string Nombre, string Descripcion, decimal Precio, string UrlFoto, int CategoriaId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarProducto",
                    "@Id", ProductoIds,
                    "@Nombre", Nombre,
                    "@Descripcion", Descripcion,
                    "@Precio", Precio,
                    "@UrlFoto", UrlFoto,
                    "@CategoriaId", CategoriaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar Producto
        public static void EliminarProducto(int ProductoId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarProducto", "@Id", ProductoId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener Producto por ID
        public static ProductosVO GetProductoById(int ProductoId)
        {
            try
            {
                DataSet dsProducto = MetodoDatos.ExecuteDataSet("ObtenerProductoPorId", "@Id", ProductoId);
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

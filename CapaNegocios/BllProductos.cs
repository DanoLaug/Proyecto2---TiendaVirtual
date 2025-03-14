using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using VO;

namespace CapaNegocios
{
    class BllProductos
    {
        // Obtener lista - Obtener Todos
        public static List<ProductosVO> GetListaProductos(bool? Disponibilidad)
        {
            List<ProductosVO> ListaProductos = new List<ProductosVO>();
            try
            {
                System.Diagnostics.Debug.WriteLine("Prueba BllProductos");
                return DalProductos.GetListaProductos(Disponibilidad);
            }
            catch (Exception)
            {
                return ListaProductos;
            }
        }

        //Insertar
        public static void InsertarProducto(string paramNombre, string paramDescripcion, decimal paramPrecio, string paramUrlFoto, int paramCategoriaId)
        {
            try
            {
                DalProductos.InsertarProducto(paramNombre, paramDescripcion, paramPrecio, paramUrlFoto,  paramCategoriaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar 
        public static void ActualizarProducto(int paramProductoIds, string paramNombre, string paramDescripcion, decimal paramPrecio, string paramUrlFoto, int paramCategoriaId)
        {
            DalProductos.ActualizarProducto(paramProductoIds, paramNombre, paramDescripcion, paramPrecio, paramUrlFoto, paramCategoriaId);
        }

        //Elminar
        public static string EliminarProducto(int paramProductoId)
        {
            try
            {
                ProductosVO Producto = DalProductos.GetProductoById(paramProductoId);
                if (Producto != null && Producto.Id > 0)  // Verifica si existe antes de eliminar
                {
                    DalProductos.EliminarProducto(paramProductoId);
                    return "1";  // Eliminación exitosa
                }
                else
                {
                    return "0";  // Usuario no encontrado
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener por ID
        public static ProductosVO GetProductoById(int paramProductoId)
        {
            return DalProductos.GetProductoById(paramProductoId);
        }
    }
}

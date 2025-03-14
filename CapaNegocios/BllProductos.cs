﻿using System;
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
        public static void InsertarProducto(string Nombre, string Descripcion, decimal Precio, string UrlFoto, int CategoriaId)
        {
            try
            {
                DalProductos.InsertarProducto(Nombre, Descripcion, Precio, UrlFoto,  CategoriaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar 
        public static void ActualizarProducto(int ProductoIds, string Nombre, string Descripcion, decimal Precio, string UrlFoto, int CategoriaId)
        {
            DalProductos.ActualizarProducto(ProductoIds, Nombre, Descripcion, Precio, UrlFoto, CategoriaId);
        }

        //Elminar
        public static string EliminarProducto(int ProductoId)
        {
            try
            {
                ProductosVO Producto = DalProductos.GetProductoById(ProductoId);
                if (Producto != null && Producto.Id > 0)  // Verifica si existe antes de eliminar
                {
                    DalProductos.EliminarProducto(ProductoId);
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
        public static ProductosVO GetProductoById(int ProductoId)
        {
            return DalProductos.GetProductoById(ProductoId);
        }
    }
}

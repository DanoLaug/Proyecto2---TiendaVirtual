using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using VO;

namespace CapaNegocios
{
    class BllCategorias
    {
        // Obtener lista - Obtener Todos
        public static List<CategoriasVO> GetListaCategorias()
        {
            return DalCategorias.GetListaCategorias();
        }

        //Insertar
        public static void InsertarCategoria(string Nombre)
        {
            try
            {
                DalCategorias.InsertarCategoria(Nombre);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar 
        public static void ActualizarCategoria(int CategoriaId, string Nombre)
        {
            DalCategorias.ActualizarCategoria(CategoriaId, Nombre);
        }

        //Elminar
        public static string EliminarCategoria(int CategoriaId)
        {
            try
            {
                CategoriasVO Categoria = DalCategorias.GetCategoriaById(CategoriaId);
                if (Categoria != null && Categoria.Id > 0)  // Verifica si existe antes de eliminar
                {
                    DalCategorias.EliminarCategoria(CategoriaId);
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
        public static CategoriasVO GetCategoriaById(int CategoriaId)
        {
            return DalCategorias.GetCategoriaById(CategoriaId);
        }
    }
}

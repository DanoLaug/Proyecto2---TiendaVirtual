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
        public static void InsertarCategoria(string paramNombre)
        {
            try
            {
                DalCategorias.InsertarCategoria(paramNombre);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar 
        public static void ActualizarCategoria(int paramCategoriaId, string paramNombre)
        {
            DalCategorias.ActualizarCategoria(paramCategoriaId, paramNombre);
        }

        //Elminar
        public static string EliminarCategoria(int paramCategoriaId)
        {
            try
            {
                CategoriasVO Categoria = DalCategorias.GetCategoriaById(paramCategoriaId);
                if (Categoria != null && Categoria.Id > 0)  // Verifica si existe antes de eliminar
                {
                    DalCategorias.EliminarCategoria(paramCategoriaId);
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
        public static CategoriasVO GetCategoriaById(int paramCategoriaId)
        {
            return DalCategorias.GetCategoriaById(paramCategoriaId);
        }
    }
}

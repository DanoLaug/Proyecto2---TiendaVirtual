﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalCategorias
    {
        public static List<CategoriasVO> GetListaCategorias()
        {
            try
            {
                DataSet dsCategorias = MetodoDatos.ExecuteDataSet("ObtenerTodosCategorias");
                List<CategoriasVO> listaCategorias = new List<CategoriasVO>();

                foreach (DataRow dr in dsCategorias.Tables[0].Rows)
                {
                    listaCategorias.Add(new CategoriasVO(dr));
                }
                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Insertar Categorias
        public static void InsertarCategoria(string paramNombre)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarCategoria", "@Nombre", paramNombre);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar Categorias
        public static void ActualizarCategoria(int paramCategoriaId, string paramNombre)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarCategoria",
                    "@Id", paramCategoriaId,
                    "@Nombre", paramNombre);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar Categorias
        public static void EliminarCategoria(int paramCategoriaId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarCategoria", "@Id", paramCategoriaId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener Categoria por ID
        public static CategoriasVO GetCategoriaById(int paramCategoriaId)
        {
            try
            {
                DataSet dsUsuario = MetodoDatos.ExecuteDataSet("ObtenerCategoriaPorId", "@Id", paramCategoriaId);
                if (dsUsuario.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsUsuario.Tables[0].Rows[0];
                    return new CategoriasVO(dr);
                }
                else
                {
                    return new CategoriasVO();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalUsuarios
    {
        public static List<UsuariosVO> GetListaUsuarios()
        {
            try
            {
                DataSet dsUsuarios = MetodoDatos.ExecuteDataSet("ObtenerTodosUsuarios");
                List<UsuariosVO> listaUsuarios = new List<UsuariosVO>();

                foreach (DataRow dr in dsUsuarios.Tables[0].Rows)
                {
                    listaUsuarios.Add(new UsuariosVO(dr));
                }
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Insertar usuario
        public static void InsertarUsuario(string Nombre, string Correo, string Telefono, string Direccion, string UrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarUsuario",
                    "@Nombre", Nombre,
                    "@Correo", Correo,
                    "@Telefono", Telefono,
                    "@Direccion", Direccion,
                    "@UrlFoto", UrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar usuario
        public static void ActualizarUsuario(int UsuarioId, string Nombre, string Correo, string Telefono, string Direccion, string UrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarUsuario",
                    "@Id", UsuarioId,
                    "@Nombre", Nombre,
                    "@Correo", Correo,
                    "@Telefono", Telefono,
                    "@Direccion", Direccion,
                    "@UrlFoto", UrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar usuario
        public static void EliminarUsuario(int UsuarioId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarUsuario", "@Id", UsuarioId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener usuario por ID
        public static UsuariosVO GetUsuarioById(int UsuarioId)
        {
            try
            {
                DataSet dsUsuario = MetodoDatos.ExecuteDataSet("ObtenerUsuarioPorId", "@Id", UsuarioId);
                if (dsUsuario.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsUsuario.Tables[0].Rows[0];
                    return new UsuariosVO(dr);
                }
                else
                {
                    return new UsuariosVO();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

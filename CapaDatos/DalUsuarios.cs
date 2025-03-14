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
        public static void InsertarUsuario(string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, string paramUrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarUsuario",
                    "@Nombre", paramNombre,
                    "@Correo", paramCorreo,
                    "@Telefono", paramTelefono,
                    "@Direccion", paramDireccion,
                    "@UrlFoto", paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar usuario
        public static void ActualizarUsuario(int paramUsuarioId, string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, string paramUrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarUsuario",
                    "@Id", paramUsuarioId,
                    "@Nombre", paramNombre,
                    "@Correo", paramCorreo,
                    "@Telefono", paramTelefono,
                    "@Direccion", paramDireccion,
                    "@UrlFoto", paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar usuario
        public static void EliminarUsuario(int paramUsuarioId)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarUsuario", "@Id", paramUsuarioId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener usuario por ID
        public static UsuariosVO GetUsuarioById(int paramUsuarioId)
        {
            try
            {
                DataSet dsUsuario = MetodoDatos.ExecuteDataSet("ObtenerUsuarioPorId", "@Id", paramUsuarioId);
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

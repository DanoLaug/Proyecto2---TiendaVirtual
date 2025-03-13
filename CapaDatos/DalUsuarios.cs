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
        // Insertar usuario
        public static void InsertarUsuario(string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, DateTime paramFechaNacimiento, string paramUrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("InsertarUsuario",
                    "@Nombre", paramNombre,
                    "@Correo", paramCorreo,
                    "@Telefono", paramTelefono,
                    "@Direccion", paramDireccion,
                    "@FechaNacimiento", paramFechaNacimiento,
                    "@UrlFoto", paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Actualizar usuario
        public static void ActualizarUsuario(int paramIdUsuario, string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, DateTime paramFechaNacimiento, string paramUrlFoto)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("ActualizarUsuarios",
                    "@Id", paramIdUsuario,
                    "@Nombre", paramNombre,
                    "@Correo", paramCorreo,
                    "@Telefono", paramTelefono,
                    "@Direccion", paramDireccion,
                    "@FechaNacimiento", paramFechaNacimiento,
                    "@UrlFoto", paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Eliminar usuario
        public static void EliminarUsuario(int paramIdUsuario)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("EliminarUsuario", "@Id", paramIdUsuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtener usuario por ID
        public static UsuariosVO GetUsuarioById(int paramIdUsuario)
        {
            try
            {
                DataSet dsUsuario = MetodoDatos.ExecuteDataSet("ObtenerUsuarioPorId", "@Id", paramIdUsuario);
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

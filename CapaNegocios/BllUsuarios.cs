using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using VO;

namespace CapaNegocios
{
    public class BllUsuarios
    {
        // Obtener lista - Obtener Todos
        public static List<UsuariosVO> GetListaUsuarios()
        {
            return DalUsuarios.GetListaUsuarios();
        }

        //Insertar
        public static void InsertarUsuario(string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, DateTime paramFechaNacimiento, string paramUrlFoto)
        {
            try
            {
                DalUsuarios.InsertarUsuario(paramNombre, paramCorreo, paramTelefono, paramDireccion, paramFechaNacimiento, paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar 
        public static void ActualizarUsuario(int paramIdUsuario, string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, DateTime paramFechaNacimiento, string paramUrlFoto)
        {
            DalUsuarios.ActualizarUsuario(paramIdUsuario, paramNombre, paramCorreo, paramTelefono, paramDireccion, paramFechaNacimiento, paramUrlFoto);
        }

        //Elminar
        public static string EliminarUsuario(int paramIdUsuario)
        {
            try
            {
                UsuariosVO usuario = DalUsuarios.GetUsuarioById(paramIdUsuario);
                if (usuario != null && usuario.Id > 0)  // Verifica si existe antes de eliminar
                {
                    DalUsuarios.EliminarUsuario(paramIdUsuario);
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
        public static UsuariosVO GetUsuarioById(int paramIdUsuario)
        {
            return DalUsuarios.GetUsuarioById(paramIdUsuario);
        }
    }
}

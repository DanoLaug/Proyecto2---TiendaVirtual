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
        public static void InsertarUsuario(string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, string paramUrlFoto)
        {
            try
            {
                DalUsuarios.InsertarUsuario(paramNombre, paramCorreo, paramTelefono, paramDireccion, paramUrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar 
        public static void ActualizarUsuario(int paramUsuarioId, string paramNombre, string paramCorreo, string paramTelefono, string paramDireccion, string paramUrlFoto)
        {
            DalUsuarios.ActualizarUsuario(paramUsuarioId, paramNombre, paramCorreo, paramTelefono, paramDireccion, paramUrlFoto);
        }

        //Elminar
        public static string EliminarUsuario(int paramUsuarioId)
        {
            try
            {
                UsuariosVO usuario = DalUsuarios.GetUsuarioById(paramUsuarioId);
                if (usuario != null && usuario.Id > 0)  // Verifica si existe antes de eliminar
                {
                    DalUsuarios.EliminarUsuario(paramUsuarioId);
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
        public static UsuariosVO GetUsuarioById(int paramUsuarioId)
        {
            return DalUsuarios.GetUsuarioById(paramUsuarioId);
        }
    }
}

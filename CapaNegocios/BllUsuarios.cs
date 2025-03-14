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
        public static void InsertarUsuario(string Nombre, string Correo, string Telefono, string Direccion, string UrlFoto)
        {
            try
            {
                DalUsuarios.InsertarUsuario(Nombre, Correo, Telefono, Direccion, UrlFoto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar 
        public static void ActualizarUsuario(int UsuarioId, string Nombre, string Correo, string Telefono, string Direccion, string UrlFoto)
        {
            DalUsuarios.ActualizarUsuario(UsuarioId, Nombre, Correo, Telefono, Direccion, UrlFoto);
        }

        //Elminar
        public static string EliminarUsuario(int UsuarioId)
        {
            try
            {
                UsuariosVO usuario = DalUsuarios.GetUsuarioById(UsuarioId);
                if (usuario != null && usuario.Id > 0)  // Verifica si existe antes de eliminar
                {
                    DalUsuarios.EliminarUsuario(UsuarioId);
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
        public static UsuariosVO GetUsuarioById(int UsuarioId)
        {
            return DalUsuarios.GetUsuarioById(UsuarioId);
        }
    }
}

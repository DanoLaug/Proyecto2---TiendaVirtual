using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
using VO;

namespace TiendaVirtual.Catalogo.Usuarios
{
    public partial class EditarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Validar el ID antes de hacer la conversión
                if (string.IsNullOrEmpty(Request.QueryString["Id"]) || !int.TryParse(Request.QueryString["Id"], out int usuarioId))
                {
                    Response.Redirect("ListarUsuarios.aspx");
                    return;
                }

                // Obtener el usuario
                UsuariosVO usuario = BllUsuarios.GetUsuarioById(usuarioId);
                if (usuario == null)
                {
                    Response.Redirect("ListarUsuarios.aspx");
                    return;
                }

                // Mostrar información del usuario
                lblUsuarioId.Text = usuarioId.ToString();
                txtNombre.Text = usuario.Nombre;
                txtCorreo.Text = usuario.Correo;
                txtTelefono.Text = usuario.Telefono;
                txtDireccion.Text = usuario.Direccion;
                UrlFoto.Text = usuario.UrlFoto;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lblUsuarioId.Text);
                string Nombre = txtNombre.Text;
                string Correo = txtCorreo.Text;
                string Telefono = txtTelefono.Text;
                string Direccion = txtDireccion.Text;
                string UrlFoto = UrlFoto.Text;

                // Variables agregadas (ajústalas si hay controles específicos para obtener estos valores)
                DateTime fechaNacimiento = DateTime.Now; // Ajustar si se tiene un control DatePicker
                bool disponibilidad = true; // Ajustar si se tiene un control CheckBox

                // Actualizar usuario en la base de datos
                BllUsuarios.ActualizarUsuario(id, Nombre, Correo, Telefono, Direccion, UrlFoto);

                // Mostrar mensaje de éxito
                Response.Write("<script>alert('Usuario actualizado correctamente')</script>");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Error: {ex.Message}')</script>");
            }
        }

        protected void btnSubeImagen_Click(object sender, EventArgs e)
        {
            if (SubeImagen.HasFile) // Corregido uso de HasFile en lugar de Value
            {
                string fileName = Path.GetFileName(SubeImagen.PostedFile.FileName);
                string fileExt = Path.GetExtension(fileName).ToLower();

                // Validar extensiones permitidas
                if (fileExt != ".jpg" && fileExt != ".png" && fileExt != ".jfif")
                {
                    Response.Write("<script>alert('Seleccione un archivo válido (jpg, png, jfif)')</script>");
                    return;
                }

                // Verificar y crear directorio si no existe
                string pathDir = Server.MapPath("~/Imagenes/Usuarios/");
                if (!Directory.Exists(pathDir))
                {
                    Directory.CreateDirectory(pathDir);
                }

                // Guardar la imagen en el servidor
                string filePath = Path.Combine(pathDir, fileName);
                SubeImagen.PostedFile.SaveAs(filePath);

                // Actualizar la URL en el formulario
                string urlFoto = "/Imagenes/Usuarios/" + fileName;
                UrlFoto.Text = urlFoto;
                imgFotoUsuario.ImageUrl = urlFoto;
                btnGuardar.Visible = true;
            }
            else
            {
                Response.Write("<script>alert('Seleccione un archivo válido')</script>");
            }
        }
    }
}

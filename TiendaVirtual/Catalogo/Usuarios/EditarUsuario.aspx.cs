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
                // Obtener el ID del QueryString
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("ListarUsuarios.aspx");
                }
                
                else
                {
                    // Obtener el ID del Usuario
                    int UsuarioId = int.Parse(Request.QueryString["Id"]);
                    UsuariosVO Usuario = BllUsuarios.GetUsuarioById(UsuarioId);

                    // Validar que el usuario es correcto
                    if (Usuario.Id == UsuarioId)
                    {
                        // Desplegar la información del usuario
                        this.lblUsuarioId.Text = UsuarioId.ToString();
                        this.txtNombre.Text = Usuario.Nombre;
                        this.txtCorreo.Text = Usuario.Correo;
                        this.txtTelefono.Text = Usuario.Telefono;
                        this.txtDireccion.Text = Usuario.Direccion;
                        this.imgFotoUsuario.ImageUrl = Usuario.UrlFoto;
                        this.UrlFoto.Text = Usuario.UrlFoto;
                    }
                    else
                    {
                        Response.Redirect("Catalogo/Usuarios/ListarUsuarios.aspx");
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lblIdUsuario.Text);
                string nombre = txtNombre.Text;
                string correo = txtCorreo.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                string UrlFoto = this.UrlFoto.Text;

                // Llamar a la capa de negocio para actualizar el usuario
                BllUsuarios.ActualizarUsuario(id, nombre, correo, telefono, direccion, fechaNacimiento, urlFoto, disponibilidad);

                // Mostrar mensaje de éxito
                //UtilControls.SweetBoxConfirm("Éxito!", "Usuario editado exitosamente", "success", "ListaUsuarios.aspx", this.Page, this.GetType());
                Response.Write("<script>alert('Exito')</script>");
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                //UtilControls.SweetBox("Error!", ex.Message, "error", this.Page, this.GetType());
                Response.Write("<script>alert('Fallo')</script>");
            }
        }

        protected void btnSubeImagen_Click(object sender, EventArgs e)
        {
            // Validar que el usuario haya seleccionado un archivo
            if (SubeImagen.Value != "")
            {
                // Obtener el nombre del archivo
                string FileName = Path.GetFileName(SubeImagen.PostedFile.FileName);
                string FileExt = Path.GetExtension(FileName).ToLower();

                // Validar que el archivo sea .jpg, .png o .jfif
                if ((FileExt != ".jpg") && (FileExt != ".png") && (FileExt != ".jfif"))
                {
                    //UtilControls.SweetBox("Error!", "Seleccione un archivo válido (jpg, png, jfif)", "error", this.Page, this.GetType());
                    Response.Write("<script>alert('Fallo')</script>");
                }
                else
                {
                    // Verificar que el directorio exista
                    string pathDir = Server.MapPath("~/Imagenes/Usuarios/");
                    if (!Directory.Exists(pathDir))
                    {
                        Directory.CreateDirectory(pathDir);
                    }

                    // Guardar la imagen en el directorio
                    SubeImagen.PostedFile.SaveAs(pathDir + FileName);
                    string urlFoto = "/Imagenes/Usuarios/" + FileName;
                    this.urlFoto.Text = urlFoto;
                    imgFotoUsuario.ImageUrl = urlFoto;
                    btnGuardar.Visible = true;
                }
            }
            else
            {
                //UtilControls.SweetBox("Error!", "Seleccione un archivo válido", "error", this.Page, this.GetType());
                Response.Write("<script>alert('Fallo')</script>");
            }
        }
    }
}

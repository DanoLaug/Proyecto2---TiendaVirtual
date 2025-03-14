using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace TiendaVirtual.Catalogo.Usuarios
{
	public partial class AltaUsuarios : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnSubeImagen_Click(object sender, EventArgs e)
        {
            //Validar que el usuario haya seleccionado un archivo
            if (SubeImagen.Value != "")
            {
                //asignar a una variable el nombre del archivo seleccionado
                string FileName = Path.GetFileName(SubeImagen.PostedFile.FileName);
                //validar que el archivo sea .jpg o .png
                string FileExt = Path.GetExtension(FileName).ToLower();

                if ((FileExt != ".jpg") && (FileExt != ".png") && (FileExt != ".jfif"))
                {
                    //Informamos que el archivo no es válido
                    // UtilControls.SweetBox(
                    //"Error!", "Seleccione un archivo válido", "error", this.Page, this.GetType()
                    //);
                    Response.Write("<script>alert('Fallo')</script>");
                }
                else
                {
                    //Verificar que el directorio donde vamos
                    //guardar el archivo exista
                    string pathDir =
                        Server.MapPath("~/Imagenes/Usuarios/");
                    if (!Directory.Exists(pathDir))
                    {
                        //crea el arbol completo
                        Directory.CreateDirectory(pathDir);
                    }

                    //Guardamos la imagen en el directorio correspondiente
                    SubeImagen.PostedFile.SaveAs(pathDir + FileName);
                    string urlfoto = "/Imagenes/Usuarios/" + FileName;
                    this.urlFoto.Text = urlfoto;
                    this.imgFotoUsuario.ImageUrl = urlfoto;
                    this.btnGuardar.Visible = true;
                }
            }
            else
            {
                //Enviar mensaje de que no puede ser vacío
                //UtilControls.SweetBox("Error!", "Seleccione un archivo válido", "error", this.Page, this.GetType());
                Response.Write("<script>alert('Fallo')</script>");
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = this.txtNombre.Text;
                string Correo = this.txtCorreo.Text;
                string Direccion = this.txtDireccion.Text;
                string Telefono = this.txtTelefono.Text;
                DateTime FechaNacimiento = DateTime.Parse(this.txtFechaNacimiento.Text);
                string UrlFoto = this.urlFoto.Text;
                BllUsuarios.InsertarUsuario(Nombre, Correo, Telefono, Direccion, FechaNacimiento, UrlFoto);
                //Util.UtilControls.SweetBoxConfirm("Extito!", "Chofer agregado exitosamente", "success",
                //    "/Catalagos/Usuarios/ListarUsuarios.aspx", this.Page, this.GetType());
                Response.Write("<script>alert('Fallo')</script>");

            }
            catch (Exception ex)
            {
                //UtilControls.SweetBox("Error!", ex.ToString(), "Error", this.Page, this.GetType());
                Response.Write("<script>alert('Fallo')</script>");
            }
        }
    }
}
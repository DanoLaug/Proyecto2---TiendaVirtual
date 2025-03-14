using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace TiendaVirtual.Catalogo.Usuarios
{
	public partial class ListarUsuarios : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                try
                {
                    RefrescaGrid();
                }
                catch (Exception ex)
                {
                    //Util.UtilControls.SweetBox("Error", ex.Message, "danger", this.Page, this.GetType());
                    Response.Write("<script>alert('Fallo')</script>");
                }
            }
        }
        public void RefrescaGrid()
        {
            GVUsuarios.DataSource = BllUsuarios.GetListaUsuarios();
            GVUsuarios.DataBind();
        }

        protected void GVUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string UsuarioIds = GVUsuarios.DataKeys[e.RowIndex].Values["Id"].ToString();
            //string Resultado = BllUsuarios.DalUsuarios(int.Parse(UsuarioId)); //El error esta aqui 
            string Resultado = BllUsuarios.EliminarUsuario(int.Parse(UsuarioIds));

            string mensaje = "";
            string sub = "";
            string clase = "";

            switch (Resultado)
            {
                case "1":
                    mensaje = "Usuario eliminado correctamente";
                    sub = "";
                    clase = "success";
                    break;
                default:
                    mensaje = "Usuario no disponible para eliminar";
                    sub = "Los Usuarios no pueden ser eleminados";
                    clase = "warning";
                    break;
            }
            //UtilControls.SweetBox(mensaje, sub, clase, this.Page, this.GetType());
            RefrescaGrid();
            Response.Write("<script>alert('Fallo')</script>");
        }

        protected void GVUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                string UsuarioId = GVUsuarios.DataKeys[index].Values["Id"].ToString();
                Response.Redirect("EditarUsuarios.aspx?Id=" + UsuarioId);
            }
        }

        protected void GVUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVUsuarios.EditIndex = e.NewEditIndex;
            RefrescaGrid();

        }

        protected void GVUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string UsuarioId = GVUsuarios.DataKeys[e.RowIndex].Values["Id"].ToString();
                string Nombre = e.NewValues["Nombre"].ToString();
                string Correo = e.NewValues["Correo"].ToString();
                string Telefono = e.NewValues["Telefono"].ToString();
                string Direccion = e.NewValues["Direccion"].ToString();
                string UrlFoto = e.NewValues["UrlFoto"]?.ToString() ?? "";

                BllUsuarios.ActualizarUsuario(int.Parse(UsuarioId), Nombre, Correo, Telefono, Direccion, UrlFoto);

                GVUsuarios.EditIndex = -1;
                RefrescaGrid();
                //UtilControls.SweetBox("Registro actualizado", "", "success", this.Page, this.GetType());
                Response.Write("<script>alert('Fallo')</script>");
            }

            catch (Exception ex)
            {
                //UtilControls.SweetBox("Error", ex.Message, "danger", this.Page, this.GetType());
                Response.Write("<script>alert('Fallo')</script>");
            }
        }
        protected void GVUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVUsuarios.EditIndex = -1;
            RefrescaGrid();
        }
    }
}
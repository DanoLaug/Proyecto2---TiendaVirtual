<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="Proyecto2.Catalogo.Usuarios.EditarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content3" ContentPlaceHolderID="nav" runat="server">
    <div class="hero">
        <div class="container">
            <h2>Edita tu perfil</h2>
            <p>Edita tu perfil y cambia tu informacion</p>
        </div>
    </div>
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
 
<div class="container">
        <div class="row">
            <h3>Editar Usuario</h3>
            <h3>Editando Usuario con ID:
                <asp:Label ID="lblIdUsuario" runat="server" Text=""></asp:Label></h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="form-group">

                <!-- Nombre -->
                <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre completo" CssClass="form-control" />

                <!-- Correo -->
                <asp:Label ID="lblCorreo" runat="server">Correo</asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server" placeholder="correo@example.com" CssClass="form-control" />

                <!-- Teléfono -->
                <asp:Label ID="lblTelefono" runat="server">Teléfono</asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server" placeholder="123-456-7890" MaxLength="10" CssClass="form-control" />

                <!-- Dirección -->
                <asp:Label ID="lblDireccion" runat="server">Dirección</asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server" placeholder="Calle, Ciudad, Estado" CssClass="form-control" />


                <!-- Subir Imagen -->
                <asp:Label ID="lblSubeImagen" runat="server">Seleccionar Foto</asp:Label>
                <input type="file" id="SubeImagen" runat="server" class="btn btn-file" />

                <!-- Botón Subir Imagen -->
                <asp:Button ID="btnSubeImagen" CssClass="btn btn-primary" Text="Subir" runat="server" OnClick="btnSubeImagen_Click" />

                <!-- Mostrar Imagen -->
                <asp:Label ID="lblFoto" runat="server">Foto</asp:Label>
                <asp:Image ID="imgFotoUsuario" Width="150" Height="100" runat="server" />
                <asp:Label ID="urlFoto" runat="server">Aquí debe aparecer el path de la foto que seleccionaste</asp:Label>

                <!-- Botón Guardar -->
                <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </div>

</asp:Content>


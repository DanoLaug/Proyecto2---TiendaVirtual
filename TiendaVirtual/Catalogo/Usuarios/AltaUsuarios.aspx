  <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaUsuarios.aspx.cs" Inherits="TiendaVirtual.Catalogo.Usuarios.AltaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content3" ContentPlaceHolderID="nav" runat="server">
    
    <div class="hero">
        <div class="container">
            <h2>Registrate</h2>
            <p>Resgitrate con tus datos para continuar</p>
        </div>
    </div>

</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h3>Registro de Usuario</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre Completo" MaxLength="50"
                        CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvtxtNombre" ControlToValidate="txtNombre"
                        CssClass="text-danger" runat="server"
                        ErrorMessage="El nombre es requerido"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label>
                    <asp:TextBox ID="txtCorreo" runat="server" placeholder="usuario@correo.com" MaxLength="150"
                        CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvtxtCorreo" ControlToValidate="txtCorreo"
                        CssClass="text-danger" runat="server"
                        ErrorMessage="El correo es requerido"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCorreo" ControlToValidate="txtCorreo"
                        CssClass="text-danger" runat="server"
                        ErrorMessage="Formato de correo inválido"
                        ValidationExpression="^[\w\.-]+@[\w\.-]+\.\w+$"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" placeholder="(999) 999-9999" MaxLength="10"
                        CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTelefono" ControlToValidate="txtTelefono"
                        CssClass="text-danger" runat="server"
                        ErrorMessage="El teléfono es requerido"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
                    <asp:TextBox ID="txtDireccion" runat="server" placeholder="Calle, Número, Ciudad"
                        MaxLength="200" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento"></asp:Label>
                    <asp:TextBox ID="txtFechaNacimiento" runat="server" placeholder="dd/mm/yyyy"
                        CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFechaNacimiento" ControlToValidate="txtFechaNacimiento"
                        CssClass="text-danger" runat="server"
                        ErrorMessage="La fecha de nacimiento es requerida"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblSubirImagen" runat="server" Text="Seleccionar Foto"></asp:Label>
                    <div class="row">
                        <div class="col-md-3">
                            <input type="file" id="SubeImagen" runat="server" class="btn btn-file" />
                        </div>
                        <div class="col-md-9">
                            <asp:Button ID="btnSubeImagen" CssClass="btn btn-primary" Text="Subir" runat="server" 
                                OnClick="btnSubeImagen_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblFoto" runat="server">Foto</asp:Label>
                    <asp:Image ID="imgFotoUsuario" Width="150" Height="100" runat="server" />
                    <asp:Label ID="urlFoto" runat="server">Aquí aparece el path de la foto que seleccionaste</asp:Label>
                </div>
            </div>

            <div class="col-md-12 col-md-offset-5">
                <div class="form-group">
                    <asp:Button ID="btnGuardar" Visible="true" CssClass="btn btn-primary" runat="server"
                        Text="Guardar" OnClick="btnGuardar_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>


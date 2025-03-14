<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarUsuarios.aspx.cs" Inherits="TiendaVirtual.Catalogo.Usuarios.ListarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content3" ContentPlaceHolderID="nav" runat="server">

    <div class="hero">
        <div class="container">
            <h2>Nuestros Usuarios</h2>
            <p>Nuestra Comunidad</p>
        </div>
    </div>

</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <div class="container">
    <div class="row">
        <h3>LISTA DE USUARIOS</h3>

        <div class="col-12">
            <button class="btn btn-success btn-xs"
                onclick="location.href = 'AltaUsuarios.aspx'; return false;">Crear Usuario</button>
        </div>

        <asp:GridView ID="GVUsuarios"
            runat="server"
            CssClass="table table-bordered table-striped table-condensed"
            AutoGenerateColumns="False"
            DataKeyNames="Id"
            
            OnRowDeleting="GVUsuarios_RowDeleting"
            >
            
            <Columns>
                <asp:ButtonField 
                        ButtonType="Button" 
                        CommandName="Select" 
                        HeaderText="Seleccionar" 
                        ShowHeader="True" 
                        Text="Seleccionar" 
                        ControlStyle-CssClass="btn btn-success btn-xs"/>
                
                <asp:CommandField 
                        ButtonType="Button" 
                        HeaderText="Eliminar" 
                        ShowDeleteButton="True" 
                        ShowHeader="True"
                        ControlStyle-CssClass="btn btn-danger btn-xs"/>
                
                <asp:CommandField 
                        ButtonType="Button" 
                        HeaderText="Editar" 
                        ShowEditButton="True" 
                        ShowHeader="True" 
                        ControlStyle-CssClass="btn btn-warning btn-xs"/>
                
                <asp:ImageField 
                        HeaderText="Foto" 
                        ReadOnly="True"
                        ItemStyle-Width="120px"
                        ControlStyle-Width="120px"
                        ControlStyle-Height="90px"
                        DataImageUrlField="URLFoto">
                </asp:ImageField>

                <asp:BoundField 
                        DataField="Id" 
                        HeaderText="ID Usuario" 
                        ItemStyle-Width="50px"
                        ReadOnly="true"/>

                <asp:BoundField 
                        DataField="Nombre" 
                        HeaderText="Nombre" 
                        ItemStyle-Width="100px"
                        SortExpression="Nombre" />

                <asp:BoundField 
                        DataField="Correo" 
                        HeaderText="Correo Electrónico" 
                        SortExpression="Correo"
                        ItemStyle-Width="150px"/>

                <asp:BoundField 
                        DataField="Telefono" 
                        HeaderText="Teléfono" 
                        SortExpression="Telefono"
                        ItemStyle-Width="100px"/>

                <asp:BoundField 
                    DataField="Direccion" 
                    HeaderText="Direccion" 
                    SortExpression="Direccion"
                    ItemStyle-Width="100px"/>

                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

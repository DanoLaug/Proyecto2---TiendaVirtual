<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="TiendaVirtual.Catalogo.Contacto1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content3" ContentPlaceHolderID="nav" runat="server">
    <div class="hero">
        <div class="container">
            <h2>Contáctanos</h2>
            <p>Realice un pedido o visite nuestra tienda física</p>
        </div>
    </div>
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <section class="contact-section">
        <div class="container">
            <div class="contact-form">
                <h3>Formulario de Contacto</h3>
                <div id="formContacto">
                    <div class="form-group">
                        <label for="txtNombre">Nombre:</label>
                        <asp:TextBox ID="txtNombre" runat="server" placeholder="Ingrese su nombre" required></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtEmail">Correo Electrónico:</label>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Ingrese su correo electrónico" type="email" required></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtTelefono">Teléfono:</label>
                        <asp:TextBox ID="txtTelefono" runat="server" placeholder="Ingrese su teléfono" type="tel" pattern="\d{10}" required></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtMensaje">Mensaje:</label>
                        <asp:TextBox ID="txtMensaje" runat="server" placeholder="Ingrese su mensaje" TextMode="MultiLine" required></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <!-- Botón simbólico de envío -->
                        <button id="enviar-formulario" type="submit" class="btn btn-primary" onclick="alertaEnvio()">Enviar Mensaje</button>
                        
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>


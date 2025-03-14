<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ubicacion.aspx.cs" Inherits="TiendaVirtual.Catalogo.Usuarios.Ubicacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content3" ContentPlaceHolderID="nav" runat="server">
    <div class="hero">
        <div class="container">
            <h2>Ubicación</h2>
            <p>Nos localizamos en 12 norte 1678, Puebla, Pue.</p>
        </div>
    </div>
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <section class="map-section">
        <div class="container">
            <div id="row-mapa">
                <div id="map"></div>
            </div>
        </div>
    </section>
</asp:Content>

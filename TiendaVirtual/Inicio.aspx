<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TiendaVirtual.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content3" ContentPlaceHolderID="nav" runat="server">
    <div class="hero">
        <div class="container">
            <h2>Bienvenido a la Tienda Virtual</h2>
            <p>Las mejores prendas de México: cómodas, económicas y modernas.</p>
            <button id="ver-productos" class="btn btn-primary" onclick="redirigirAProductos()">Ver nuestros Productos</button>
        </div>
    </div>
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>


<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <section class="about-us">
        <div class="container">
            <div class="about-us-content">
                <h3>Nuestra Historia</h3>
                <p>Desde nuestra fundación en 2010, nos hemos dedicado a ofrecer las mejores prendas de vestir en México. Nuestro compromiso es brindar comodidad, calidad y estilo a precios accesibles.</p>
            </div>
            <div id="about-us-image">
                <img src="/imagenes/about-us.jpeg" alt="Nuestra tienda">
            </div>
        </div>
    </section>
</asp:Content>


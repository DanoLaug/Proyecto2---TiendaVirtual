<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Medios.aspx.cs" Inherits="TiendaVirtual.Catalogo.Medios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content3" ContentPlaceHolderID="nav" runat="server">
    <div class="hero">
        <div class="container">
            <h2>Medios Audiovisuales</h2>
            <p>Videos de tendencias de moda</p>
        </div>
    </div>
</asp:Content>

<%-----------------------------------------------------------------------------------------------------------------%>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <section class="media-section">
        <div class="container">
            <h2>Podcast</h2>
            <div class="media-grid">
                <div class="media-item">
                    <audio controls>
                        <source src="/imagenes/audio.mp3" type="audio/mpeg">
                        <p>Tu navegador no soporta el elemento audio. Puedes <a href="audio.mp3">descargar el archivo MP3</a>.</p>
                    </audio>
                </div>
                <div class="media-item">
                    <audio controls>
                        <source src="/imagenes/audio.mp3" type="audio/mpeg">
                        <p>Tu navegador no soporta el elemento audio. Puedes <a href="audio.mp3">descargar el archivo MP3</a>.</p>
                    </audio>
                </div>
                <div class="media-item">
                    <audio controls>
                        <source src="/imagenes/audio.mp3" type="audio/mpeg">
                        <p>Tu navegador no soporta el elemento audio. Puedes <a href="audio.mp3">descargar el archivo MP3</a>.</p>
                    </audio>
                </div>
                <div class="media-item">
                    <audio controls>
                        <source src="/imagenes/audio.mp3" type="audio/mpeg">
                        <p>Tu navegador no soporta el elemento audio. Puedes <a href="audio.mp3">descargar el archivo MP3</a>.</p>
                    </audio>
                </div>
                <div class="media-item">
                    <audio controls>
                        <source src="/imagenes/audio.mp3" type="audio/mpeg">
                        <p>Tu navegador no soporta el elemento audio. Puedes <a href="audio.mp3">descargar el archivo MP3</a>.</p>
                    </audio>
                </div>
                <div class="media-item">
                    <audio controls>
                        <source src="/imagenes/audio.mp3" type="audio/mpeg">
                        <p>Tu navegador no soporta el elemento audio. Puedes <a href="audio.mp3">descargar el archivo MP3</a>.</p>
                    </audio>
                </div>
                <!-- Repite para más audios -->
            </div>
        </div>
    </section>

    <section class="media-section">
        <div class="container">
            <h2>Videos</h2>
            <div class="media-grid">
                <div class="media-item">
                    <video controls width="100%" height="auto" preload="metadata" poster="poster.jpg">
                        <source src="/imagenes/wrc.mp4" type="video/mp4">
                        <track kind="subtitles" srclang="es" src="subtitulos.vtt" label="Español">
                        <track kind="captions" srclang="en" src="captions.vtt" label="English">
                        <p>Tu navegador no soporta el elemento video. Puedes <a href="video.mp4">descargar el archivo MP4</a>.</p>
                    </video>
                </div>

                <div class="media-item">
                    <video controls width="100%" height="auto" preload="metadata" poster="poster.jpg">
                        <source src="/imagenes/wrc.mp4" type="video/mp4">
                        <track kind="subtitles" srclang="es" src="subtitulos.vtt" label="Español">
                        <track kind="captions" srclang="en" src="captions.vtt" label="English">
                        <p>Tu navegador no soporta el elemento video. Puedes <a href="video.mp4">descargar el archivo MP4</a>.</p>
                    </video>
                </div>

                <div class="media-item">
                    <video controls width="100%" height="auto" preload="metadata" poster="poster.jpg">
                        <source src="/imagenes/wrc.mp4" type="video/mp4">
                        <track kind="subtitles" srclang="es" src="subtitulos.vtt" label="Español">
                        <track kind="captions" srclang="en" src="captions.vtt" label="English">
                        <p>Tu navegador no soporta el elemento video. Puedes <a href="video.mp4">descargar el archivo MP4</a>.</p>
                    </video>
                </div>

                <div class="media-item">
                    <iframe src="https://www.youtube.com/embed/aPdo9LtobFM" title="YouTube video player" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                </div>
                <div class="media-item">
                    <iframe src="https://www.youtube.com/embed/sMy-F4osCaY" title="YouTube video player" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                </div>
                <div class="media-item">
                    <iframe src="https://www.youtube.com/embed/35qoRTwBluM" title="YouTube video player" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                </div>
                <!-- Repite para más videos -->
            </div>
        </div>
    </section>
</asp:Content>



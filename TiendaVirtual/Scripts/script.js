// JavaScript



// Fijar la barra de navegación al hacer scroll
window.addEventListener('scroll', () => {
    const navbar = document.querySelector('.navbar');
    if (window.scrollY > 0) {
        navbar.classList.add('fixed');
    } else {
        navbar.classList.remove('fixed');
    }
});

// Mapa usando Leaflet
var map = L.map('map').setView([19.082641419406418, -98.21346873068721], 13);

L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(map);

L.marker([19.082641419406418, -98.21346873068721]).addTo(map)
    .bindPopup('A pretty CSS popup.<br> Easily customizable.')
    .openPopup();

var marker = L.marker([19.082641419406418, -98.21346873068721]).addTo(map);

//Envio de contacto
document.getElementById('enviar-formulario').addEventListener('click', alertaEnvio);
function alertaEnvio() {
    alert("Se envio el formulario")
}

//Ver productos
document.getElementById('ver-productos').addEventListener('click', redirigirAProductos);
function redirigirAProductos() {
    window.location.href = 'Productos.aspx';
}
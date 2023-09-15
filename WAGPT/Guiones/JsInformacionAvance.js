let porcentaje = 0;
const progresoBarra = document.getElementById('barra-progreso');
const porcentajeElemento = document.getElementById('porcentaje');



function actualizarProgresoBarra() {
    progresoBarra.style.width = porcentaje + '%';
    porcentajeElemento.textContent = porcentaje + '%';
}

function incrementoProgreso() {
    if (porcentaje < 100) {
        porcentaje += 10;
        actualizarProgresoBarra();
    }
}

function decrementoProgreso() {
    if (porcentaje > 0) {
        porcentaje -= 10;
        actualizarProgresoBarra();
    }
}



function MostrarDiv1() {
    var div1 = document.getElementById("Div1");
    div1.style.display = "block";
    var div2 = document.getElementById("Div2");
    div2.style.display = "none";
    var div3 = document.getElementById("Div3");
    div3.style.display = "none";
    var div4 = document.getElementById("Div4");
    div4.style.display = "none";
    //posicion barra animada

    var barra = document.getElementById("BarraAnimacion");
    barra.style.display = "block";
    barra.style.top = "228px";

    var div = document.querySelector(".div-detras");
    div.style.animation = "none"; // Detener la animación
    void div.offsetWidth; // Reiniciar la animación (repintar)
    div.style.animation = "crecer 0.5s ease"; // Iniciar la animación nuevamente
    div.style.width = "500px"; // Cambia el ancho
    // Cambiar las propiedades CSS de .esquina-superior-derecha
    var esquinaSuperiorDerecha = document.querySelector(".Contenedor-Botones");
    esquinaSuperiorDerecha.style.position = "absolute";
    esquinaSuperiorDerecha.style.top = "210px";
    esquinaSuperiorDerecha.style.left = "25px";
    esquinaSuperiorDerecha.style.padding = "10px";
};
function MostrarDiv2() {
    var div1 = document.getElementById("Div1");
    div1.style.display = "none";
    //div1.style.
    var div2 = document.getElementById("Div2");
    div2.style.display = "block";
    var div3 = document.getElementById("Div3");
    div3.style.display = "none";
    var div4 = document.getElementById("Div4");
    div4.style.display = "none";
    //posicion contenedor 
    var esquinaSuperiorDerecha = document.querySelector(".Contenedor-Botones");
    esquinaSuperiorDerecha.style.position = "absolute";
    esquinaSuperiorDerecha.style.top = "210px";
    esquinaSuperiorDerecha.style.left = "25px";
    esquinaSuperiorDerecha.style.padding = "10px";
    //posicion barra Animada
    var barra = document.getElementById("BarraAnimacion");
    barra.style.display = "block";
    barra.style.top = "288px";
    var div = document.querySelector(".div-detras");
    div.style.animation = "none"; // Detener la animación
    void div.offsetWidth; // Reiniciar la animación (repintar)
    div.style.animation = "crecer 0.5s ease"; // Iniciar la animación nuevamente
    div.style.width = "500px"; // Cambia el ancho

};
function MostrarDiv3() {
    var div1 = document.getElementById("Div1");
    div1.style.display = "none";
    var div2 = document.getElementById("Div2");
    div2.style.display = "none";
    var div3 = document.getElementById("Div3");
    div3.style.display = "block";
    var div4 = document.getElementById("Div4");
    div4.style.display = "none";
    //posicion contenedor 
    var esquinaSuperiorDerecha = document.querySelector(".Contenedor-Botones");
    esquinaSuperiorDerecha.style.position = "absolute";
    esquinaSuperiorDerecha.style.top = "210px";
    esquinaSuperiorDerecha.style.left = "25px";
    esquinaSuperiorDerecha.style.padding = "10px";
    //posicion barra Animada
    var barra = document.getElementById("BarraAnimacion");
    barra.style.display = "block";
    barra.style.top = "348px";
    var div = document.querySelector(".div-detras");
    div.style.animation = "none"; // Detener la animación
    void div.offsetWidth; // Reiniciar la animación (repintar)
    div.style.animation = "crecer 0.5s ease"; // Iniciar la animación nuevamente
    div.style.width = "500px"; // Cambia el ancho

};
function MostrarDiv4() {
    var div1 = document.getElementById("Div1");
    div1.style.display = "none";
    var div2 = document.getElementById("Div2");
    div2.style.display = "none";
    var div3 = document.getElementById("Div3");
    div3.style.display = "none";
    var div4 = document.getElementById("Div4");
    div4.style.display = "block";
    //posicion contenedor 
    var esquinaSuperiorDerecha = document.querySelector(".Contenedor-Botones");
    esquinaSuperiorDerecha.style.position = "absolute";
    esquinaSuperiorDerecha.style.top = "210px";
    esquinaSuperiorDerecha.style.left = "25px";
    esquinaSuperiorDerecha.style.padding = "10px";
    //posicion barra Animada
    var barra = document.getElementById("BarraAnimacion");
    barra.style.display = "block";
    barra.style.top = "400px";
    var div = document.querySelector(".div-detras");
    div.style.animation = "none"; // Detener la animación
    void div.offsetWidth; // Reiniciar la animación (repintar)
    div.style.animation = "crecer 0.5s ease"; // Iniciar la animación nuevamente
    div.style.width = "500px"; // Cambia el ancho
};


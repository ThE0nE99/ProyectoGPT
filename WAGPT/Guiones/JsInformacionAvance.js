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

actualizarProgresoBarra();
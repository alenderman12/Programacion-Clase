let nombres = [];

function Agregar(nombre) {
    nombres.push(nombre);
    nombres.sort();
    Listar();
    console.log(nombres);
}

function Eliminar(nombre) {
    posicion = nombres.indexOf(nombre);
    if (posicion != -1) {
        nombres.splice(posicion, 1);
    }
    Listar();   
}

function Listar() {
    let lista = "";
    for (let i = 0; i < nombres.length; i++) {
        lista += nombres[i] + "<br>"
    }

    document.getElementById("lista").innerHTML = lista;
} 
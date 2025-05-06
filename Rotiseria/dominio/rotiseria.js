function CargarValores(dia) {
    
}

function Inicio() {
    LimpiarCajas();

}

function LimpiarCajas() {
    document.getElementById("frm-entradas").reset();
    document.getElementById("nombre-entrada-1").focus();
    document.getElementById("imagen-entrada-muestra").style.display = "none";
    document.getElementById("etiqueta-muestra").style.display = "none";
}

function AgregarEntrada() {
    let nombre1 = document.getElementById("nombre-entrada-1").value;
    let precio1 = document.getElementById("precio-entrada-1").value;
    let imagenLink = document.getElementById("imagen-entrada").value;

    let lista = document.getElementById("lista").options;
    let item = new Option("Nombre 1: " + nombre1 + " - Precio 1: " + precio1);


    if(nombre1 != "" && precio1 != "" && precio1 >= 0) {
        lista.add(item);
        LimpiarCajas();
        
        if(imagenLink != "") {
            document.getElementById("imagen-entrada-muestra").style.display = "block";
            document.getElementById("etiqueta-muestra").style.display = "block";
            document.getElementById("imagen-entrada-muestra").src = imagenLink;
        }
    }
}
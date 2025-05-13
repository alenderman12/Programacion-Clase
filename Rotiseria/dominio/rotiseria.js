let elementos = [];

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
    
    if(imagenLink == "") {
        alert("Ingrese imagen");
        return;
    }    

    if(nombre1 == "") {
        alert("Ingrese nombre");
        return;
    }
    
    if(precio1 == "") {
        alert("Ingrese precio");
        return;
    }
    
    if(isNaN(precio1)) {
        alert("El precio no puede contener letras");
        return;
    }

    ListarEntradas(nombre1, precio1, imagenLink);

    LimpiarCajas();
}

function ListarEntradas(nombre, precio, imagen) {
    let elemento ='<tr>'+
                    `<th>${nombre}</th>`+
                    `<th>$${precio}</th>`+
                    `<th><img src="${imagen}"></th>`+
                '</tr>';

    document.getElementById("tabla").innerHTML += elemento;
}

function CargarImagen(imagenLink) {
    if(imagenLink == "") {
        alert("Ingrese imagen");
        return;
    }

    document.getElementById("imagen-entrada-muestra").style.display = "block";
    document.getElementById("etiqueta-muestra").style.display = "block";
    document.getElementById("imagen-entrada-muestra").src = imagenLink;
};
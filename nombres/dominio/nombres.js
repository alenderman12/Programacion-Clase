let nombres = MemGet(0);
if(!nombres) {
    nombres = [];
}

function Agregar(nombre) {
    if(nombre.trim() != "" && !Existe(nombre)) {
        nombres.push(nombre);
        document.getElementById('nombre').value = "";
        document.getElementById('nombre').focus();
        Listar();
    }
}

function Eliminar(nombre) {
    let posicion = document.getElementById('lista').value;
    if(posicion != "") {
        nombres.splice(posicion, 1);
        document.getElementById('nombre').value = "";
        Listar();   
    }
}

function Modificar() {
    let posicion = document.getElementById('lista').value;
    let nombre = document.getElementById('nombre').value.trim();
    if(posicion == "") {
        alert("Seleccione una posicion");
        return;
    }
    if(nombre == "") {
        alert("Escriba un nombre");
        return;
    }
    if(Existe(nombre)) {
        alert("Nombre ya ingresado");
        return;
    }

    document.getElementById('nombre').value = "";
    nombres.splice(posicion, 1, nombre);

    Listar();
}

function Listar() {
    console.log(nombres);
    nombres.sort();
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let i = 0; i < nombres.length; i++) {
        let elemento = new Option(nombres[i], i);
        lista.add(elemento);
    }
    MemSet(0, nombres);
} 

function Seleccionar() {
    let posicion = document.getElementById('lista').value;
    document.getElementById('nombre').value = nombres[posicion];
        document.getElementById('nombre').focus();
}

function Existe(nombre) {
    return nombres.indexOf(nombre) != -1;
}

function MemSet(clave, valor) {
    localStorage.setItem(clave, JSON.stringify(valor));
}

function MemGet(clave) {
    const datos = localStorage.getItem(clave);

    if(datos) {
        return JSON.parse(datos);
    }
    return null;
}
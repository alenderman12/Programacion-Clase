import { Memoria } from "./memoria.js";
import { Persona } from "./persona.js";

let memoria = new Memoria();

let personas = memoria.MemGet(0);
if(!personas) {
    personas = [];
}

function Agregar() {

    let id = parseInt(document.getElementById("id").value);
    let nombre = document.getElementById("nombre").value;
    let apellido = document.getElementById("apellido").value;
    let direcccion = document.getElementById("direccion").value;
    let telefono = document.getElementById("telefono").value;
    let edad = parseInt(document.getElementById("edad").value);

    if(!id || !nombre || !apellido || !direcccion || !telefono || !edad) {
        alert("Complete todos los campos");
        return;
    }
    
    const unaPersona = new Persona(id, nombre, apellido, direcccion, telefono, edad);
    if(BuscarPosicion(id) != -1) {
        alert("Esta persona ya existe");
        return;
    }
    personas.push(unaPersona);

    memoria.MemSet(0, personas);
    Listar();
}

function Eliminar() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicion(document.getElementById('lista').value);

    if(posicion != -1) {
        personas.splice(posicion, 1);
        Listar();
    }
}

function Modificar() {
    let posicion = BuscarPosicion(document.getElementById('lista').value);
    let id = parseInt(document.getElementById("id").value);
    let nombre = document.getElementById("nombre").value;
    let apellido = document.getElementById("apellido").value;
    let direcccion = document.getElementById("direccion").value;
    let telefono = document.getElementById("telefono").value;
    let edad = parseInt(document.getElementById("edad").value);

    if(!id || !nombre || !apellido || !direcccion || !telefono || !edad) {
        alert("Complete todos los campos");
        return;
    }

    LimpiarCajas();
    personas.splice(posicion, 1, new Persona(id,nombre,apellido,direcccion,telefono,edad));

    Listar();
}

function Listar() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoPersona of personas) {
        let elemento = new Option(objetoPersona.id + " : " + objetoPersona.nombre + " : " + objetoPersona.apellido + " : " + objetoPersona.direcccion + " : " + objetoPersona.telefono + " : " + objetoPersona.edad, objetoPersona.id);
        lista.add(elemento);
    }
    memoria.MemSet(0, personas);
} 

function Seleccionar() {
    let id = document.getElementById('lista').value;

    for (let objetoPersona of personas) {
            if(objetoPersona.id == id) {                
                document.getElementById('id').value        = objetoPersona.id;
                document.getElementById('nombre').value    = objetoPersona.nombre;
                document.getElementById('apellido').value  = objetoPersona.apellido;
                document.getElementById('telefono').value  = objetoPersona.telefono;
                document.getElementById('direccion').value = objetoPersona.direcccion;
                document.getElementById('edad').value      = objetoPersona.edad;
            }
    }
}

function LimpiarCajas() {    
    document.getElementById('id').value = "";
    document.getElementById('nombre').value = "";
    document.getElementById('apellido').value = "";
    document.getElementById('telefono').value = "";
    document.getElementById('direccion').value = "";
    document.getElementById('edad').value = "";
    document.getElementById('lista').value = 0;
}

function BuscarPosicion(id) {
    for (let i = 0; i < personas.length; i++) {
        const objetoPersona = personas[i];
        if(objetoPersona.id == id) {
            return i;
        }
    }
    return -1;
}

window.Agregar = Agregar;
window.Modificar = Modificar;
window.Eliminar = Eliminar;
window.Listar = Listar;
window.Seleccionar = Seleccionar;
window.LimpiarCajas = LimpiarCajas;
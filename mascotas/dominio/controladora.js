import { Memoria } from "./memoria.js";
import { Persona } from "./persona.js";
import { Mascota } from "./mascota.js";
import { memo } from "react";

let memoria = new Memoria();

let personas = memoria.MemGet(0);
let mascotas = memoria.MemGet(1);
let actualIdPersona = memoria.MemGet("idPersona");
let actualIdMascota = memoria.MemGet("idMascota");
if(!personas) {
    personas = [];
}
if(!mascotas) {
    mascotas = [];
}
if(!actualIdPersona) {
    actualIdPersona = 1;
}
if(!actualIdMascota) {
    actualIdMascota = 1;
}

//#region Metodos Persona

function Agregar() {
    let nombre = document.getElementById('nombre').value.trim();
    let apellido = document.getElementById("apellido").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let direcccion = document.getElementById("direccion").value.trim();
    let edad = parseInt(document.getElementById('edad').value);

    if(!nombre || !apellido || !telefono || !direcccion || !edad) {
        alert("Complete todos los campos");
        return;
    }
    
    const unaPersona = new Persona(actualIdPersona, nombre, apellido, telefono, direcccion, edad);
    if(BuscarPosicionMascota(actualIdPersona) != -1) {
        alert("Esta persona ya existe");
        return;
    }
    mascotas.push(unaPersona);
    actualIdPersona++;
    memoria.MemSet("idPersona", actualIdPersona);
    memoria.MemSet(0, personas);
    Listar();
    LimpiarCajas();
}

function Eliminar() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicionPersona(id);

    if(posicion != -1) {
        personas.splice(posicion, 1);
        for (let i = posicion; i < personas.length; i++) {
            const persona = personas[i];

            persona.id = persona.id - 1;
        }
        memoria.MemSet("idPersona", --actualIdPersona);
        ListarMascota();
    }

    document.getElementById('lista').value = 1;
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
    personas.splice(posicion, 1, new Persona(id, nombre, apellido, direcccion, telefono, edad));

    Listar();
}

function Listar() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoPersona of personas) {
        let elemento = new Option(objetoPersona.id + " : " + objetoPersona.nombre + " : " + objetoPersona.apellido + " : " + 
            objetoPersona.direcccion + " : " + objetoPersona.telefono + " : " + objetoPersona.edad, objetoPersona.id);
        lista.add(elemento);
    }
    memoria.MemSet(0, personas);
} 

function Seleccionar() {
    let id = document.getElementById('lista').value;

    for (let objetoPersona of personas) {
            if(objetoPersona.id == id) {                
                document.getElementById('nombre').value    = objetoPersona.nombre;
                document.getElementById('apellido').value  = objetoPersona.apellido;
                document.getElementById('telefono').value  = objetoPersona.telefono;
                document.getElementById('direccion').value = objetoPersona.direcccion;
                document.getElementById('edad').value      = objetoPersona.edad;
            }
    }
}

function LimpiarCajas() {
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

//#endregion

//#region Metodos Mascota

function AgregarMascota() {
    let nombre = document.getElementById('nombre').value.trim();
    let especie = document.getElementById("especie").value.trim();
    let raza = document.getElementById("raza").value.trim();
    let sexo = document.getElementById("sexo").value.trim();
    let edad = parseInt(document.getElementById('edad').value);

    if(!nombre || !especie || !raza || !sexo || !edad) {
        alert("Complete todos los campos");
        return;
    }
    
    const unaMascota = new Mascota(actualIdMascota, nombre, especie, raza, sexo, edad);
    if(BuscarPosicionMascota(actualIdMascota) != -1) {
        alert("Esta mascota ya existe");
        return;
    }
    mascotas.push(unaMascota);
    actualIdMascota++;
    memoria.MemSet("idMascota", actualIdMascota);
    memoria.MemSet(1, mascotas);
    ListarMascota();
    LimpiarCajasMascota();
}

function EliminarMascota() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicionMascota(id);

    if(posicion != -1) {
        mascotas.splice(posicion, 1);
        for (let i = posicion; i < mascotas.length; i++) {
            const mascota = mascotas[i];

            mascota.id = mascota.id - 1;
        }
        memoria.MemSet("idMascota", --actualIdMascota);
        ListarMascota();
    }

    document.getElementById('lista').value = 1;
}

function ModificarMascota() {
    let posicion = BuscarPosicionMascota(document.getElementById('lista').value);
    let id = document.getElementById('lista').value;
    let nombre = document.getElementById('nombre').value.trim();
    let especie = document.getElementById("especie").value.trim();
    let raza = document.getElementById("raza").value.trim();
    let sexo = document.getElementById("sexo").value.trim();
    let edad = parseInt(document.getElementById('edad').value);

    if(!nombre || !especie || !raza || !sexo || !edad) {
        alert("Complete todos los campos");
        return;
    }

    LimpiarCajasMascota();
    mascotas.splice(posicion, 1, new Mascota(id, nombre, especie, raza, sexo, edad));

    ListarMascota();
}

function ListarMascota() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoMascota of mascotas) {
        let elemento = new Option(objetoMascota.id + " : " + objetoMascota.nombre + " : " + objetoMascota.especie + " : " + 
            objetoMascota.raza + " : " + objetoMascota.sexo + " : " + objetoMascota.edad + (objetoMascota.edad == 1 ? " año" : " años"), objetoMascota.id);
        lista.add(elemento);
    }
    memoria.MemSet(1, mascotas);
} 

function SeleccionarMascota() {
    let id = document.getElementById('lista').value;

    for (let objetoMascota of mascotas) {
            if(objetoMascota.id == id) {                
                document.getElementById('nombre').value  = objetoMascota.nombre;
                document.getElementById('especie').value = objetoMascota.especie;
                document.getElementById('raza').value    = objetoMascota.raza;
                document.getElementById('sexo').value    = objetoMascota.sexo;
                document.getElementById('edad').value    = objetoMascota.edad;
            }
    }
}

function LimpiarCajasMascota() {    
    document.getElementById('nombre').value = "";
    document.getElementById('especie').value = "";
    document.getElementById('raza').value = "";
    document.getElementById('sexo').value = "";
    document.getElementById('edad').value = "";
    document.getElementById('lista').value = 0;
}

function BuscarPosicionMascota(id) {
    for (let i = 0; i < mascotas.length; i++) {
        const objetoMascota = mascotas[i];
        if(objetoMascota.id == id) {
            return i;
        }
    }
    return -1;
}

//#endregion

window.Agregar = Agregar;
window.Modificar = Modificar;
window.Eliminar = Eliminar;
window.Listar = Listar;
window.Seleccionar = Seleccionar;
window.LimpiarCajas = LimpiarCajas;

window.AgregarMascota = AgregarMascota;
window.ModificarMascota = ModificarMascota;
window.EliminarMascota = EliminarMascota;
window.ListarMascota = ListarMascota;
window.SeleccionarMascota = SeleccionarMascota;
window.LimpiarCajasMascota = LimpiarCajasMascota;
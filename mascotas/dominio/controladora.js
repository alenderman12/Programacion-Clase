import { Memoria } from "./memoria.js";
import { Persona } from "./persona.js";
import { Mascota } from "./mascota.js";
import { Adopcion } from "./adopcion.js";

let memoria = new Memoria();

let personas = memoria.MemGet(0);
let mascotas = memoria.MemGet(1);
let adopciones = memoria.MemGet(2);

let actualIdPersona = memoria.MemGet("idPersona");
let actualIdMascota = memoria.MemGet("idMascota");
let actualIdAdopcion = memoria.MemGet("idAdopcion");

if(!personas) {
    personas = [];
}
if(!mascotas) {
    mascotas = [];
}
if(!adopciones) {
    adopciones = [];
}
if(!actualIdPersona) {
    actualIdPersona = 1;
}
if(!actualIdMascota) {
    actualIdMascota = 1;
}
if(!actualIdAdopcion) {
    actualIdAdopcion = 1;
}

//#region Metodos Persona

function Agregar() {
    let nombre = document.getElementById('nombre').value.trim();
    let apellido = document.getElementById("apellido").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let direccion = document.getElementById("direccion").value.trim();
    let edad = parseInt(document.getElementById('edad').value);

    if(!nombre || !apellido || !telefono || !direccion || !edad) {
        alert("Complete todos los campos");
        return;
    }
    
    const unaPersona = new Persona(actualIdPersona, nombre, apellido, telefono, direccion, edad);
    if(BuscarPosicion(actualIdPersona) != -1) {
        alert("Esta persona ya existe");
        return;
    }
    personas.push(unaPersona);
    actualIdPersona++;
    memoria.MemSet("idPersona", actualIdPersona);
    memoria.MemSet(0, personas);
    Listar();
    LimpiarCajas();
}

function Eliminar() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicion(id);

    if(posicion != -1) {
        personas.splice(posicion, 1);
        for (let i = posicion; i < personas.length; i++) {
            const persona = personas[i];

            persona.id = persona.id - 1;
        }
        memoria.MemSet("idPersona", --actualIdPersona);
        Listar();
    }

    document.getElementById('lista').value = 1;
}

function Modificar() {
    let posicion = BuscarPosicion(document.getElementById('lista').value);
    let id = document.getElementById('lista').value;
    let nombre = document.getElementById('nombre').value.trim();
    let apellido = document.getElementById("apellido").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let direccion = document.getElementById("direccion").value.trim();
    let edad = parseInt(document.getElementById('edad').value);

    if(!nombre || !apellido || !telefono || !direccion || !edad) {
        alert("Complete todos los campos");
        return;
    }

    LimpiarCajas();
    personas.splice(posicion, 1, new Persona(id, nombre, apellido, telefono, direccion, edad));

    Listar();
}

function Listar() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoPersona of personas) {
        let elemento = new Option(objetoPersona.id + " : " + objetoPersona.nombre + " : " + objetoPersona.apellido + " : " + 
            objetoPersona.telefono + " : " + objetoPersona.direccion + " : " + objetoPersona.edad + (objetoPersona.edad == 1 ? " año" : " años"), objetoPersona.id);
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
                document.getElementById('direccion').value = objetoPersona.direccion;
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
    
    const unaMascota = new Mascota(actualIdMascota, nombre, especie, raza, sexo, edad, false);
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
    mascotas.splice(posicion, 1, new Mascota(id, nombre, especie, raza, sexo, edad, BuscarPosicionMascota(id).adoptado));

    ListarMascota();
}

function ListarMascota() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoMascota of mascotas) {
        let elemento = new Option(objetoMascota.id + " : " + objetoMascota.nombre + " : " + objetoMascota.especie + " : " + 
            objetoMascota.raza + " : " + objetoMascota.sexo + " : " + objetoMascota.edad + (objetoMascota.edad == 1 ? " año" : " años") + " : "
             + (objetoMascota.adoptado ? "Si" : "No"), objetoMascota.id);

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

function AdoptarMascota(idMascota) {
    for (const objMascota of mascotas) {
        if(objMascota.id == idMascota) {
            objMascota.adoptado = true;
        }
    }

    memoria.MemSet(1, mascotas);
}

function DevolverMascota(idMascota) {
    for (const objMascota of mascotas) {
        if(objMascota.id == idMascota) {
            objMascota.adoptado = false;
        }
    }

    memoria.MemSet(1, mascotas);
}

//#endregion

//#region Metodos Adopcion

function InicioAdopcion() {
    let selectPersonas = document.getElementById("persona");
    let selectMascotas = document.getElementById("mascota");

    for (let persona of personas) {
        selectPersonas.innerHTML += `<option value="${persona.id}">${persona.nombre} ${persona.apellido}</option>`
    }    
    for (let mascota of mascotas) {
        selectMascotas.innerHTML += `<option value="${mascota.id}">${mascota.especie} ${mascota.nombre}</option>`
    }

    ListarAdopcion();
}

function AgregarAdopcion() {
    let fecha = document.getElementById('fecha').value.trim();
    let persona = document.getElementById("persona").value.trim();
    let mascota = document.getElementById("mascota").value.trim();

    if(!fecha || !persona || !mascota) {
        alert("Complete todos los campos");
        return;
    }

    persona = BuscarPosicion(persona);
    mascota = BuscarPosicionMascota(mascota);
    if (persona == -1 || mascota == -1) {
        alert("Esa persona/mascota no existe");
    }   
    
    const unaAdopcion = new Adopcion(actualIdAdopcion, fecha, personas[persona], mascotas[mascota]);
    if(BuscarPosicionAdopcion(actualIdAdopcion) != -1) {
        alert("Esta adopcion ya existe");
        return;
    }
    AdoptarMascota(mascota+1);
    adopciones.push(unaAdopcion);
    actualIdAdopcion++;
    memoria.MemSet("idAdopcion", actualIdAdopcion);
    memoria.MemSet(2, adopciones);
    ListarAdopcion();
    LimpiarCajasAdopcion();
}

function EliminarAdopcion() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicionAdopcion(id);

    DevolverMascota(adopciones[posicion].mascota.id);

    if(posicion != -1) {
        adopciones.splice(posicion, 1);
        for (let i = posicion; i < adopciones.length; i++) {
            const adopcion = adopciones[i];

            adopcion.id = adopcion.id - 1;
        }
        memoria.MemSet("idAdopcion", --actualIdAdopcion);
        ListarAdopcion();
    }

    document.getElementById('lista').value = 1;
}

function ModificarAdopcion() {
    let posicion = BuscarPosicionAdopcion(document.getElementById('lista').value);
    let id = document.getElementById('lista').value;
    let fecha = document.getElementById('fecha').value.trim();
    let persona = document.getElementById("persona").value.trim();
    let mascota = document.getElementById("mascota").value.trim();

    if(!fecha || !persona || !mascota) {
        alert("Complete todos los campos");
        return;
    }

    if(mascota.id != adopciones[posicion].mascota.id) {
        AdoptarMascota(mascota.id);
        DevolverMascota(adopciones[posicion].mascota.id);
    }

    LimpiarCajasAdopcion();
    adopciones.splice(posicion, 1, new Adopcion(id, fecha, personas[BuscarPosicion(persona)], mascotas[BuscarPosicionMascota(mascota)]));

    ListarAdopcion();
}

function ListarAdopcion() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;
    
    for (let objetoAdopcion of adopciones) {
        let elemento = new Option(objetoAdopcion.id + " : " + objetoAdopcion.fecha + " : " + objetoAdopcion.persona.nombre + " " + objetoAdopcion.persona.apellido +" : " + objetoAdopcion.mascota.nombre, objetoAdopcion.id);
        lista.add(elemento);
    }
    memoria.MemSet(2, adopciones);
} 

function SeleccionarAdopcion() {
    let id = document.getElementById('lista').value;

    for (let objetoAdopcion of adopciones) {
            if(objetoAdopcion.id == id) {                
                document.getElementById('fecha').value    = objetoAdopcion.fecha;
                document.getElementById('persona').value  = objetoAdopcion.persona.id;
                document.getElementById('mascota').value  = objetoAdopcion.mascota.id;
            }
    }

}

function LimpiarCajasAdopcion() {
    document.getElementById('fecha').value = "";
    document.getElementById('persona').value = "";
    document.getElementById('mascota').value = "";
}

function BuscarPosicionAdopcion(id) {
    for (let i = 0; i < adopciones.length; i++) {
        const objetoAdopcion = adopciones[i];
        if(objetoAdopcion.id == id) {
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

window.InicioAdopcion = InicioAdopcion;
window.AgregarAdopcion = AgregarAdopcion;
window.ModificarAdopcion = ModificarAdopcion;
window.EliminarAdopcion = EliminarAdopcion;
window.ListarAdopcion = ListarAdopcion;
window.SeleccionarAdopcion = SeleccionarAdopcion;
window.LimpiarCajasAdopcion = LimpiarCajasAdopcion;
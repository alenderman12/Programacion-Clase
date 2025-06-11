import { Memoria } from "./memoria.js";
import { Pelicula } from "./pelicula.js";

let memoria = new Memoria();

let peliculas = memoria.MemGet(0);

let actualIdPelicula = memoria.MemGet("idPelicula");

if(!peliculas) {
    peliculas = [];
}
if(!actualIdPelicula) {
    actualIdPelicula = 1;
}

//#region Metodos Pelicula

function Agregar() {
    let nombre = document.getElementById('nombre').value.trim();
    let genero = document.getElementById("genero").value.trim();
    let director = document.getElementById("director").value.trim();
    let pais = document.getElementById("pais").value.trim();
    let precio = parseInt(document.getElementById('precio').value);

    if(!nombre || !genero || !director || !pais || !precio) {
        alert("Complete todos los campos");
        return;
    }
    
    const unaPelicula = new Pelicula(actualIdPelicula, nombre, genero, director, pais, precio, false);
    if(BuscarPosicion(actualIdPelicula) != -1) {
        alert("Esta pelicula ya esta ingresada");
        return;
    }
    peliculas.push(unaPelicula);
    actualIdPelicula++;
    memoria.MemSet("idPelicula", actualIdPelicula);
    memoria.MemSet(0, peliculas);
    Listar();
    LimpiarCajas();
}

function Eliminar() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicion(id);

    if(posicion != -1) {
        peliculas.splice(posicion, 1);
        for (let i = posicion; i < peliculas.length; i++) {
            const pelicla = peliculas[i];

            pelicla.id = pelicla.id - 1;
        }
        memoria.MemSet("idPelicula", --actualIdPelicula);
        Listar();
    }

    document.getElementById('lista').value = 1;
}

function Modificar() {
    let posicion = BuscarPosicion(document.getElementById('lista').value);
    let nombre = document.getElementById('nombre').value.trim();
    let genero = document.getElementById("genero").value.trim();
    let director = document.getElementById("director").value.trim();
    let pais = document.getElementById("pais").value.trim();
    let precio = parseInt(document.getElementById('precio').value);

    if(!nombre || !genero || !director || !pais || !precio) {
        alert("Complete todos los campos");
        return;
    }

    LimpiarCajas();
    peliculas.splice(posicion, 1, new Pelicula(actualIdPelicula, nombre, genero, director, pais, precio, peliculas[posicion].alquilada));

    Listar();
}

function Listar() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoPelicula of peliculas) {
        let elemento = new Option(objetoPelicula.id + " : " + objetoPelicula.nombre + " : " + objetoPelicula.genero + " : " + 
            objetoPelicula.director + " : " + objetoPelicula.pais + " : " + "UYU$" + objetoPelicula.precio + " : " + (objetoPelicula.alquilada ? "Si" : "No"), objetoPelicula.id);
        lista.add(elemento);
    }
    memoria.MemSet(0, peliculas);
} 

function Seleccionar() {
    let id = document.getElementById('lista').value;

    for (let objetoPelicula of peliculas) {
            if(objetoPelicula.id == id) {                
                document.getElementById('nombre').value   = objetoPelicula.nombre;
                document.getElementById('genero').value   = objetoPelicula.genero;
                document.getElementById('director').value = objetoPelicula.director;
                document.getElementById('pais').value     = objetoPelicula.pais;
                document.getElementById('precio').value   = objetoPelicula.precio;
            }
    }
}

function LimpiarCajas() {
    document.getElementById('nombre').value = "";
    document.getElementById('genero').value = "";
    document.getElementById('director').value = "";
    document.getElementById('pais').value = "";
    document.getElementById('precio').value = "";
    document.getElementById('lista').value = 0;
}

function BuscarPosicion(id) {
    for (let i = 0; i < peliculas.length; i++) {
        const objetoPelicula = peliculas[i];
        if(objetoPelicula.id == id) {
            return i;
        }
    }
    return -1;
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
    let  mascota = document.getElementById("mascota").value.trim();

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
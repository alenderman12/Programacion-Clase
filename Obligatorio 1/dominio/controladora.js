import { Memoria } from "./memoria.js";
import { Pelicula } from "./pelicula.js";
import { Alquiler } from "./alquiler.js";

let memoria = new Memoria();

let peliculas = memoria.MemGet(0);
let alquileres = memoria.MemGet(1);

let actualIdPelicula = memoria.MemGet("idPelicula");
let actualIdAlquiler= memoria.MemGet("idAlquiler");

if(!peliculas) {
    peliculas = [];
}
if(!alquileres) {
    alquileres = [];
}

if(!actualIdPelicula) {
    actualIdPelicula = 1;
}
if(!actualIdAlquiler) {
    actualIdAlquiler = 1;
}

//#region Metodos Pelicula

function Agregar() {
    let nombre = document.getElementById('nombre').value.trim();
    let genero = document.getElementById("genero").value.trim();
    let director = document.getElementById("director").value.trim();
    let pais = document.getElementById("pais").value.trim();
    let precio = parseInt(document.getElementById('precio').value);
    let imagen = document.getElementById("imagen").value.trim();

    if(!nombre || !genero || !director || !pais || !precio || !imagen) {
        alert("Complete todos los campos");
        return;
    }
    
    const unaPelicula = new Pelicula(actualIdPelicula, nombre, genero, director, pais, precio, imagen, false);
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
            const pelicula = peliculas[i];

            pelicula.id = pelicula.id - 1;
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
    let imagen = document.getElementById("imagen").value.trim();

    if(!nombre || !genero || !director || !pais || !precio || !imagen) {
        alert("Complete todos los campos");
        return;
    }

    LimpiarCajas();
    peliculas.splice(posicion, 1, new Pelicula(peliculas[posicion].id, nombre, genero, director, pais, precio, peliculas[posicion].alquilada, imagen));

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
                document.getElementById('nombre').value          = objetoPelicula.nombre;
                document.getElementById('genero').value          = objetoPelicula.genero;
                document.getElementById('director').value        = objetoPelicula.director;
                document.getElementById('pais').value            = objetoPelicula.pais;
                document.getElementById('precio').value          = objetoPelicula.precio;
                document.getElementById('imagen').value          = objetoPelicula.imagen;
                document.getElementById('imagenVistaPrevia').src = objetoPelicula.imagen;
            }
    }
}

function LimpiarCajas() {
    document.getElementById('nombre').value = "";
    document.getElementById('genero').value = "";
    document.getElementById('director').value = "";
    document.getElementById('pais').value = "";
    document.getElementById('precio').value = "";
    document.getElementById('imagen').value = "";
    document.getElementById('imagenVistaPrevia').src = "";
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

function VistaPreviaImagen() {
    let enlaceImagen = document.getElementById('imagen').value.trim();

    document.getElementById('imagenVistaPrevia').src = enlaceImagen;
}

//#endregion

//#region Metodos Adopcion

function InicioAlquiler() {
    ListarSelectPeliculas()
    ListarAlquiler();
}

function ListarSelectPeliculas() {
    let selectPelicula = document.getElementById("pelicula");
    if(selectPelicula.innerHTML != null)
        selectPelicula.innerHTML = "";

    for (let pelicula of peliculas) {
        if(!pelicula.alquilada)
            selectPelicula.innerHTML += `<option value="${pelicula.id}">${pelicula.nombre}</option>`;
    }
}

function AgregarAlquiler() {
    let fecha = document.getElementById('fecha').value.trim();
    let nombre = document.getElementById("nombre").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let pelicula = document.getElementById("pelicula").value;

    if(!fecha || !nombre || !telefono || !pelicula) {
        alert("Complete todos los campos");
        return;
    }
    pelicula = BuscarPosicion(pelicula);
    if (pelicula == -1) {
        alert("Esa pelicula no existe");
    }

    const unAlquiler = new Alquiler(actualIdAlquiler, fecha, nombre, telefono, pelicula);
    if(BuscarPosicionAlquiler(actualIdAlquiler) != -1) {
        alert("Este alquiler ya existe");
        return;
    }
    peliculas[pelicula].alquilada = true;
    alquileres.push(unAlquiler);
    actualIdAlquiler++;
    memoria.MemSet("idAlquiler", actualIdAlquiler);
    memoria.MemSet(1, alquileres);
    ListarAlquiler();
    ListarSelectPeliculas();
    LimpiarCajasAlquiler();
}

function EliminarAlquiler() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicionAlquiler(id);

    if(posicion != -1) {
        alquileres[posicion].pelicula.alquilada = false;
        alquileres.splice(posicion, 1);
        for (let i = posicion; i < alquileres.length; i++) {
            const alquiler = alquileres[i];

            alquiler.id = alquiler.id - 1;
        }
        memoria.MemSet("idAlquiler", --actualIdAlquiler);
        ListarAlquiler();
    }

    document.getElementById('lista').value = 1;
}

function ModificarAlquiler() {
    let posicion = BuscarPosicionAlquiler(document.getElementById('lista').value);
    let fecha = document.getElementById('fecha').value.trim();
    let nombre = document.getElementById("nombre").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let pelicula = document.getElementById("pelicula").value;

    if(!fecha || !nombre || !telefono || !pelicula) {
        alert("Complete todos los campos");
        return;
    }

    alquileres[posicion].pelicula.alquilada = false;
    peliculas[BuscarPosicion(pelicula)].alquilada = true;
    LimpiarCajasAlquiler();
    alquileres.splice(posicion, 1, new Alquiler(alquileres[posicion].id, fecha, nombre, telefono, pelicula));

    ListarSelectPeliculas();
    ListarAdopcion();
}

function ListarAlquiler() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;
    
    for (let objetoAlquiler of alquileres) {
        console.log(objetoAlquiler);
        let elemento = new Option(objetoAlquiler.id + " : " + objetoAlquiler.fecha + " : " + objetoAlquiler.nombre + " : " + objetoAlquiler.telefono +" : " + objetoAlquiler, objetoAlquiler.id);
        lista.add(elemento);
    }
    memoria.MemSet(1, alquileres);
} 

function SeleccionarAlquiler() {
    let id = document.getElementById('lista').value;

    for (let objetoAlquiler of alquileres) {
            if(objetoAlquiler.id == id) {                
                document.getElementById('fecha').value    = objetoAlquiler.fecha;
                document.getElementById('nombre').value   = objetoAlquiler.nombre;
                document.getElementById('telefono').value = objetoAlquiler.telefono;
                document.getElementById('pelicula').value = objetoAlquiler.pelicula;
            }
    }
}

function LimpiarCajasAlquiler() {
    document.getElementById('fecha').value = "";
    document.getElementById('nombre').value = "";
    document.getElementById('telefono').value = "";
    document.getElementById('pelicula').value = "";
}

function BuscarPosicionAlquiler(id) {
    for (let i = 0; i < alquileres.length; i++) {
        const objetoAlquiler = alquileres[i];
        if(objetoAlquiler.id == id) {
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
window.VistaPreviaImagen = VistaPreviaImagen;

window.AgregarAlquiler = AgregarAlquiler;
window.ModificarAlquiler = ModificarAlquiler;
window.EliminarAlquiler = EliminarAlquiler;
window.ListarAlquiler = ListarAlquiler;
window.SeleccionarAlquiler = SeleccionarAlquiler;
window.LimpiarCajasAlquiler = LimpiarCajasAlquiler;
window.InicioAlquiler = InicioAlquiler;
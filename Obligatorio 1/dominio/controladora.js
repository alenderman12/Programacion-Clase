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
    let copias = parseInt(document.getElementById('copias').value);
    let imagen = document.getElementById("imagen").value.trim();

    if(!nombre || !genero || !director || !pais || !precio || !copias || !imagen) {
        alert("Complete todos los campos");
        return;
    }
    
    const unaPelicula = new Pelicula(actualIdPelicula, nombre, genero, director, pais, precio, copias, imagen, 0);
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

    if(posicion == -1) {
        alert("Seleccione una pelicula");
    }

    for(const alquiler of alquileres) {
        if(alquiler.pelicula == id) {
            alert("No se puede eliminar esta pelicula porque hay alquileres de esta");
            return 0;
        }
    }

    peliculas.splice(posicion, 1);
    for (let i = posicion; i < peliculas.length; i++) {
        const pelicula = peliculas[i];

        pelicula.id = pelicula.id - 1;
    }
    memoria.MemSet("idPelicula", --actualIdPelicula);
    Listar();

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

    if(posicion == -1) {
        alert("Seleccione la pelicula a modificar");
        return;
    }

    if(!nombre || !genero || !director || !pais || !precio || !imagen) {
        alert("Complete todos los campos");
        return;
    }

    LimpiarCajas();
    peliculas.splice(posicion, 1, new Pelicula(peliculas[posicion].id, nombre, genero, director, pais, precio, peliculas[posicion].copias, imagen, peliculas[posicion].ventas));

    Listar();
}

function Listar() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoPelicula of peliculas) {
        let elemento = new Option(objetoPelicula.id + " : " + objetoPelicula.nombre + " : " + objetoPelicula.genero + " : " + 
            objetoPelicula.director + " : " + objetoPelicula.pais + " : " + "UYU$" + objetoPelicula.precio + " : " + (objetoPelicula.copias - objetoPelicula.ventas), objetoPelicula.id);
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
                document.getElementById('copias').value          = objetoPelicula.copias;
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
    document.getElementById('copias').value = "";
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

//#region Metodos Alquiler

function InicioAlquiler() {
    ListarSelectPeliculas()
    ListarAlquiler();
}

function ListarSelectPeliculas() {
    let selectPelicula = document.getElementById("pelicula");
    if(selectPelicula.innerHTML != null)
        selectPelicula.innerHTML = '<option value="0" disabled selected>Seleccione una pelicula</option>';

    for (let pelicula of peliculas) {
        if(pelicula.ventas < pelicula.copias){
            selectPelicula.innerHTML += `<option value="${pelicula.id}">${pelicula.nombre} - UYU$${pelicula.precio} - Restantes: ${pelicula.copias - pelicula.ventas}</option>`;
        }
    }
}

function AgregarAlquiler() {
    let fecha = document.getElementById('fecha').value.trim();
    let nombre = document.getElementById("nombre").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let peliculaId = parseInt(document.getElementById("pelicula").value);
    let peliculaPosicion = BuscarPosicion(peliculaId);

    if(!fecha || !nombre || !telefono || !peliculaId) {
        alert("Complete todos los campos");
        return;
    }

    if (peliculaPosicion == -1) {
        alert("Esa pelicula no existe");
    }

    const unAlquiler = new Alquiler(actualIdAlquiler, fecha, nombre, telefono, peliculaId);
    if(BuscarPosicionAlquiler(actualIdAlquiler) != -1) {
        alert("Este alquiler ya existe");
        return;
    }
    peliculas[peliculaPosicion].ventas++;
    alquileres.push(unAlquiler);
    actualIdAlquiler++;
    memoria.MemSet("idAlquiler", actualIdAlquiler);
    memoria.MemSet(1, alquileres);
    memoria.MemSet(0, peliculas);
    ListarAlquiler();
    ListarSelectPeliculas();
    LimpiarCajasAlquiler();
}

function EliminarAlquiler() {
    let id = document.getElementById('lista').value;
    let posicion = BuscarPosicionAlquiler(id);
    let posicionPelicula = BuscarPosicion(alquileres[posicion].pelicula);

    if(posicion != -1) {
        peliculas[posicionPelicula].ventas--;
        alquileres.splice(posicion, 1);
        for (let i = posicion; i < alquileres.length; i++) {
            const alquiler = alquileres[i];

            alquiler.id = alquiler.id - 1;
        }
        memoria.MemSet("idAlquiler", --actualIdAlquiler);
        ListarAlquiler();
    }
    
    memoria.MemSet(0, peliculas);
    ListarSelectPeliculas();
    document.getElementById('lista').value = 1;
}

function ModificarAlquiler() {
    let posicion = BuscarPosicionAlquiler(document.getElementById('lista').value);
    let fecha = document.getElementById('fecha').value.trim();
    let nombre = document.getElementById("nombre").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let peliculaNueva = document.getElementById("pelicula").value;
    let peliculaAnterior = alquileres[posicion].pelicula;

    if(!fecha || !nombre || !telefono || !peliculaNueva) {
        alert("Complete todos los campos");
        return;
    }

    peliculas[BuscarPosicion(peliculaNueva)].ventas++;
    peliculas[BuscarPosicion(peliculaAnterior)].ventas--;
    LimpiarCajasAlquiler();
    alquileres.splice(posicion, 1, new Alquiler(alquileres[posicion].id, fecha, nombre, telefono, peliculaNueva));

    memoria.MemSet(0, peliculas);
    ListarSelectPeliculas();
    ListarAlquiler();
}

function ListarAlquiler() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;
    
    for (let objetoAlquiler of alquileres) {
        let elemento = new Option(objetoAlquiler.id + " : " + objetoAlquiler.fecha + " : " + objetoAlquiler.nombre + " : " + objetoAlquiler.telefono +" : " + peliculas[BuscarPosicion(objetoAlquiler.pelicula)].nombre, objetoAlquiler.id);
        lista.add(elemento);
    }
    memoria.MemSet(1, alquileres);
} 

function SeleccionarAlquiler() {
    let id = document.getElementById('lista').value;

    for (let objetoAlquiler of alquileres) {
            if(objetoAlquiler.id == id) {                
                document.getElementById('fecha').value           = objetoAlquiler.fecha;
                document.getElementById('nombre').value          = objetoAlquiler.nombre;
                document.getElementById('telefono').value        = objetoAlquiler.telefono;
                document.getElementById('pelicula').value        = objetoAlquiler.pelicula;
                document.getElementById('imagenVistaPrevia').src = peliculas[(BuscarPosicion(objetoAlquiler.pelicula))].imagen;
            }
    }
}

function LimpiarCajasAlquiler() {
    document.getElementById('fecha').value = "";
    document.getElementById('nombre').value = "";
    document.getElementById('telefono').value = "";
    document.getElementById('pelicula').value = "";
    document.getElementById('imagenVistaPrevia').src = "";
    document.getElementById('lista').value = 0;
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

//#region Metodos Estadisticas
function ListarEstadisticas() {
    ListarRecaudacion();
    ListarMasVendidas();
}

function ListarRecaudacion() {
    let recaudacion = 0;
    for(const alquiler of alquileres) {
        recaudacion += parseInt(peliculas[BuscarPosicion(alquiler.pelicula)].precio);
    }

    document.getElementById("plata-recaudada").value = recaudacion;
}
function ListarMasVendidas() {
    let lista = document.getElementById("lista-mas-alquiladas");
    let ventaMasAlta = 0;

    for(const objetoPelicula of peliculas) { 
        let elemento = new Option(`${objetoPelicula.nombre} (alquilada ${objetoPelicula.ventas} ${objetoPelicula.ventas == 1 ? 'vez' : 'veces'})`, objetoPelicula.id);
        if(objetoPelicula.ventas > ventaMasAlta) {
            lista.innerHTML = "";
            ventaMasAlta = objetoPelicula.ventas;        
            lista.options.add(elemento);
        }
        else if(objetoPelicula.ventas == ventaMasAlta) {
            lista.options.add(elemento);
        }
    }
}
function ListarPorGenero() {    
    let lista = document.getElementById("lista-genero").options;
    let genero = document.getElementById("genero").value;
    lista.length = 0;

    for (let objetoPelicula of peliculas) {
        if(objetoPelicula.genero == genero) {
            let elemento = new Option(objetoPelicula.nombre, objetoPelicula.id);
            lista.add(elemento);
        }
    }
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

window.ListarEstadisticas = ListarEstadisticas;
window.ListarPorGenero = ListarPorGenero;
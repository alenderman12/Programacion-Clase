import { Memoria } from "./memoria.js";
import { Pelicula } from "./pelicula.js";
import { Alquiler } from "./alquiler.js";
import { Usuario } from "./usuario.js";
import { Cliente } from "./cliente.js";
import { Genero } from "./genero.js";
 
let memoria = new Memoria();

let peliculas = memoria.MemGet('peliculas');
let alquileres = memoria.MemGet('alquileres');
let usuarios = memoria.MemGet('usuarios');
let clientes = memoria.MemGet('clientes');
let generos = memoria.MemGet('generos');

if(!peliculas) {
    peliculas = [];
}
if(!alquileres) {
    alquileres = [];
}
if (!usuarios) {
    usuarios = [];
}
if (!clientes) {
    clientes = [];
}
if (!generos) {
    generos = [];
}


//#region Metodos Pelicula

function InicioPelicula(){
    Listar()
    ListarSelectGeneros();
}

function ListarSelectGeneros() {
    memoria.MemSet("generos", generos);
    let selectGenero = document.getElementById("genero");
    if(selectGenero.innerHTML != null)
        selectGenero.innerHTML = '<option value="-1" disabled selected>Seleccione un genero</option>';

    for (let genero of generos) {
        selectGenero.innerHTML += `<option value="${genero.id}">${genero.nombre}</option>`;
    }
}

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
    
    const unaPelicula = new Pelicula(peliculas.length, nombre, genero, director, pais, precio, copias, imagen, 0);
    if(BuscarPosicion(peliculas.length) != -1) {
        alert("Esta pelicula ya esta ingresada");
        return;
    }
    peliculas.push(unaPelicula);
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
    Listar();

    document.getElementById('lista').value = 0;
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
        let elemento = new Option(objetoPelicula.id + " : " + objetoPelicula.nombre + " : " + generos[objetoPelicula.genero].nombre + " : " + 
            objetoPelicula.director + " : " + objetoPelicula.pais + " : " + "UYU$" + objetoPelicula.precio + " : " + (objetoPelicula.copias - objetoPelicula.ventas), objetoPelicula.id);
        lista.add(elemento);
    }
    memoria.MemSet("peliculas", peliculas);
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
    document.getElementById('genero').value = -1;
    document.getElementById('director').value = "";
    document.getElementById('pais').value = "";
    document.getElementById('precio').value = "";
    document.getElementById('copias').value = "";
    document.getElementById('imagen').value = "";
    document.getElementById('imagenVistaPrevia').src = "";
    document.getElementById('lista').value = null;
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

window.InicioPelicula = InicioPelicula;
window.Agregar = Agregar;
window.Modificar = Modificar;
window.Eliminar = Eliminar;
window.Listar = Listar;
window.Seleccionar = Seleccionar;
window.LimpiarCajas = LimpiarCajas;
window.VistaPreviaImagen = VistaPreviaImagen;

//#endregion

//#region Metodos Alquiler

function InicioAlquiler() {
    let idPeliculaParam = new URLSearchParams(window.location.search).get('pelicula');
    ListarSelectPeliculas()
    if(idPeliculaParam) {
        document.getElementById('pelicula').value = idPeliculaParam;
        document.getElementById('imagenVistaPrevia').src = peliculas[idPeliculaParam].imagen;
    }
    ListarSelectClientes()
    ListarAlquiler();
}

function ListarSelectPeliculas() {
    memoria.MemSet("peliculas", peliculas);
    let selectPelicula = document.getElementById("pelicula");
    if(selectPelicula.innerHTML != null)
        selectPelicula.innerHTML = '<option value="-1" disabled selected>Seleccione una pelicula</option>';

    for (let pelicula of peliculas) {
        if(pelicula.ventas < pelicula.copias){
            selectPelicula.innerHTML += `<option value="${pelicula.id}">${pelicula.nombre} - UYU$${pelicula.precio} - Restantes: ${pelicula.copias - pelicula.ventas}</option>`;
        }
    }
}

function ListarSelectClientes() {    
    memoria.MemSet("clientes", clientes);
    let selectCliente = document.getElementById("cliente");
    if(selectCliente.innerHTML != null)
        selectCliente.innerHTML = '<option value="-1" disabled selected>Seleccione un cliente</option>';

    for (let cliente of clientes) {
        selectCliente.innerHTML += `<option value="${cliente.id}">${cliente.nombre}</option>`;
    }
}

function AgregarAlquiler() {
    let fecha = document.getElementById('fecha').value.trim();
    let clienteId = parseInt(document.getElementById('cliente').value);
    let peliculaId = parseInt(document.getElementById("pelicula").value);

    console.log(fecha);
    console.log(clienteId);
    console.log(peliculaId);

    if(!fecha || clienteId == -1 || peliculaId == -1) {
        alert("Complete todos los campos");
        return;
    }

    const unAlquiler = new Alquiler(alquileres.length, fecha, clienteId, peliculaId, false);
    peliculas[peliculaId].ventas++;
    alquileres.push(unAlquiler);
    ListarAlquiler();
    ListarSelectPeliculas();
    LimpiarCajasAlquiler();
}

function DevolverAlquiler() {
    let id = document.getElementById('lista').value;
    let posicionPelicula = BuscarPosicion(alquileres[id].pelicula);

    if(id) {
        peliculas[posicionPelicula].ventas--;
        alquileres[id].devuelta = true;
        ListarAlquiler();
        ListarSelectPeliculas();
        document.getElementById('lista').value = 0;
    }
}

function ModificarAlquiler() {
    let posicion = document.getElementById('lista').value;
    let fecha = document.getElementById('fecha').value.trim();
    let cliente = document.getElementById("cliente").value;
    let peliculaNueva = document.getElementById("pelicula").value;
    let peliculaAnterior = alquileres[posicion].pelicula;

    if(!fecha || !cliente || !peliculaNueva) {
        alert("Complete todos los campos");
        return;
    }

    peliculas[BuscarPosicion(peliculaNueva)].ventas++;
    peliculas[BuscarPosicion(peliculaAnterior)].ventas--;
    LimpiarCajasAlquiler();
    alquileres.splice(posicion, 1, new Alquiler(alquileres[posicion].id, fecha, cliente, peliculaNueva, alquileres[posicion].devuelta));

    ListarSelectPeliculas();
    ListarAlquiler();
}

function ListarAlquiler() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;
    
    for (let objetoAlquiler of alquileres) {
        let elemento = new Option(objetoAlquiler.id + " : " + objetoAlquiler.fecha + " : " + clientes[objetoAlquiler.cliente].nombre + " : " + peliculas[objetoAlquiler.pelicula].nombre + " : " + (objetoAlquiler.devuelta ? "Devuelta" : "No devuelta"), objetoAlquiler.id);
        lista.add(elemento);
    }
    memoria.MemSet("alquileres", alquileres);
} 

function SeleccionarAlquiler() {
    let id = document.getElementById('lista').value;

    for (let objetoAlquiler of alquileres) {
            if(objetoAlquiler.id == id) {
                document.getElementById('fecha').value           = objetoAlquiler.fecha;
                document.getElementById('cliente').value         = objetoAlquiler.cliente;
                document.getElementById('pelicula').value        = objetoAlquiler.pelicula;
                MostrarImagenSelect(id);
            }
    }
}

function LimpiarCajasAlquiler() {
    document.getElementById('fecha').value = "";
    document.getElementById('cliente').value = "";
    document.getElementById('pelicula').value = "";
    document.getElementById('imagenVistaPrevia').src = "";
    document.getElementById('lista').value = null;
}

function MostrarImagenSelect(peliculaId) {
    document.getElementById('imagenVistaPrevia').src = peliculas[peliculaId].imagen;
}

window.InicioAlquiler = InicioAlquiler;
window.AgregarAlquiler = AgregarAlquiler;
window.ModificarAlquiler = ModificarAlquiler;
window.DevolverAlquiler = DevolverAlquiler;
window.ListarAlquiler = ListarAlquiler;
window.SeleccionarAlquiler = SeleccionarAlquiler;
window.LimpiarCajasAlquiler = LimpiarCajasAlquiler;
window.MostrarImagenSelect = MostrarImagenSelect;

//#endregion

//#region Metodos Usuarios

function AgregarUsuario() {
    let nombreUsuario = document.getElementById('nombre-usuario').value.trim();
    let contrasena = document.getElementById('contrasena').value.trim();

    if (!nombreUsuario || !contrasena) {
        alert("Complete todos los campos");
        return;
    }

    if (BuscarPosicionUsuarioPorNombre(nombreUsuario) !== -1) {
        alert("Este usuario ya existe");
        return;
    }

    const unUsuario = new Usuario(usuarios.length, nombreUsuario, contrasena);
    usuarios.push(unUsuario);
    ListarUsuarios();
    LimpiarCajasUsuario();
}

function EliminarUsuario() {
    let id = parseInt(document.getElementById('lista').value);
    let posicion = BuscarPosicionUsuario(id);

    if (posicion != -1) {
        usuarios.splice(posicion, 1);
        for (let i = posicion; i < usuarios.length; i++) {
            const usuario = usuarios[i];

            usuario.id = usuario.id - 1;
        }
        ListarUsuarios();
    }

    ListarUsuarios();
    document.getElementById('lista').value = 0;
}

function ModificarUsuario() {
    let id = parseInt(document.getElementById('lista').value);
    let posicion = BuscarPosicionUsuario(id);
    let nombreUsuario = document.getElementById('nombre-usuario').value.trim();
    let contrasena = document.getElementById('contrasena').value.trim();

    if (posicion == -1) {
        alert("Seleccione el usuario a modificar");
        return;
    }

    if (!nombreUsuario || !contrasena) {
        alert("Complete todos los campos");
        return;
    }

    usuarios.splice(posicion, 1, new Usuario(usuarios[posicion].id, nombreUsuario, contrasena));
    ListarUsuarios();
    LimpiarCajasUsuario();
}

function ListarUsuarios() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let usuario of usuarios) {
        let elemento = new Option(`${usuario.id} : ${usuario.nombreUsuario}`, usuario.id);
        lista.add(elemento);
    }
    memoria.MemSet("usuarios", usuarios);
}

function SeleccionarUsuario() {
    let id = parseInt(document.getElementById('lista').value);

    for (let usuario of usuarios) {
        if (usuario.id == id) {
            document.getElementById('nombre-usuario').value = usuario.nombreUsuario;
            document.getElementById('contrasena').value = usuario.contrasena;
        }
    }
}

function LimpiarCajasUsuario() {
    document.getElementById('nombre-usuario').value = "";
    document.getElementById('contrasena').value = "";
    document.getElementById('lista').value = null;
}

function BuscarPosicionUsuario(id) {
    for (let i = 0; i < usuarios.length; i++) {
        if (usuarios[i].id == id) {
            return i;
        }
    }
    return -1;
}

function BuscarPosicionUsuarioPorNombre(nombreUsuario) {
    for (let i = 0; i < usuarios.length; i++) {
        if (usuarios[i].nombreUsuario == nombreUsuario) {
            return i;
        }
    }
    return -1;
}

window.AgregarUsuario = AgregarUsuario;
window.ModificarUsuario = ModificarUsuario;
window.EliminarUsuario = EliminarUsuario;
window.ListarUsuarios = ListarUsuarios;
window.SeleccionarUsuario = SeleccionarUsuario;
window.LimpiarCajasUsuario = LimpiarCajasUsuario;

//#endregion

//#region Metodos Clientes

function AgregarCliente() {
    let nombreUsuario = document.getElementById('nombre-usuario').value.trim();
    let contrasena = document.getElementById('contrasena').value.trim();
    let nombre = document.getElementById('nombre').value.trim();
    let email = document.getElementById('email').value.trim();
    let direccion = document.getElementById('direccion').value.trim();
    let posicionUsuario = BuscarPosicionUsuarioPorNombre(nombreUsuario);

    if (!nombreUsuario || !contrasena || !nombre || !email || !direccion) {
        alert("Complete todos los campos");
        return;
    }

    if (posicionUsuario == -1 || usuarios[posicionUsuario].contrasena != contrasena) {
        alert("Nombre de usuario o contraseña incorrectos");
        return;
    }

    const unCliente = new Cliente(clientes.length, posicionUsuario, nombre, email, direccion);
    clientes.push(unCliente);
    memoria.MemSet("clientes", clientes);

    ListarClientes();
    LimpiarCajasCliente();
}

function EliminarCliente() {
    let id = parseInt(document.getElementById('lista').value);
    let posicion = BuscarPosicionCliente(id);
    let nombreUsuario = document.getElementById('nombre-usuario').value.trim();
    let contrasena = document.getElementById('contrasena').value.trim();
    let usuario = usuarios[clientes[id].usuario];

    if (usuario.nombreUsuario != nombreUsuario || usuario.contrasena != contrasena) {
        alert("Nombre de usuario o contraseña incorrectos");
        return;
    }

    if (posicion != -1) {
        clientes.splice(posicion, 1);
        for (let i = posicion; i < clientes.length; i++) {
            const cliente = clientes[i];

            cliente.id = cliente.id - 1;
        }
        ListarClientes();
    }

    document.getElementById('lista').value = 0;
}

function ModificarCliente() {
    let id = parseInt(document.getElementById('lista').value);
    let posicion = BuscarPosicionCliente(id);
    let nombreUsuario = document.getElementById('nombre-usuario').value.trim();
    let contrasena = document.getElementById('contrasena').value.trim();
    let nombre = document.getElementById('nombre').value.trim();
    let email = document.getElementById('email').value.trim();
    let direccion = document.getElementById('direccion').value.trim();
    let posicionUsuario = BuscarPosicionUsuarioPorNombre(nombreUsuario);

    if (posicion == -1) {
        alert("Seleccione el cliente a modificar");
        return;
    }

    if (!nombreUsuario || !contrasena || !nombre || !email || !direccion) {
        alert("Complete todos los campos");
        return;
    }

    if (posicionUsuario == -1 || usuarios[posicionUsuario].contrasena != contrasena) {
        alert("Nombre de usuario o contraseña incorrectos");
        return;
    }

    clientes.splice(posicion, 1, new Cliente(clientes[posicion].id, posicionUsuario, nombre, email, direccion));
    memoria.MemSet("clientes", clientes);

    ListarClientes();
    LimpiarCajasCliente();
}

function ListarClientes() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let cliente of clientes) {
        let elemento = new Option(`${cliente.id} : ${usuarios[cliente.usuario].nombreUsuario} : ${cliente.nombre} : ${cliente.email} : ${cliente.direccion}`, cliente.id);
        lista.add(elemento);
    }
    memoria.MemSet("clientes", clientes);
}

function SeleccionarCliente() {
    let id = parseInt(document.getElementById('lista').value);

    for (let cliente of clientes) {
        if (cliente.id == id) {
            document.getElementById('nombre-usuario').value = usuarios[cliente.usuario].nombreUsuario;
            document.getElementById('nombre').value = cliente.nombre;
            document.getElementById('email').value = cliente.email;
            document.getElementById('direccion').value = cliente.direccion;
        }
    }
}

function LimpiarCajasCliente() {
    document.getElementById('nombre-usuario').value = "";
    document.getElementById('contrasena').value = "";
    document.getElementById('nombre').value = "";
    document.getElementById('email').value = "";
    document.getElementById('direccion').value = "";
    document.getElementById('lista').value = null;
}

function BuscarPosicionCliente(id) {
    for (let i = 0; i < clientes.length; i++) {
        if (clientes[i].id == id) {
            return i;
        }
    }
    return -1;
}

window.AgregarCliente = AgregarCliente;
window.ModificarCliente = ModificarCliente;
window.EliminarCliente = EliminarCliente;
window.ListarClientes = ListarClientes;
window.SeleccionarCliente = SeleccionarCliente;
window.LimpiarCajasCliente = LimpiarCajasCliente;

//#endregion

//#region Metodos Generos

function AgregarGenero() {
    let nombre = document.getElementById('nombre').value.trim();

    if (!nombre) {
        alert("Ingrese el nombre del genero");
        return;
    }

    const unGenero = new Genero(generos.length, nombre);
    generos.push(unGenero);

    ListarGeneros();
    LimpiarCajasGenero();
}

function EliminarGenero() {
    let id = parseInt(document.getElementById('lista').value);

    if (id) {
        generos.splice(id, 1);
        for (let i = id; i < generos.length; i++) {
            const genero = generos[i];

            genero.id = genero.id - 1;
        }
        ListarGeneros();
        document.getElementById('lista').value = 0;
    }

}

function ModificarGenero() {
    let id = parseInt(document.getElementById('lista').value);
    let nombre = document.getElementById('nombre').value.trim();

    if (!id) {
        alert("Seleccione el cliente a modificar");
        return;
    }

    if (!nombre) {
        alert("Ingrese el nombre del genero");
        return;
    }

    generos.splice(id, 1, new Genero(id, nombre));
    memoria.MemSet("generos", generos);

    ListarGeneros();
    LimpiarCajasGenero();
}

function ListarGeneros() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let genero of generos) {
        let elemento = new Option(`${genero.id} : ${genero.nombre}`, genero.id);
        lista.add(elemento);
    }
    memoria.MemSet("generos", generos);
}

function SeleccionarGenero() {
    let id = parseInt(document.getElementById('lista').value);

    document.getElementById('nombre').value = generos[id].nombre;
}

function LimpiarCajasGenero() {
    document.getElementById('nombre').value = "";
    document.getElementById('lista').value = null;
}

window.AgregarGenero = AgregarGenero;
window.ModificarGenero = ModificarGenero;
window.EliminarGenero = EliminarGenero;
window.ListarGeneros = ListarGeneros;
window.SeleccionarGenero = SeleccionarGenero;
window.LimpiarCajasGenero = LimpiarCajasGenero;

//#endregion

//#region Metodos Catalogo
function InicioCatalogo() {
    ListarSelectGeneros();
    document.getElementById('genero').innerHTML = '<option value="-1" selected>Todos los generos</option>' + document.getElementById('genero').innerHTML;
    CargarCatalogo();
}

function CargarCatalogo() {
    let catalogoLista = document.getElementById('catalogo-lista');
    let genero = document.getElementById('genero').value;
    catalogoLista.innerHTML = "";


    for(let pelicula of peliculas) {
        if(pelicula.genero == genero || genero == -1) {
            catalogoLista.innerHTML += `
                    <li>
                        <div class="card text-center fs-4" style="width: 18rem;">
                            <img src="${pelicula.imagen}" class="card-img-top img-articulo">
                            <div class="card-body">
                                <h3 class="card-title">${pelicula.nombre}</h3>
                            </div>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">${generos[pelicula.genero].nombre}</li>
                                <li class="list-group-item">${pelicula.director}</li>
                                <li class="list-group-item">${pelicula.pais}</li>
                                <li class="list-group-item">UYU$${pelicula.precio}</li>
                            </ul>
                            <a href="presentacion/alquiler.html?pelicula=${pelicula.id}" class="btn btn-info fs-4 ${pelicula.ventas == pelicula.copias ? 'disabled' : ''}">Alquilar</a>
                            <div class="card-footer text-body-secondary">Hay ${pelicula.copias - pelicula.ventas} en stock</div>
                        </div>
                    </li>`
        }
    }
}

window.InicioCatalogo = InicioCatalogo;
window.CargarCatalogo = CargarCatalogo;

//#endregion

//#region Metodos Estadisticas
function ListarRangoFechas() {    
    let lista = document.getElementById("lista-alquileres").options;
    let desde = document.getElementById("desde").value;
    let hasta = document.getElementById("hasta").value;
    lista.length = 0;

    for (let objetoAlquiler of alquileres) {
        if(objetoAlquiler.fecha >= desde && objetoAlquiler.fecha <= hasta) {
            let elemento = new Option(clientes[objetoAlquiler.cliente].nombre + " : " +  peliculas[objetoAlquiler.pelicula].nombre, objetoAlquiler.id);
            lista.add(elemento);
        }
    }
}

function ListarPeliculasCliente() {    
    let lista = document.getElementById("lista-peliculas").options;
    let nombre = document.getElementById("nombre").value.toLowerCase();
    lista.length = 0;

    for (let objetoAlquiler of alquileres) {
        console.log(objetoAlquiler.devuelta);
        if((clientes[objetoAlquiler.cliente].nombre.toLowerCase()).includes(nombre)) {
            let elemento = new Option(`${clientes[objetoAlquiler.cliente].nombre} : ${peliculas[objetoAlquiler.pelicula].nombre} : ${objetoAlquiler.devuelta ? "Devuelta" : "No devuelta" }`, objetoAlquiler.id);
            lista.add(elemento);
        }
    }
}

//#endregion

window.ListarPeliculasCliente = ListarPeliculasCliente;
window.ListarRangoFechas = ListarRangoFechas;
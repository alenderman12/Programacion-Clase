import { Memoria } from "./memoria.js";
import { Persona } from "./persona.js";
import { Mascota } from "./mascota.js";
import { Adopcion } from "./adopcion.js";

let personas = [];
let mascotas = [];
let adopciones = [];

//#region Metodos de Persona
function Agregar() {    
    let id = parseInt(document.getElementById('id').value);
    let nombre = document.getElementById('nombre').value.trim();
    let apellido = document.getElementById("apellido").value.trim();
    let direccion = document.getElementById("direccion").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let edad = parseInt(document.getElementById('edad').value);
    let genero = document.getElementById("genero").value.trim();
    let cedula = document.getElementById('cedula').value.trim();
    let adopciones = 0;

    if (!id || !nombre || !apellido || !direccion || !telefono || !edad || !genero || !cedula) {
        alert("Por favor completa todos los campos.");
        return;
    }
    
    const unaPersona = new Persona(id, nombre, apellido, direccion, telefono, edad, genero, cedula, adopciones);
    personas.push(unaPersona);

    const LaMemoria = new Memoria();
    LaMemoria.escribir('personas',personas);
    Listar();
    IncrementoId();
    LimpiarCajas();
}

function Listar() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objPersona of personas) {
        let genero = (objPersona.genero=='F')?'Femenino':'Masculino';
        
        let linea = objPersona.nombre + " " + objPersona.apellido 
        + " - " + objPersona.cedula + " - " + genero + " - " + 
        objPersona.direccion + " - " + objPersona.telefono + " - " + objPersona.edad;
        
        let elemento = new Option(linea, objPersona.id);

        lista.add(elemento);
    }
}

function Inicio(){
    const LaMemoria = new Memoria();
    personas = LaMemoria.leer('personas');
    let id = LaMemoria.leer('idPersona');
    if(!personas){
        personas = [];
    }
    if(!id){
        LaMemoria.escribir('idPersona', 1);
    }
    Listar();
    LimpiarCajas();
}
function Modificar(){
    let id = document.getElementById("lista").value;
    let nombre = document.getElementById('nombre').value.trim();
    let apellido = document.getElementById("apellido").value.trim();
    let direccion = document.getElementById("direccion").value.trim();
    let telefono = document.getElementById("telefono").value.trim();
    let edad = parseInt(document.getElementById('edad').value);
    let genero = document.getElementById("genero").value.trim();
    let cedula = document.getElementById('cedula').value.trim();

    if (!id || !nombre || !apellido || !direccion || !telefono || !edad || !genero || !cedula) {
        alert("Por favor completa todos los campos.");
        return;
    }

    let unaPersona = BuscarPersona(id);
    if(!unaPersona){
        alert("Error al modificar una Persona");
        return;
    }
    unaPersona.nombre = nombre;
    unaPersona.apellido = apellido;
    unaPersona.direccion = direccion;
    unaPersona.telefono = telefono;
    unaPersona.edad = edad;
    unaPersona.cedula = cedula;
    unaPersona.genero = genero;
    const LaMemoria = new Memoria();
    LaMemoria.escribir('personas',personas);
    Listar();
    LimpiarCajas();
}

function Eliminar() {
    let id = document.getElementById("lista").value;
    if(!id){
        alert("Debe seleccionar una Persona!");
        return;
    }
    let posicion = BuscarPosicion(id);
    if(posicion != -1){
        personas.splice(posicion,1);
        const LaMemoria = new Memoria();
        LaMemoria.escribir('personas',personas);
        Listar();
    }else{
        alert("Error al eliminar una Persona!");
    }
    LimpiarCajas();
}

function LimpiarCajas() {
    const LaMemoria = new Memoria();
    document.getElementById('id').value = LaMemoria.leer('idPersona');
    document.getElementById('nombre').value = "";
    document.getElementById('apellido').value = "";
    document.getElementById('direccion').value = "";
    document.getElementById('telefono').value = "";
    document.getElementById('edad').value = "";
    document.getElementById('cedula').value = "";
    document.getElementById('genero').value = "";
    
    document.getElementById('id').focus();
    document.getElementById('lista').selectedIndex = -1;
}

function Seleccionar(){
    let id = document.getElementById("lista").value;
    for (let objPersona of personas) {
        if(objPersona.id == id){
            document.getElementById('id').value        = objPersona.id;
            document.getElementById('nombre').value    = objPersona.nombre;
            document.getElementById('apellido').value  = objPersona.apellido;
            document.getElementById('direccion').value = objPersona.direccion;
            document.getElementById('telefono').value  = objPersona.telefono;
            document.getElementById('edad').value      = objPersona.edad;
            document.getElementById('cedula').value      = objPersona.cedula;
            document.getElementById('genero').value      = objPersona.genero;
        }
    }
}

function BuscarPosicion(id){
    for (let posicion = 0; posicion < personas.length; posicion++) {
        const objPersona = personas[posicion];
        if(objPersona.id == id){
            return posicion;
        }
    }
    return -1;
}

function BuscarPersona(id){
    for (const objPersona of personas) {
        if(objPersona.id == id){
            return objPersona;
        }
    }
    return null;
}

function IncrementoId(){
    const LaMemoria = new Memoria();
    let id = LaMemoria.leer('idPersona');
    LaMemoria.escribir('idPersona', id+1);
}

// Funciones a las que accedo desde el HTML
window.Inicio = Inicio;
window.Agregar = Agregar;
window.LimpiarCajas = LimpiarCajas;
window.Modificar = Modificar;
window.Eliminar = Eliminar;
window.Seleccionar = Seleccionar;

//#endregion

//#region Metodos de Mascota

function AgregarMascota() {    
    let id = parseInt(document.getElementById('mascota-id').value);
    let nombre = document.getElementById('mascota-nombre').value.trim();
    let especie = document.getElementById('mascota-especie').value.trim();
    let raza = document.getElementById('mascota-raza').value.trim();
    let sexo = document.getElementById('mascota-sexo').value.trim();
    let edad = parseInt(document.getElementById('mascota-edad').value);
    let adoptado = "No";

    if (!id || !nombre || !especie || !raza || !sexo || !edad) {
        alert("Por favor completa todos los campos.");
        return;
    }
    
    const unaMascota = new Mascota(id, nombre, especie, raza, sexo, edad, adoptado);
    mascotas.push(unaMascota);

    const LaMemoria = new Memoria();
    LaMemoria.escribir('mascotas',mascotas);
    ListarMascotas();
    IncrementoIdMascota();
    LimpiarCajasMascota();
}

function ModificarMascota(){
    let id = document.getElementById("mascota-lista").value;
    let nombre = document.getElementById('mascota-nombre').value.trim();
    let especie = document.getElementById('mascota-especie').value.trim();
    let raza = document.getElementById('mascota-raza').value.trim();
    let sexo = document.getElementById('mascota-sexo').value.trim();
    let edad = parseInt(document.getElementById('mascota-edad').value);
    
    if (!id || !nombre || !especie || !raza || !sexo || !edad) {
        alert("Por favor completa todos los campos.");
        return;
    }

    let unaMascota = BuscarMascota(id);
    if(!unaMascota){
        alert("Error al modificar una Mascota");
        return;
    }
    unaMascota.nombre = nombre;
    unaMascota.especie = especie;
    unaMascota.raza = raza;
    unaMascota.sexo = sexo;
    unaMascota.edad = edad;
    
    const LaMemoria = new Memoria();
    LaMemoria.escribir('mascotas',mascotas);
    ListarMascotas();
    LimpiarCajasMascota();
}

function EliminarMascota() {
    let id = document.getElementById("mascota-lista").value;
    if(!id){
        alert("Debe seleccionar una Mascota!");
        return;
    }
    let posicion = BuscarPosicionMascota(id);
    if(posicion != -1){
        mascotas.splice(posicion,1);
        const LaMemoria = new Memoria();
        LaMemoria.escribir('mascotas',mascotas);
        ListarMascotas();
    }else{
        alert("Error al eliminar una Mascota!");
    }
    LimpiarCajasMascota();
}

function ListarMascotas() {
    let lista = document.getElementById('mascota-lista').options;
    lista.length = 0;

    for (let objMascota of mascotas) {
        let sexo = (objMascota.sexo=='H')?'Hembra':'Macho';
        
        let linea = objMascota.nombre + " - " + objMascota.especie 
        + " - " + objMascota.raza + " - " + sexo + " - Edad: " + objMascota.edad
        + " - Adoptado: " + objMascota.adoptado;
        
        let elemento = new Option(linea, objMascota.id);

        lista.add(elemento);
    }
}

function InicioMascota(){
    const LaMemoria = new Memoria();
    mascotas = LaMemoria.leer('mascotas');
    let id = LaMemoria.leer('idMascota');
    if(!mascotas){
        mascotas = [];
    }
    if(!id){
        LaMemoria.escribir('idMascota', 1);
    }
    ListarMascotas();
    LimpiarCajasMascota();
}

function LimpiarCajasMascota() {
    const LaMemoria = new Memoria();
    document.getElementById('mascota-id').value = LaMemoria.leer('idMascota');
    document.getElementById('mascota-nombre').value = "";
    document.getElementById('mascota-especie').value = "";
    document.getElementById('mascota-raza').value = "";
    document.getElementById('mascota-sexo').value = "";
    document.getElementById('mascota-edad').value = "";
    
    document.getElementById('mascota-nombre').focus();
    document.getElementById('mascota-lista').selectedIndex = -1;
}

function BuscarPosicionMascota(id){
    for (let posicion = 0; posicion < mascotas.length; posicion++) {
        const objMascota = mascotas[posicion];
        if(objMascota.id == id){
            return posicion;
        }
    }
    return -1;
}

function BuscarMascota(id){
    for (const objMascota of mascotas) {
        if(objMascota.id == id){
            return objMascota;
        }
    }
    return null;
}

function IncrementoIdMascota(){
    const LaMemoria = new Memoria();
    let id = LaMemoria.leer('idMascota');
    LaMemoria.escribir('idMascota', id+1);
}

function SeleccionarMascota(){
    let id = document.getElementById("mascota-lista").value;
    for (let objMascota of mascotas) {
        if(objMascota.id == id){
            document.getElementById('mascota-id').value      = objMascota.id;
            document.getElementById('mascota-nombre').value  = objMascota.nombre;
            document.getElementById('mascota-especie').value = objMascota.especie;
            document.getElementById('mascota-raza').value    = objMascota.raza;
            document.getElementById('mascota-sexo').value    = objMascota.sexo;
            document.getElementById('mascota-edad').value    = objMascota.edad;
        }
    }
}

window.InicioMascota = InicioMascota;
window.AgregarMascota = AgregarMascota;
window.LimpiarCajasMascota = LimpiarCajasMascota;
window.ModificarMascota = ModificarMascota;
window.EliminarMascota = EliminarMascota;
window.SeleccionarMascota = SeleccionarMascota;

//#endregion

//#region Metodos de Adopcion

function InicioAdopcion() {
    const LaMemoria = new Memoria();
    mascotas = LaMemoria.leer('mascotas');
    personas = LaMemoria.leer('personas');
    adopciones = LaMemoria.leer('adopciones');
    let id = LaMemoria.leer('idAdopcion');
    if(!id){
        LaMemoria.escribir('idAdopcion', 1);
    }
    if(!adopciones){
        adopciones = [];
    }
    CargarMascotas();
    CargarPersonas();
    ListarAdopciones();
    LimpiarCajasAdopcion();
}

function LimpiarCajasAdopcion() {
    const LaMemoria = new Memoria();
    document.getElementById('adopcion-id').value = LaMemoria.leer('idAdopcion');
    document.getElementById('adopcion-fecha').value = "";
    document.getElementById('adopcion-persona').value = "";
    document.getElementById('adopcion-mascota').value = "";
    
    document.getElementById('adopcion-lista').selectedIndex = -1;
}

function CargarPersonas(){
    let lista = document.getElementById('adopcion-persona').options;
    lista.length = 0;
    let seleccione = new Option("Seleccione una persona","");
    lista.add(seleccione);
    for (let objPersona of personas) {
        let elemento = new Option(objPersona.nombre + " " + objPersona.apellido, objPersona.id);
        lista.add(elemento);
    }
}
function CargarMascotas(){
    let lista = document.getElementById('adopcion-mascota').options;
    lista.length = 0;
    let seleccione = new Option("Seleccione una mascota","");
    lista.add(seleccione);
    for (let objMascota of mascotas) {
        if(objMascota.adoptado == "No"){
            let elemento = new Option(objMascota.nombre + " " + objMascota.especie, objMascota.id);
            lista.add(elemento);
        }
    }
}

function AgregarAdopcion() {    
    let id = parseInt(document.getElementById('adopcion-id').value);
    let fecha = document.getElementById('adopcion-fecha').value.trim();
    let idPersona = document.getElementById('adopcion-persona').value.trim();
    let idMascota = document.getElementById('adopcion-mascota').value.trim();
    
    if (!id || !fecha || !idPersona || !idMascota) {
        alert("Por favor completa todos los campos.");
        return;
    }

    let unaPersona = BuscarPersona(idPersona);
    let unaMascota = BuscarMascota(idMascota);
    
    const unaAdopcion = new Adopcion(id, fecha, unaMascota, unaPersona);
    adopciones.push(unaAdopcion);

    const LaMemoria = new Memoria();
    LaMemoria.escribir('adopciones',adopciones);
    AdoptarMascota(unaMascota.id);
    SumarAdopcionPersona(unaPersona.id);
    ListarAdopciones();
    IncrementoIdAdopcion();
    LimpiarCajasAdopcion();
    CargarMascotas();
}

function ModificarAdopcion(){
    let id = document.getElementById("adopcion-lista").value;
    let fecha = document.getElementById('adopcion-fecha').value.trim();
    let idPersona = document.getElementById('adopcion-persona').value.trim();
    let idMascota = document.getElementById('adopcion-mascota').value.trim();
    if (!id || !fecha || !idPersona || !idMascota) {
        alert("Por favor completa todos los campos.");
        return;
    }
    let unaPersona = BuscarPersona(idPersona);
    let unaMascota = BuscarMascota(idMascota);

    let unaAdopcion = BuscarAdopcion(id);
    if(!unaAdopcion){
        alert("Error al modificar una Adopción");
        return;
    }
    unaAdopcion.fecha = fecha;
    unaMascota.persona = unaPersona;
    unaMascota.mascota = unaMascota;
    
    const LaMemoria = new Memoria();
    LaMemoria.escribir('adopciones',adopciones);
    ListarAdopciones();
    LimpiarCajasAdopcion();
}

function EliminarAdopcion() {
    let id = document.getElementById("adopcion-lista").value;
    if(!id){
        alert("Debe seleccionar una Adopción!");
        return;
    }
    let posicion = BuscarPosicionAdopcion(id);
    if(posicion != -1){
        let unaAdopcion = BuscarAdopcion(id);
        DevolverMascota(unaAdopcion.mascota.id);
        adopciones.splice(posicion,1);
        const LaMemoria = new Memoria();
        LaMemoria.escribir('adopciones',adopciones);
        ListarAdopciones();
        CargarMascotas();
    }else{
        alert("Error al eliminar una Adopcion!");
    }
    LimpiarCajasAdopcion();
}

function ListarAdopciones() {
    let lista = document.getElementById('adopcion-lista').options;
    lista.length = 0;

    for (let objAdopcion of adopciones) {
        
        let linea = objAdopcion.fecha + " : " + objAdopcion.persona.nombre 
        + " - " + objAdopcion.mascota.nombre;
        let elemento = new Option(linea, objAdopcion.id);

        lista.add(elemento);
    }
}

function BuscarPosicionAdopcion(id){
    for (let posicion = 0; posicion < adopciones.length; posicion++) {
        const objAdopcion = adopciones[posicion];
        if(objAdopcion.id == id){
            return posicion;
        }
    }
    return -1;
}

function AdoptarMascota(idMascota){
    for (const objMascota of mascotas) {
        if(objMascota.id == idMascota){
            objMascota.adoptado = "Si";
        }
    }
    const LaMemoria = new Memoria();
    LaMemoria.escribir('mascotas',mascotas);
}

function SumarAdopcionPersona(idPersona){
    for (const objPersona of personas) {
        if(objPersona.id == idPersona){
            objPersona.adopciones = objPersona.adopciones + 1;
        }
    }
    const LaMemoria = new Memoria();
    LaMemoria.escribir('personas',personas);
}

function DevolverMascota(idMascota){
    for (const objMascota of mascotas) {
        if(objMascota.id == idMascota){
            objMascota.adoptado = "No";
        }
    }
    const LaMemoria = new Memoria();
    LaMemoria.escribir('mascotas',mascotas);
}

function BuscarAdopcion(id){
    for (const objAdopcion of adopciones) {
        if(objAdopcion.id == id){
            return objAdopcion;
        }
    }
    return null;
}

function IncrementoIdAdopcion(){
    const LaMemoria = new Memoria();
    let id = LaMemoria.leer('idAdopcion');
    LaMemoria.escribir('idAdopcion', id+1);
}

function SeleccionarAdopcion(){
    let id = document.getElementById("adopcion-lista").value;
    for (let objAdopcion of adopciones) {
        if(objAdopcion.id == id){
            document.getElementById('adopcion-id').value      = objAdopcion.id;
            document.getElementById('adopcion-fecha').value  = objAdopcion.fecha;
            document.getElementById('adopcion-persona').value = objAdopcion.persona.id;
            document.getElementById('adopcion-mascota').value    = objAdopcion.mascota.id;
        }
    }
}

window.InicioAdopcion = InicioAdopcion;
window.AgregarAdopcion = AgregarAdopcion;
window.ModificarAdopcion = ModificarAdopcion;
window.EliminarAdopcion = EliminarAdopcion;
window.SeleccionarAdopcion = SeleccionarAdopcion;
window.LimpiarCajasAdopcion = LimpiarCajasAdopcion;
//#endregion

//#region Listados

function InicioListados() {
    const LaMemoria = new Memoria();
    mascotas = LaMemoria.leer('mascotas');
    personas = LaMemoria.leer('personas');
    adopciones = LaMemoria.leer('adopciones');
}

function AdopcionesXFecha(){
    let fecha = document.getElementById('listado-fecha').value;
    let lista = document.getElementById('listado-adopcionesxfecha').options;
    lista.length = 0;

    for (const objAdopcion of adopciones) {
        if(objAdopcion.fecha == fecha){
            let texto = objAdopcion.fecha + " : " + objAdopcion.persona.nombre 
            + " " + objAdopcion.persona.apellido + " adoptó a " + 
            objAdopcion.mascota.nombre + " " +objAdopcion.mascota.especie;
            let item = new Option(texto);
            lista.add(item);
        }
    }
}
function MascotasPorEspecie(){
    let pEspecie = document.getElementById('listado-especie').value;
    let lista = document.getElementById('listado-mascotasxespecie').options;
    lista.length = 0;

    for (const objMascota of mascotas) {
        if(objMascota.especie == pEspecie){
            let sexo = (objMascota.sexo=='H')?'Hembra':'Macho';
            let linea = objMascota.nombre + " - " + objMascota.especie 
            + " - " + objMascota.raza + " - " + sexo + " - Edad: " + objMascota.edad
            + " - Adoptado: " + objMascota.adoptado;
            let elemento = new Option(linea);
            lista.add(elemento);
        }
    }
}
function PersonaConMasAdopciones(){
    let personaMasAdopto;
    let totalAdopciones = 0;
    for (const objPersona of personas) {
        if(objPersona.adopciones > totalAdopciones){
            totalAdopciones = objPersona.adopciones;
            personaMasAdopto = objPersona;
        }
    }
    // en personaMasAdopta tienen los datos para mostrar en una caja de texto
    let texto = personaMasAdopto.nombre + " " + personaMasAdopto.apellido 
    + " con " + personaMasAdopto.adopciones + " adopciones";
    document.getElementById('listado-personaMasAdopto').value = texto;
}

window.PersonaConMasAdopciones = PersonaConMasAdopciones;
window.MascotasPorEspecie = MascotasPorEspecie;
window.AdopcionesXFecha = AdopcionesXFecha;
window.InicioListados = InicioListados;

//#endregion
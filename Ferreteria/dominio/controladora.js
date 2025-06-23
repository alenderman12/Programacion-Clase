import { Categoria } from "./categoria.js";
import { Cliente } from "./cliente.js";
import { Articulo } from "./articulo.js";
import { Funcionario } from "./funcionario.js";
import { Venta } from "./venta.js";
import { Memoria } from "./memoria.js";

const memoria = new Memoria();

//#region Metodos Categoria

function AgregarCategoria() {
    let nombre = document.getElementById('nombre').value.trim();

    if(!nombre) {
        alert("Ingrese el nombre");
        return;
    }
    
    const unaCategoria = new Persona(actualIdCategoria, nombre);
    if(BuscarPosicion(actualIdCategoria) != -1) {
        alert("Esta Categoria ya existe");
        return;
    }
    categorias.push(unaCategoria);
    actualIdCategoria++;
    memoria.MemSet("idCategoria", actualIdCategoria);
    memoria.MemSet('categoria', categorias);
    ListarCategoria();
    LimpiarCajasCategoria();
}

function EliminarCategoria() {
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

function ModificarCategoria() {
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

function ListarCategoria() {
    let lista = document.getElementById('lista').options;
    lista.length = 0;

    for (let objetoPersona of personas) {
        let elemento = new Option(objetoPersona.id + " : " + objetoPersona.nombre + " : " + objetoPersona.apellido + " : " + 
            objetoPersona.telefono + " : " + objetoPersona.direccion + " : " + objetoPersona.edad + (objetoPersona.edad == 1 ? " año" : " años"), objetoPersona.id);
        lista.add(elemento);
    }
    memoria.MemSet(0, personas);
} 

function SeleccionarCategoria() {
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

function LimpiarCajasCategoria() {
    document.getElementById('nombre').value = "";
    document.getElementById('apellido').value = "";
    document.getElementById('telefono').value = "";
    document.getElementById('direccion').value = "";
    document.getElementById('edad').value = "";
    document.getElementById('lista').value = 0;
}

function BuscarPosicionCategoria(id) {
    for (let i = 0; i < personas.length; i++) {
        const objetoPersona = personas[i];
        if(objetoPersona.id == id) {
            return i;
        }
    }
    return -1;
}

window.AgregarCategoria = AgregarCategoria;
window.ModificarCategoria = ModificarCategoria;
window.EliminarCategoria = EliminarCategoria;
window.ListarCategoria = ListarCategoria;
window.SeleccionarCategoria = SeleccionarCategoria;
window.LimpiarCajasCategoria = LimpiarCajasCategoria;

//#endregion
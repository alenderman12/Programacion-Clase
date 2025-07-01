import { Funcionario } from "./funcionario.js";
import { Cliente } from "./cliente.js";
import { Venta } from "./venta.js";
import { Articulo } from "./articulo.js";
import { Categoria } from "./categoria.js";
import { Memoria } from "./memoria.js";

//#region Metodos de Categorías

let categorias = [];
function InicioCategoria(){
    const LaMemoria = new Memoria();
    categorias = LaMemoria.leer('categorias');
    let codigo = LaMemoria.leer('categoria-codigo');
    if(!categorias){
        categorias = [];
    }
    if(!codigo){
        codigo = 1;
        LaMemoria.escribir('categoria-codigo',codigo);
    }
    LimpiarCajasCategoria();
    ListarCategorias();
}

function LimpiarCajasCategoria(){
    const LaMemoria = new Memoria();
    document.getElementById('categoria-codigo').value = LaMemoria.leer('categoria-codigo');
    document.getElementById('categoria-nombre').value = "";
}

function AgregarCategoria() {
    let codigo = document.getElementById('categoria-codigo').value;
    let nombre = document.getElementById('categoria-nombre').value;

    if(!codigo || !nombre){
        alert("Debe ingresar todos los campos!");
        return;
    }
    
    const unaCategoria = new Categoria(codigo, nombre);
    categorias.push(unaCategoria);
    
    const LaMemoria = new Memoria();
    LaMemoria.escribir('categorias', categorias);
    IncrementoIdCategoria();
    LimpiarCajasCategoria();
    ListarCategorias();
}

function ModificarCategoria(){
    let codigo = document.getElementById('categoria-codigo').value;
    let nombre = document.getElementById('categoria-nombre').value;

    if(!codigo || !nombre){
        alert("Debe ingresar todos los campos!");
        return;
    }

    let unaCategoria = BuscarCategoria(codigo);

    if(unaCategoria == null){
        alert("Categoría no encontrada!");
        return;
    }

    unaCategoria.nombre = nombre;

    const LaMemoria = new Memoria();
    LaMemoria.escribir('categorias', categorias);
    LimpiarCajasCategoria();
    ListarCategorias();
}

function EliminarCategoria(){
    let codigo = document.getElementById('categoria-codigo').value;
    let posCat = BuscarPosicionCategoria(codigo);

    if(posCat == -1){
        alert("Categoría no encontrada!");
        return;
    }
    categorias.splice(posCat,1);
    const LaMemoria = new Memoria();
    LaMemoria.escribir('categorias', categorias);
    LimpiarCajasCategoria();
    ListarCategorias();

}

function IncrementoIdCategoria(){
    const LaMemoria = new Memoria();
    let codigo = LaMemoria.leer('categoria-codigo');
    LaMemoria.escribir('categoria-codigo', codigo+1);
}

function ListarCategorias() {
    let lista = document.getElementById('categoria-lista').options;
    lista.length = 0;

    for (const objCat of categorias) {
        let linea = objCat.codigo + " : " + objCat.nombre;
        let elemento = new Option(linea, objCat.codigo);
        lista.add(elemento);
    }
}

function SeleccionarCategoria(){
    let pCodigo = document.getElementById('categoria-lista').value;
    
    for (const objCat of categorias) {
        if(objCat.codigo == pCodigo){
            document.getElementById('categoria-codigo').value = objCat.codigo;
            document.getElementById('categoria-nombre').value = objCat.nombre;
        }
    }

}

function BuscarCategoria(pCodigo){
    for (const objCat of categorias) {
        if(objCat.codigo == pCodigo){
            return objCat;
        }
    }
    return null;
}

function BuscarPosicionCategoria(pCodigo){
    for (let pos = 0; pos < categorias.length; pos++) {
        const objCat = categorias[pos];
        if(objCat.codigo == pCodigo){
            return pos;
        }
    }
    return -1;
}

window.InicioCategoria = InicioCategoria;
window.ListarCategorias = ListarCategorias;
window.AgregarCategoria = AgregarCategoria;
window.ModificarCategoria = ModificarCategoria;
window.EliminarCategoria = EliminarCategoria;
window.SeleccionarCategoria = SeleccionarCategoria;
window.LimpiarCajasCategoria = LimpiarCajasCategoria;

//#endregion

//#region Metodos de Funcionarios

let funcionarios = [];
function InicioFuncionario(){
    const LaMemoria = new Memoria();
    funcionarios = LaMemoria.leer('funcionarios');
    let codigo = LaMemoria.leer('funcionario-codigo');
    if(!funcionarios){
        funcionarios = [];
    }
    if(!codigo){
        codigo = 1;
        LaMemoria.escribir('funcionario-codigo',codigo);
    }
    LimpiarCajasFuncionario();
    ListarFuncionarios();
}

function LimpiarCajasFuncionario(){
    const LaMemoria = new Memoria();
    document.getElementById('funcionario-codigo').value = LaMemoria.leer('funcionario-codigo');
    document.getElementById('funcionario-nombre').value = "";
    document.getElementById('funcionario-rol').value = "";
}

function AgregarFuncionario() {
    let codigo = document.getElementById('funcionario-codigo').value;
    let nombre = document.getElementById('funcionario-nombre').value;
    let rol = document.getElementById('funcionario-rol').value;

    if(!codigo || !nombre || !rol){
        alert("Debe ingresar todos los campos!");
        return;
    }
    
    const unFuncionario = new Funcionario(codigo, nombre, rol);
    funcionarios.push(unFuncionario);
    
    const LaMemoria = new Memoria();
    LaMemoria.escribir('funcionarios', funcionarios);
    IncrementoIdFuncionario();
    LimpiarCajasFuncionario();
    ListarFuncionarios();
}

function ModificarFuncionario(){
    let codigo = document.getElementById('funcionario-codigo').value;
    let nombre = document.getElementById('funcionario-nombre').value;
    let rol = document.getElementById('funcionario-rol').value;

    if(!codigo || !nombre || !rol){
        alert("Debe ingresar todos los campos!");
        return;
    }

    let unFuncionario = BuscarFuncionario(codigo);

    if(unFuncionario == null){
        alert("Funcionario no encontrado!");
        return;
    }

    unFuncionario.nombre = nombre;
    unFuncionario.rol = rol;

    const LaMemoria = new Memoria();
    LaMemoria.escribir('funcionarios', funcionarios);
    LimpiarCajasFuncionario();
    ListarFuncionarios();
}

function EliminarFuncionario(){
    let codigo = document.getElementById('funcionario-codigo').value;
    let posFunc = BuscarPosicionFuncionario(codigo);

    if(posFunc == -1){
        alert("Funcionario no encontrado!");
        return;
    }
    funcionarios.splice(posFunc,1);
    const LaMemoria = new Memoria();
    LaMemoria.escribir('funcionarios', funcionarios);
    LimpiarCajasFuncionario();
    ListarFuncionarios();

}

function IncrementoIdFuncionario(){
    const LaMemoria = new Memoria();
    let codigo = LaMemoria.leer('funcionario-codigo');
    LaMemoria.escribir('funcionario-codigo', codigo+1);
}

function ListarFuncionarios() {
    let lista = document.getElementById('funcionario-lista').options;
    lista.length = 0;

    for (const objFunc of funcionarios) {
        let linea = objFunc.codigo + " : " + objFunc.nombre + " - " + objFunc.rol;
        let elemento = new Option(linea, objFunc.codigo);
        lista.add(elemento);
    }
}

function SeleccionarFuncionario(){
    let pCodigo = document.getElementById('funcionario-lista').value;
    
    for (const objFunc of funcionarios) {
        if(objFunc.codigo == pCodigo){
            document.getElementById('funcionario-codigo').value = objFunc.codigo;
            document.getElementById('funcionario-nombre').value = objFunc.nombre;
            document.getElementById('funcionario-rol').value = objFunc.rol;
        }
    }

}

function BuscarFuncionario(pCodigo){
    for (const objFunc of funcionarios) {
        if(objFunc.codigo == pCodigo){
            return objFunc;
        }
    }
    return null;
}

function BuscarPosicionFuncionario(pCodigo){
    for (let pos = 0; pos < funcionarios.length; pos++) {
        const objFunc = funcionarios[pos];
        if(objFunc.codigo == pCodigo){
            return pos;
        }
    }
    return -1;
}

window.InicioFuncionario = InicioFuncionario;
window.ListarFuncionarios = ListarFuncionarios;
window.AgregarFuncionario = AgregarFuncionario;
window.ModificarFuncionario = ModificarFuncionario;
window.EliminarFuncionario = EliminarFuncionario;
window.SeleccionarFuncionario = SeleccionarFuncionario;
window.LimpiarCajasFuncionario = LimpiarCajasFuncionario;

//#endregion

//#region Metodos de Clientes

let clientes = [];
function InicioCliente(){
    const LaMemoria = new Memoria();
    clientes = LaMemoria.leer('clientes');
    let codigo = LaMemoria.leer('cliente-codigo');
    if(!clientes){
        clientes = [];
    }
    if(!codigo){
        codigo = 1;
        LaMemoria.escribir('cliente-codigo',codigo);
    }
    LimpiarCajasCliente();
    ListarClientes();
}

function LimpiarCajasCliente(){
    const LaMemoria = new Memoria();
    document.getElementById('cliente-codigo').value = LaMemoria.leer('cliente-codigo');
    document.getElementById('cliente-nombre').value = "";
    document.getElementById('cliente-telefono').value = "";
    document.getElementById('cliente-email').value = "";
    document.getElementById('cliente-direccion').value = "";
}

function AgregarCliente() {
    let codigo = document.getElementById('cliente-codigo').value;
    let nombre = document.getElementById('cliente-nombre').value;
    let telefono = document.getElementById('cliente-telefono').value;
    let email = document.getElementById('cliente-email').value;
    let direccion = document.getElementById('cliente-direccion').value;

    if(!codigo || !nombre || !telefono || !email || !direccion){
        alert("Debe ingresar todos los campos!");
        return;
    }
    
    const unCliente = new Cliente(codigo, nombre, telefono, email, direccion);
    clientes.push(unCliente);
    
    const LaMemoria = new Memoria();
    LaMemoria.escribir('clientes', clientes);
    IncrementoIdCliente();
    LimpiarCajasCliente();
    ListarClientes();
}

function ModificarCliente(){
    let codigo = document.getElementById('cliente-codigo').value;
    let nombre = document.getElementById('cliente-nombre').value;
    let telefono = document.getElementById('cliente-telefono').value;
    let email = document.getElementById('cliente-email').value;
    let direccion = document.getElementById('cliente-direccion').value;

    if(!codigo || !nombre || !telefono || !email || !direccion){
        alert("Debe ingresar todos los campos!");
        return;
    }

    let unCliente = BuscarCliente(codigo);

    if(unCliente == null){
        alert("Cliente no encontrado!");
        return;
    }

    unCliente.nombre = nombre;
    unCliente.telefono = telefono;
    unCliente.email = email;
    unCliente.direccion = direccion;

    const LaMemoria = new Memoria();
    LaMemoria.escribir('clientes', clientes);
    LimpiarCajasCliente();
    ListarClientes();
}

function EliminarCliente(){
    let codigo = document.getElementById('cliente-codigo').value;
    let pos = BuscarPosicionCliente(codigo);

    if(pos == -1){
        alert("Cliente no encontrado!");
        return;
    }
    clientes.splice(pos,1);
    const LaMemoria = new Memoria();
    LaMemoria.escribir('clientes', clientes);
    LimpiarCajasCliente();
    ListarClientes();

}

function IncrementoIdCliente(){
    const LaMemoria = new Memoria();
    let codigo = LaMemoria.leer('cliente-codigo');
    LaMemoria.escribir('cliente-codigo', codigo+1);
}

function ListarClientes() {
    let lista = document.getElementById('cliente-lista').options;
    lista.length = 0;

    for (const objCliente of clientes) {
        let linea = objCliente.codigo + " : " + objCliente.nombre + " - " + objCliente.telefono
        + " - " + objCliente.email + " - " + objCliente.direccion;
        let elemento = new Option(linea, objCliente.codigo);
        lista.add(elemento);
    }
}

function SeleccionarCliente(){
    let pCodigo = document.getElementById('cliente-lista').value;
    
    for (const objCliente of clientes) {
        if(objCliente.codigo == pCodigo){
            document.getElementById('cliente-codigo').value = objCliente.codigo;
            document.getElementById('cliente-nombre').value = objCliente.nombre;
            document.getElementById('cliente-telefono').value = objCliente.telefono;
            document.getElementById('cliente-email').value = objCliente.email;
            document.getElementById('cliente-direccion').value = objCliente.direccion;
        }
    }

}

function BuscarCliente(pCodigo){
    for (const objCliente of clientes) {
        if(objCliente.codigo == pCodigo){
            return objCliente;
        }
    }
    return null;
}

function BuscarPosicionCliente(pCodigo){
    for (let pos = 0; pos < clientes.length; pos++) {
        const objCliente = clientes[pos];
        if(objCliente.codigo == pCodigo){
            return pos;
        }
    }
    return -1;
}

window.InicioCliente = InicioCliente;
window.ListarClientes = ListarClientes;
window.AgregarCliente = AgregarCliente;
window.ModificarCliente = ModificarCliente;
window.EliminarCliente = EliminarCliente;
window.SeleccionarCliente = SeleccionarCliente;
window.LimpiarCajasCliente = LimpiarCajasCliente;

//#endregion

//#region Metodos de Articulos

let articulos = [];
function InicioArticulo(){
    const LaMemoria = new Memoria();
    articulos = LaMemoria.leer('articulos');
    categorias = LaMemoria.leer('categorias');
    let codigo = LaMemoria.leer('articulo-codigo');
    if(!articulos){
        articulos = [];
    }
    if(!codigo){
        codigo = 1;
        LaMemoria.escribir('articulo-codigo',codigo);
    }
    LimpiarCajasArticulo();
    ListarArticulos();
    CargarCategorias();
}

function LimpiarCajasArticulo(){
    const LaMemoria = new Memoria();
    document.getElementById('articulo-codigo').value = LaMemoria.leer('articulo-codigo');
    document.getElementById('articulo-nombre').value = "";
    document.getElementById('articulo-descripcion').value = "";
    document.getElementById('articulo-marca').value = "";
    document.getElementById('articulo-precio').value = "";
    document.getElementById('articulo-stock').value = "";
    document.getElementById('articulo-categoria').value = "";
    document.getElementById('articulo-imagen').value = "";
    CargarImagenArticulo();
}

function AgregarArticulo() {
    let codigo = document.getElementById('articulo-codigo').value;
    let nombre = document.getElementById('articulo-nombre').value;
    let descripcion = document.getElementById('articulo-descripcion').value;
    let marca = document.getElementById('articulo-marca').value;
    let stock = parseInt(document.getElementById('articulo-stock').value);
    let precio = parseInt(document.getElementById('articulo-precio').value);
    let codCategoria = document.getElementById('articulo-categoria').value;
    let imagen = document.getElementById('articulo-imagen').value;

<<<<<<< Updated upstream
    if(!codigo || !nombre || !descripcion || !marca || !stock || !precio || !codCategoria || !imagen){
=======
    if(!codigo || !nombre || !descripcion || !marca || !stock || !precio || !codCategoria){
>>>>>>> Stashed changes
        alert("Debe ingresar todos los campos!");
        return;
    }

    const unaCategoria = BuscarCategoria(codCategoria);
    
    const unArticulo = new Articulo(codigo, nombre, descripcion, marca, unaCategoria, stock, precio, imagen);
    articulos.push(unArticulo);
    
    const LaMemoria = new Memoria();
    LaMemoria.escribir('articulos', articulos);
    IncrementoIdArticulo();
    LimpiarCajasArticulo();
    ListarArticulos();
}

function ModificarArticulo(){
    let codigo = document.getElementById('articulo-codigo').value;
    let nombre = document.getElementById('articulo-nombre').value;
    let descripcion = document.getElementById('articulo-descripcion').value;
    let marca = document.getElementById('articulo-marca').value;
    let stock = parseInt(document.getElementById('articulo-stock').value);
    let precio = parseInt(document.getElementById('articulo-precio').value);
    let codCategoria = document.getElementById('articulo-categoria').value;
    let imagen = document.getElementById('articulo-imagen').value;

<<<<<<< Updated upstream
    if(!codigo || !nombre || !descripcion || !marca || !stock || !precio || !codCategoria || !imagen){
=======
    if(!codigo || !nombre || !descripcion || !marca || !stock || !precio || !codCategoria){
>>>>>>> Stashed changes
        alert("Debe ingresar todos los campos!");
        return;
    }

    let unArticulo = BuscarArticulo(codigo);
    const unaCategoria = BuscarCategoria(codCategoria);

    if(unArticulo == null){
        alert("Articulo no encontrado!");
        return;
    }

    unArticulo.nombre = nombre;
    unArticulo.descripcion = descripcion;
    unArticulo.marca = marca;
    unArticulo.stock = stock;
    unArticulo.precio = precio;
    unArticulo.categoria = unaCategoria;
    unArticulo.imagen = imagen;

    const LaMemoria = new Memoria();
    LaMemoria.escribir('articulos', articulos);
    LimpiarCajasArticulo();
    ListarArticulos();
}

function EliminarArticulo(){
    let codigo = document.getElementById('articulo-codigo').value;
    let pos = BuscarPosicionArticulo(codigo);

    if(pos == -1){
        alert("Articulo no encontrado!");
        return;
    }
    articulos.splice(pos,1);
    const LaMemoria = new Memoria();
    LaMemoria.escribir('articulos', articulos);
    LimpiarCajasArticulo();
    ListarArticulos();

}

function IncrementoIdArticulo(){
    const LaMemoria = new Memoria();
    let codigo = LaMemoria.leer('articulo-codigo');
    LaMemoria.escribir('articulo-codigo', codigo+1);
}

function ListarArticulos() {
    let lista = document.getElementById('articulo-lista').options;
    lista.length = 0;

    for (const objArticulo of articulos) {
        let linea = objArticulo.codigo + " : " + objArticulo.categoria.nombre+ " : " + objArticulo.nombre
        + " - " + objArticulo.marca + " - Precio: $ " + objArticulo.precio + " - Stock: " + objArticulo.stock;
        let elemento = new Option(linea, objArticulo.codigo);
        lista.add(elemento);
    }
}

function SeleccionarArticulo(){
    let pCodigo = document.getElementById('articulo-lista').value;
    
    for (const objArticulo of articulos) {
        if(objArticulo.codigo == pCodigo){
            document.getElementById('articulo-codigo').value = objArticulo.codigo;
            document.getElementById('articulo-nombre').value = objArticulo.nombre;
            document.getElementById('articulo-descripcion').value = objArticulo.descripcion;
            document.getElementById('articulo-marca').value = objArticulo.marca;
            document.getElementById('articulo-stock').value = objArticulo.stock;
            document.getElementById('articulo-precio').value = objArticulo.precio;
            document.getElementById('articulo-categoria').value = objArticulo.categoria.codigo;
            document.getElementById('articulo-imagen').value = objArticulo.imagen;
            CargarImagenArticulo();
        }
    }

}

function BuscarArticulo(pCodigo){
    for (const objArticulo of articulos) {
        if(objArticulo.codigo == pCodigo){
            return objArticulo;
        }
    }
    return null;
}

function BuscarPosicionArticulo(pCodigo){
    for (let pos = 0; pos < articulos.length; pos++) {
        const objArticulo = articulos[pos];
        if(objArticulo.codigo == pCodigo){
            return pos;
        }
    }
    return -1;
}

function CargarCategorias(){
    let lista = document.getElementById('articulo-categoria').options;
    lista.length = 0;

    let inicial = new Option("Seleccione una categoría","");
        lista.add(inicial);

    for (const objCat of categorias) {
        let elemento = new Option(objCat.nombre, objCat.codigo);
        lista.add(elemento);
    }
}

function CargarImagenArticulo(){
    let imagen = document.getElementById('articulo-imagen').value;
    
    if(imagen != ""){
        document.getElementById('articulo-imagen-muestra').src = imagen;
        document.getElementById('articulo-imagen-muestra').style.display = "block";
        document.getElementById('articulo-etiqueta-muestra').style.display = "block";
    }else{
        document.getElementById('articulo-imagen-muestra').src = "";
        document.getElementById('articulo-imagen-muestra').style.display = "none";
        document.getElementById('articulo-etiqueta-muestra').style.display = "none";
    }
}

window.InicioArticulo = InicioArticulo;
window.ListarArticulos = ListarArticulos;
window.AgregarArticulo = AgregarArticulo;
window.ModificarArticulo = ModificarArticulo;
window.EliminarArticulo = EliminarArticulo;
window.SeleccionarArticulo = SeleccionarArticulo;
window.LimpiarCajasArticulo = LimpiarCajasArticulo;
window.CargarImagenArticulo = CargarImagenArticulo;

//#endregion

//#region Metodos de Ventas

let ventas = [];
function InicioVenta(){
    const LaMemoria = new Memoria();
    ventas = LaMemoria.leer('ventas');
    categorias = LaMemoria.leer('categorias');
    clientes = LaMemoria.leer('clientes');
    funcionarios = LaMemoria.leer('funcionarios');
    articulos = LaMemoria.leer('articulos');
    let codigo = LaMemoria.leer('venta-codigo');
    if(!ventas){
        ventas = [];
    }
    if(!codigo){
        codigo = 1;
        LaMemoria.escribir('venta-codigo',codigo);
    }
    LimpiarCajasVenta();
    ListarVentas();
    CargarCategoriasVenta();    
    CargarClientesVenta();
    CargarFuncionariosVenta();
<<<<<<< Updated upstream
}

function LimpiarCajasVenta(){
    const LaMemoria = new Memoria();
    document.getElementById('venta-codigo').value = LaMemoria.leer('venta-codigo');
    document.getElementById('venta-fecha').value = "";
=======

    let pCodArticulo = new URLSearchParams(window.location.search).get('articulo');
    
    if(pCodArticulo){
        const pArt = BuscarArticulo(pCodArticulo);
        document.getElementById('venta-categoria').value = pArt.categoria.codigo;
        CargarArticulosVenta();
        document.getElementById('venta-articulo').value = pArt.codigo;
        CargarImagenVenta();
    }
    
}

function LimpiarCajasVenta(){
    let hoy = new Date();
    console.log("HOY", hoy);
    
    let anio = hoy.getFullYear();
    let mes = ""+(hoy.getMonth()+1);
    mes = (mes.length == 1)?"0"+mes:mes;
    let dia = hoy.getDate();
    
    let fecha = anio + "-" + mes + "-" + dia;
    console.log("FECHA", fecha);

    const LaMemoria = new Memoria();
    document.getElementById('venta-codigo').value = LaMemoria.leer('venta-codigo');
    document.getElementById('venta-fecha').value = fecha;
>>>>>>> Stashed changes
    document.getElementById('venta-cliente').value = "";
    document.getElementById('venta-funcionario').value = "";
    document.getElementById('venta-articulo').value = "";
    document.getElementById('venta-importe').value = "";
    document.getElementById('venta-categoria').value = "";
    document.getElementById('venta-cantidad').value = "";
    CargarImagenVenta();
}

function AgregarVenta() {
    let codigo = document.getElementById('venta-codigo').value;
    let fecha = document.getElementById('venta-fecha').value;
    let codCliente = document.getElementById('venta-cliente').value;
    let codFuncionario = document.getElementById('venta-funcionario').value;
    let codArticulo = document.getElementById('venta-articulo').value;
    let cantidad = parseInt(document.getElementById('venta-cantidad').value);
    let importe = parseInt(document.getElementById('venta-importe').value);

    if(!codigo || !fecha || !codCliente || !codFuncionario || !codArticulo || !cantidad || !importe){
        alert("Debe ingresar todos los campos!");
        return;
    }

    const unCliente = BuscarCliente(codCliente);
    const unFuncionario = BuscarFuncionario(codFuncionario);
    const unArticulo = BuscarArticulo(codArticulo);
    
    const unVenta = new Venta(codigo, fecha, unArticulo, cantidad, importe, unCliente, unFuncionario);
    ventas.push(unVenta);
    
    const LaMemoria = new Memoria();
    LaMemoria.escribir('ventas', ventas);
    IncrementoIdVenta();
    LimpiarCajasVenta();
    ListarVentas();
}

function ModificarVenta(){
    let codigo = document.getElementById('venta-codigo').value;
    let nombre = document.getElementById('venta-nombre').value;
    let descripcion = document.getElementById('venta-descripcion').value;
    let marca = document.getElementById('venta-marca').value;
    let stock = parseInt(document.getElementById('venta-stock').value);
    let precio = parseInt(document.getElementById('venta-precio').value);
    let codCategoria = document.getElementById('venta-categoria').value;
    let imagen = document.getElementById('venta-imagen').value;

    if(!codigo || !nombre || !descripcion || !marca || !stock || !precio || !codCategoria || !imagen){
        alert("Debe ingresar todos los campos!");
        return;
    }

    let unVenta = BuscarVenta(codigo);
    const unaCategoria = BuscarCategoria(codCategoria);

    if(unVenta == null){
        alert("Venta no encontrado!");
        return;
    }

    unVenta.nombre = nombre;
    unVenta.descripcion = descripcion;
    unVenta.marca = marca;
    unVenta.stock = stock;
    unVenta.precio = precio;
    unVenta.categoria = unaCategoria;
    unVenta.imagen = imagen;

    const LaMemoria = new Memoria();
    LaMemoria.escribir('ventas', ventas);
    LimpiarCajasVenta();
    ListarVentas();
}

function EliminarVenta(){
    let codigo = document.getElementById('venta-codigo').value;
    let pos = BuscarPosicionVenta(codigo);

    if(pos == -1){
        alert("Venta no encontrado!");
        return;
    }
    ventas.splice(pos,1);
    const LaMemoria = new Memoria();
    LaMemoria.escribir('ventas', ventas);
    LimpiarCajasVenta();
    ListarVentas();

}

function IncrementoIdVenta(){
    const LaMemoria = new Memoria();
    let codigo = LaMemoria.leer('venta-codigo');
    LaMemoria.escribir('venta-codigo', codigo+1);
}

function ListarVentas() {
    let lista = document.getElementById('venta-lista').options;
    lista.length = 0;

    for (const objVenta of ventas) {
        let linea = objVenta.codigo + " : " + objVenta.cliente.nombre+ " - " + objVenta.articulo.nombre
        + " - Precio: $ " + objVenta.importe;
        let elemento = new Option(linea, objVenta.codigo);
        lista.add(elemento);
    }
}

function SeleccionarVenta(){
    let pCodigo = document.getElementById('venta-lista').value;
    
    for (const objVenta of ventas) {
        if(objVenta.codigo == pCodigo){
            document.getElementById('venta-codigo').value = objVenta.codigo;
            document.getElementById('venta-nombre').value = objVenta.nombre;
            document.getElementById('venta-descripcion').value = objVenta.descripcion;
            document.getElementById('venta-marca').value = objVenta.marca;
            document.getElementById('venta-stock').value = objVenta.stock;
            document.getElementById('venta-precio').value = objVenta.precio;
            document.getElementById('venta-categoria').value = objVenta.categoria.codigo;
            document.getElementById('venta-imagen').value = objVenta.imagen;
            CargarImagenVenta();
        }
    }

}

function BuscarVenta(pCodigo){
    for (const objVenta of ventas) {
        if(objVenta.codigo == pCodigo){
            return objVenta;
        }
    }
    return null;
}

function BuscarPosicionVenta(pCodigo){
    for (let pos = 0; pos < ventas.length; pos++) {
        const objVenta = ventas[pos];
        if(objVenta.codigo == pCodigo){
            return pos;
        }
    }
    return -1;
}

function CargarCategoriasVenta(){
    let lista = document.getElementById('venta-categoria').options;
    lista.length = 0;

    let inicial = new Option("Seleccione una categoría","");
        lista.add(inicial);

    for (const objCat of categorias) {
        let elemento = new Option(objCat.nombre, objCat.codigo);
        lista.add(elemento);
    }
<<<<<<< Updated upstream
    // CargarArticulosVenta();
=======
    let listaArt = document.getElementById('venta-articulo').options;
    listaArt.length = 0;

    let inicialArt = new Option("Seleccione un articulo","");
    lista.add(inicialArt);
>>>>>>> Stashed changes
}

function CargarClientesVenta(){
    let lista = document.getElementById('venta-cliente').options;
    lista.length = 0;

    let inicial = new Option("Seleccione un cliente","");
        lista.add(inicial);

    for (const objCli of clientes) {
        let elemento = new Option(objCli.nombre, objCli.codigo);
        lista.add(elemento);
    }
}

function CargarFuncionariosVenta(){
    let lista = document.getElementById('venta-funcionario').options;
    lista.length = 0;

    let inicial = new Option("Seleccione un funcionario","");
        lista.add(inicial);

    for (const objFunc of funcionarios) {
        let elemento = new Option(objFunc.nombre, objFunc.codigo);
        lista.add(elemento);
    }
}

function CargarArticulosVenta(){
    let lista = document.getElementById('venta-articulo').options;
    lista.length = 0;

    let codCategoria = document.getElementById('venta-categoria').value;

    let inicial = new Option("Seleccione un articulo","");
    lista.add(inicial);

    for (const objArt of articulos) {
        if(codCategoria == objArt.categoria.codigo){
            let elemento = new Option(objArt.nombre, objArt.codigo);
            lista.add(elemento);
        }
    }
<<<<<<< Updated upstream
=======
    CargarImagenVenta();
>>>>>>> Stashed changes
}

function CargarImagenVenta(){
    let codArticulo = document.getElementById('venta-articulo').value;
    
    if(codArticulo){
        const unArticulo = BuscarArticulo(codArticulo);
        
        let imagen = unArticulo.imagen;
<<<<<<< Updated upstream

        if(imagen != ""){
            document.getElementById('venta-imagen-muestra').src = imagen;
            document.getElementById('venta-imagen-muestra').style.display = "block";
            document.getElementById('venta-etiqueta-muestra').style.display = "block";
        }else{
            document.getElementById('venta-imagen-muestra').src = "";
            document.getElementById('venta-imagen-muestra').style.display = "none";
            document.getElementById('venta-etiqueta-muestra').style.display = "none";
        }
    }else{
        document.getElementById('venta-imagen-muestra').src = "";
        document.getElementById('venta-imagen-muestra').style.display = "none";
        document.getElementById('venta-etiqueta-muestra').style.display = "none";
=======
        let precio = unArticulo.marca + "<br>Precio: $ " + unArticulo.precio;

        if(imagen != ""){
            document.getElementById('venta-imagen-muestra').src = imagen;
            document.getElementById('venta-muestra-precio').innerHTML = precio;
            document.getElementById('venta-imagen-muestra').style.display = "block";
            document.getElementById('venta-muestra-marca').style.display = "block";
            document.getElementById('venta-muestra-precio').style.display = "block";
        }else{
            document.getElementById('venta-imagen-muestra').src = "https://www.losprincipios.org/images/default.jpg";
            document.getElementById('venta-muestra-precio').innerHTML = precio;
            document.getElementById('venta-imagen-muestra').style.display = "block";
            document.getElementById('venta-muestra-marca').style.display = "block";
            document.getElementById('venta-muestra-precio').style.display = "block";
        }
    }else{
        document.getElementById('venta-imagen-muestra').src = "";
        document.getElementById('venta-muestra-precio').innerHTML = "";
        document.getElementById('venta-imagen-muestra').style.display = "none";
        document.getElementById('venta-muestra-marca').style.display = "none";
        document.getElementById('venta-muestra-precio').style.display = "none";
>>>>>>> Stashed changes
    }
}

function CargarImporteVenta(){
    let codArticulo = document.getElementById('venta-articulo').value;
    let cantidad = document.getElementById('venta-cantidad').value;
    
    if(codArticulo){
        const unArticulo = BuscarArticulo(codArticulo);
        document.getElementById('venta-importe').value = cantidad * unArticulo.precio;
    }
}

window.InicioVenta = InicioVenta;
window.ListarVentas = ListarVentas;
window.AgregarVenta = AgregarVenta;
window.ModificarVenta = ModificarVenta;
window.EliminarVenta = EliminarVenta;
window.SeleccionarVenta = SeleccionarVenta;
window.LimpiarCajasVenta = LimpiarCajasVenta;
window.CargarImagenVenta = CargarImagenVenta;
window.CargarArticulosVenta = CargarArticulosVenta;
window.CargarImporteVenta = CargarImporteVenta;

//#endregion

//#region Metodos de Catalogo

function InicioCatalogo(){
    const LaMemoria = new Memoria();
    categorias = LaMemoria.leer('categorias');
    articulos = LaMemoria.leer('articulos');
    CargarCategoriasCatalogo();
<<<<<<< Updated upstream
=======
    CargarArticulosCatalogo();
>>>>>>> Stashed changes
}

function CargarCategoriasCatalogo(){
    let lista = document.getElementById('catalogo-categoria').options;
    lista.length = 0;

<<<<<<< Updated upstream
    let inicial = new Option("Seleccione una categoría","");
=======
    let inicial = new Option("Todas las categorías","");
>>>>>>> Stashed changes
        lista.add(inicial);

    for (const objCat of categorias) {
        let elemento = new Option(objCat.nombre, objCat.codigo);
        lista.add(elemento);
    }
}

function CargarArticulosCatalogo(){
    let codCategoria = document.getElementById('catalogo-categoria').value;
    let lista = "";
    for (const objArt of articulos) {
        if(codCategoria){
            if(codCategoria == objArt.categoria.codigo){
<<<<<<< Updated upstream
                lista+= `<li><div class="card" style="width: 10rem;">
=======
                lista+= `<li><div class="card" style="width: 15rem; align-items: center;">
>>>>>>> Stashed changes
                        <img src="${objArt.imagen}" class="img-mini">
                        <div class="card-body">
                            <h6 class="card-title">${objArt.nombre}</h6>
                            <p class="card-text">${objArt.marca}</p>
                        </div>
                        <ul class="list-group list-group-flush">
                            <li class="list-group-item">${objArt.descripcion}</li>
<<<<<<< Updated upstream
                            <li class="list-group-item">$ ${objArt.precio}</li>
                        </ul>
                        <div class="card-body">
                            <a href="#" class="card-link">Comprar</a>
=======
                            <li class="list-group-item"><strong>$ ${objArt.precio}</strong></li>
                        </ul>
                        <div class="card-body">
                            <a href="./ventas.html?articulo=${objArt.codigo}" class="btn btn-warning">Comprar</a>
>>>>>>> Stashed changes
                        </div>
                        </div></li>`;
            }
        }else{
<<<<<<< Updated upstream
            lista+= `<li>${objArt.nombre}</li>`;
=======
            lista+= `<li><div class="card" style="width: 15rem;  align-items: center;">
                    <img src="${objArt.imagen}" class="img-mini">
                    <div class="card-body">
                        <h6 class="card-title">${objArt.nombre}</h6>
                        <p class="card-text">${objArt.marca}</p>
                    </div>
                    <ul class="list-group list-group-flush">
                        <li class="list-group-item">${objArt.descripcion}</li>
                        <li class="list-group-item"><strong>$ ${objArt.precio}</strong></li>
                    </ul>
                    <div class="card-body">
                        <a href="./ventas.html?articulo=${objArt.codigo}" class="btn btn-warning">Comprar</a>
                    </div>
                    </div></li>`;
>>>>>>> Stashed changes
        }
    }
    document.getElementById('catalogo-lista').innerHTML = lista;
}

window.InicioCatalogo = InicioCatalogo;
window.CargarArticulosCatalogo = CargarArticulosCatalogo;

<<<<<<< Updated upstream
//#endregion
=======
//#endregion

//region Metodos de Estadisticas

function InicioEstadistica() {
    const LaMemoria = new Memoria();
    categorias = LaMemoria.leer('categorias');
    articulos = LaMemoria.leer('articulos');
    clientes = LaMemoria.leer('clientes');
    ventas = LaMemoria.leer('ventas');
}

function EstadisticaBuscarCliente() {
    let cliente = document.getElementById('est-cliente-nombre').value.toLowerCase();
    let codigoCliente;
    for (const objCliente of clientes) {
        if (objCliente.nombre.toLowerCase().includes(cliente)) {
            document.getElementById('est-cliente-encontrado').value = objCliente.codigo + " : " + objCliente.nombre;
            codigoCliente = objCliente.codigo;
        }
    }

    let lista = document.getElementById('est-ventas-cliente').options;
    lista.length = 0;
    if(codigoCliente) {
        for(const objVenta of ventas) {
            if(objVenta.cliente.codigo == codigoCliente) {
                let venta = `${objVenta.fecha} : ${objVenta.articulo.nombre} - $ ${objVenta.importe}`;
                let linea = new Option(venta);
                lista.add(linea);
            }
        }
        if(lista.length == 0) {
            let vacio = new Option("El cliente no tiene ventas");
            lista.add(vacio);
        }
    }
    else {
        alert("Cliente no encontrado");
        }
    }

    function EstadisticaVentasPorFecha() {
        let desde = document.getElementById('est-venta-fecha-desde').value;
        let hasta = document.getElementById('est-venta-fecha-hasta').value;

        let lista = document.getElementById('est-ventas-por-fecha').options;
        lista.length - 0;
        for(const objVenta of ventas) {
            if(objVenta.fecha >= desde && objVenta.fecha <= hasta) {
                let venta = `${objVenta.fecha} : ${objVenta.articulo.nombre} - $ ${objVenta.importe}`;
                let linea = new Option(venta);
                lista.add(linea);
            }
        }
    }

    

    window.InicioEstadistica = InicioEstadistica;
    window.EstadisticaBuscarCliente = EstadisticaBuscarCliente;
    window.EstadisticaVentasPorFecha = EstadisticaVentasPorFecha;

    //#endregion
>>>>>>> Stashed changes

export class Venta{
    constructor(pCodigo, pFecha, pArticulo, pCantidad, pImporte, pCliente, pFuncionario){
        this.codigo = pCodigo;
        this.fecha = pFecha;
        this.articulo = pArticulo;
        this.cantidad = pCantidad;
        this.importe = pImporte;
        this.cliente = pCliente;
        this.funcionario = pFuncionario;
    }
}
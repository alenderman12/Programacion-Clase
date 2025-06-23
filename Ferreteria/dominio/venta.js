export class Venta {
     
    constructor(pId, pFecha, pCliente, pFuncionario, pArticulo, pCantidad, pImporte) {
        this.id = pId;
        this.fecha = pFecha;
        this.cliente = pCliente;
        this.funcionario = pFuncionario;
        this.articulo = pArticulo;
        this.cantidad = pCantidad;
        this.importe = pImporte;
    }

}
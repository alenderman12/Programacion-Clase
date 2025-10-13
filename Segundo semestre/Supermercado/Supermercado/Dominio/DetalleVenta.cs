using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class DetalleVenta
    {
        private int aId;
        private Producto aProducto;
        private double aPrecio;
        private int aCantidad;
        public int Id
        {
            get { return aId; }
            set { aId = value; }
        }
        public Producto Producto
        {
            get { return aProducto; }
            set { aProducto = value; }
        }
        public double Precio
        {
            get { return aPrecio; }
            set { aPrecio = value; }
        }
        public int Cantidad
        {
            get { return aCantidad; }
            set { aCantidad = value; }
        }

        public override string ToString()
        {
            return $"{this.Id} : {this.Producto.Nombre} - {this.Precio} - {this.Cantidad}";
        }

        public DetalleVenta(int pId, Producto pProducto, double pPrecio, int pCantidad)
        {
            Id = pId;
            Producto = pProducto;
            Precio = pPrecio;
            Cantidad = pCantidad;
        }
    }
}

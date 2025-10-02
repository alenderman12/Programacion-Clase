using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class Producto
    {
        private int aId;
        private string aNombre;
        private string aMarca;
        private Familia aFamilia;
        private string aUnidad;
        private float aPrecio;
        private int aStock;

        public int Id
        {
            get { return aId; }
            set { aId = value; }
        }
        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }
        public string Marca
        {
            get { return aMarca; }
            set { aMarca = value; }
        }
        public Familia Familia
        {
            get { return aFamilia; }
            set { aFamilia = value; }
        }
        public string Unidad
        {
            get { return aUnidad; }
            set { aUnidad = value; }
        }
        public float Precio
        {
            get { return aPrecio; }
            set { aPrecio = value; }
        }
        public int Stock
        {
            get { return aStock; }
            set { aStock = value; }
        }
        public override string ToString()
        {
            return $"{this.Id} : {this.Nombre} - {this.Marca} - {this.Familia.Nombre} - {this.Unidad} - {this.Precio} - {this.Stock}";
        }
        public Producto(int pId, string pNombre, string pMarca, Familia pFamilia, string pUnidad, float pPrecio, int pStock)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Marca = pMarca;
            this.Familia = pFamilia;
            this.Unidad = pUnidad;
            this.Precio = pPrecio;
            this.Stock = pStock;
        }
    }
}

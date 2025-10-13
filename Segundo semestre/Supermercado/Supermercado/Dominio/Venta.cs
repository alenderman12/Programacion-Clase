using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class Venta
    {
        private int aId;
        private DateTime aFecha;
        private Cliente aCliente;
        private Empleado aEmpleado;
        private double aTotal;
        private List<DetalleVenta> aDetalles;
        public int Id
        {
            get { return aId; }
            set { aId = value; }
        }
        public DateTime Fecha
        {
            get { return aFecha; }
            set { aFecha = value; }
        }
        public Cliente Cliente
        {
            get { return aCliente; }
            set { aCliente = value; }
        }
        public Empleado Empleado
        {
            get { return aEmpleado; }
            set { aEmpleado = value; }
        }
        public double Total
        {
            get { return aTotal; }
            set { aTotal = value; }
        }
        public List<DetalleVenta> Detalles
        {
            get { return aDetalles; }
            set { aDetalles = value; }
        }
        public override string ToString()
        {
            return $"{this.Id} : {this.Fecha.ToShortDateString()} - {this.Cliente.Nombre} - {this.Total}";
        }
        public Venta(int pId, DateTime pFecha, Cliente pCliente, List<DetalleVenta> pDetalles, double pTotal)
        {
            Id = pId;
            Fecha = pFecha;
            Cliente = pCliente;
            Detalles = pDetalles;
            Total = pTotal;
        }
    }
}

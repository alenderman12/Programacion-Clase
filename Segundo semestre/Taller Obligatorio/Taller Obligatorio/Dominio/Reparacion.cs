using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Obligatorio.Dominio
{
    public class Reparacion
    {
        private int aId;
        private DateTime aFecha;
        private Vehiculo aVehiculo;
        private Cliente aDueno;
        private string aDescripcion;
        private int aCosto;

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
        public Vehiculo Vehiculo
        {
            get { return aVehiculo; }
            set { aVehiculo = value; }
        }
        public Cliente Dueno
        {
            get { return aDueno; }
            set { aDueno = value; }
        }
        public string Descripcion
        {
            get { return aDescripcion; }
            set { aDescripcion = value; }
        }
        public int Costo
        {
            get { return aCosto; }
            set { aCosto = value; }
        }
        public override string ToString()
        {
            return $"{this.Id} : {this.Fecha} - {this.Vehiculo.Matricula} - " +
                $"{this.Dueno.Nombre} - {this.Descripcion} - {this.Costo}";
        }
        public Reparacion(int pId, DateTime pFecha, Vehiculo pVehiculo, 
            Cliente pDueno, string pDescripcion, int pCosto)
        {
            this.Id = pId;
            this.Fecha = pFecha;
            this.Vehiculo = pVehiculo;
            this.Dueno = pDueno;
            this.Descripcion = pDescripcion;
            this.Costo = pCosto;
        }
    }
}

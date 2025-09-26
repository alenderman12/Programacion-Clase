using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class Persona
    {
        private int aId;
        private string aNombre;
        private string aDireccion;
        private string aTelefono;

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
        public string Direccion
        {
            get { return aDireccion; }
            set { aDireccion = value; }
        }
        public string Telefono
        {
            get { return aTelefono; }
            set { aTelefono = value; }
        }

        public override string ToString()
        {
            return $"{this.Id} : {this.Nombre} - {this.Direccion} - {this.Telefono}";
        }

        public Persona(int pId, string pNombre, string pDireccion, string pTelefono)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
        }
    }
}

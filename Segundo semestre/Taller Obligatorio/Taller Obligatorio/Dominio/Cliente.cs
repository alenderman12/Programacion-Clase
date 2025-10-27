using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Obligatorio.Dominio
{
    class Cliente
    {
        private int aId;
        private string aNombre;
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
        public string Telefono
        {
            get { return aTelefono; }
            set { aTelefono = value; }
        }
        public override string ToString()
        {
            return $"{Id} : {Nombre}";
        }

        public Cliente(int pId, string pNombre, string pTelefono)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
        }

    }
}

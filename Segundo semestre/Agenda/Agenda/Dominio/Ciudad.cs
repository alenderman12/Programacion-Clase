using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio
{
    class Ciudad
    {
        private int aId;
        private string aNombre;

        public int Id
        {
            get { return aId; }
            set { aId = value; }
        }
        public string Nombre { 
            get { return aNombre; } 
            set { aNombre = value; } 
        }
        public override string ToString()
        {
            return this.Id + " : " + this.Nombre;
        }
        public Ciudad(int pId, string pNombre) { 
            Id = pId;
            Nombre = pNombre;
        }

    }
}

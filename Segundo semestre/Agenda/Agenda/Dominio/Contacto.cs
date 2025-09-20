using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio
{
    class Contacto
    {
        private int aId;
        private string aNombre;
        private string aTelefono;
        private string aEmail;
        private Ciudad aCiudad;

        public int Id { 
            get { return aId; } 
            set { aId = value; }
        }
        public string Nombre {
            get { return aNombre; } 
            set { aNombre = value; } 
        }
        public string Telefono { 
            get { return aTelefono; }
            set { aTelefono = value; } 
        }
        public string Email { 
            get { return aEmail; }
            set { aEmail = value; }
        }
        public Ciudad Ciudad
        {
            get { return aCiudad; }
            set { aCiudad = value; }
        }
        public override string ToString()
        {
            return this.Id + " : " + this.Nombre + " - " + this.Telefono + " - " + this.Email + " - " + this.Ciudad.Nombre;
        }

        public Contacto(int pId, string pNombre, string pTelefono, string pEmail, Ciudad pCiudad)
        {
            Id = pId;
            Nombre = pNombre;
            Telefono = pTelefono;
            Email = pEmail;
            Ciudad = pCiudad;
        }
    }
}

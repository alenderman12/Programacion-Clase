using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class Empleado : Persona
    {
        private float aSueldo;
        private string aCargo;

        public float Sueldo
        {
            get { return aSueldo; }
            set { aSueldo = value; }
        }

        public string Cargo
        {
            get { return aCargo; }
            set { aCargo = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {this.Sueldo} - {this.Cargo}";
        }

        public Empleado(int pId, string pNombre, string pDireccion, string pTelefono, float pSueldo, string pCargo)
            : base(pId, pNombre, pDireccion, pTelefono)
        {
            this.Sueldo = pSueldo;
            this.Cargo = pCargo;
        }
    }
}

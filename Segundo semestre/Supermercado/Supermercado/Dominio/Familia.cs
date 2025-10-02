using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class Familia
    {
        private int aId;
        private string aNombre;

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

        public override string ToString()
        {
            return $"{aId} : {aNombre}";
        }

        public Familia(int pId, string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;
        }
    }
}

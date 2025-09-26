using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class Cliente : Persona
    {
        private int aDescuento;
        private int aPuntos;
        public int Descuento
        {
            get { return aDescuento; }
            set { aDescuento = value; }
        }
        public int Puntos
        {
            get { return aPuntos; }
            set { aPuntos = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {this.Descuento}% - {this.Puntos} pts.";
        }

        public Cliente(int pId, string pNombre, string pDireccion, string pTelefono, int pDescuento, int pPuntos)
            : base(pId, pNombre, pDireccion, pTelefono)
        {
            this.Descuento = pDescuento;
            this.Puntos = pPuntos;
        }
    }
}

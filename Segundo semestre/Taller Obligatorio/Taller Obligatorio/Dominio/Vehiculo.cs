using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Obligatorio.Dominio
{
    class Vehiculo
    {
        private int aId;
        private string aMatricula;
        private string aModelo;
        private string aMarca;
        private Cliente aDueno;

        public int Id
        {
            get { return aId; }
            set { aId = value; }
        }
        public string Matricula
        {
            get { return aMatricula; }
            set { aMatricula = value; }
        }
        public string Modelo
        {
            get { return aModelo; }
            set { aModelo = value; }
        }
        public string Marca
        {
            get { return aMarca; }
            set { aMarca = value; }
        }
        public Cliente Dueno
        {
            get { return aDueno; }
            set { aDueno = value; }
        }
        public override string ToString()
        {
            return $"{this.Id} : {this.Marca} - {this.Modelo} - {this.Dueno.Nombre} - {this.Matricula}";
        }
        public Vehiculo(int pId, string pMatricula, string pModelo, string pMarca, Cliente pDueno)
        {
            this.Id = pId;
            this.Matricula = pMatricula;
            this.Modelo = pModelo;
            this.Marca = pMarca;
            this.Dueno = pDueno;
        }
    }
}

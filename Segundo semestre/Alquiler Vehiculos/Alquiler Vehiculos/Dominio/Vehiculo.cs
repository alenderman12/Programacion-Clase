namespace Alquiler_Vehiculos.Dominio
{
    public class Vehiculo
    {
        private int aIdVehiculo;
        private string aMatricula;
        private string aMarca;
        private string aModelo;
        private int aAnio;
        private string aTipo;
        private int aCapacidad;
        private string aCombustible;
        private string aColor;
        private double aPrecioPorDia;
        private char aEstado;
        private string aImagenLink;

        public int Id {  get { return aIdVehiculo; } set { aIdVehiculo = value; } }
        public string Matricula { get { return aMatricula; } set { aMatricula = value; } }
        public string Marca { get { return aMarca; } set { aMarca = value; } }
        public string Modelo { get { return aModelo; } set { aModelo = value; } }
        public int Anio { get { return aAnio; } set { aAnio = value; } }
        public string Tipo { get { return aTipo; } set { aTipo = value; } }
        public int Capacidad { get { return aCapacidad; } set { aCapacidad = value; } }
        public string Combustible { get { return aCombustible; } set { aCombustible = value; } }
        public string Color { get { return aColor; } set { aColor = value; } }
        public double PrecioPorDia { get { return aPrecioPorDia; } set { aPrecioPorDia = value; } }
        public char Estado { get { return aEstado; } set { aEstado = value; } }
        public string ImagenLink { get { return aImagenLink; } set { aImagenLink = value; } }


        public Vehiculo(int pId, string pMatricula, string pMarca, string pModelo, int pAnio, string pTipo, int pCapacidad, 
            string pCombustible, string pColor, double pPrecioPorDia, char pEstado, string pImagenLink)
        {
            this.Id = pId;
            this.Matricula = pMatricula;
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.Anio = pAnio;
            this.Tipo = pTipo;
            this.Capacidad = pCapacidad;
            this.Combustible = pCombustible;
            this.Color = pColor;
            this.PrecioPorDia = pPrecioPorDia;
            this.Estado = pEstado;
            this.ImagenLink = pImagenLink;
        }
    }
}

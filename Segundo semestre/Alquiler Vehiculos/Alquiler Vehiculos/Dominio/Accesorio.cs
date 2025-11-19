namespace Alquiler_Vehiculos.Dominio
{
    public class Accesorio
    {
        private int aIdAccesorio;
        private string aNombre;
        private string aDescripcion;
        private double aPrecio;

        public int Id { get { return aIdAccesorio; } set { aIdAccesorio = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Descripcion { get { return aDescripcion; } set { aDescripcion = value; } }
        public double Precio { get { return aPrecio; } set { aPrecio = value; } }

        public Accesorio(int pIdAccesorio, string pNombre, string pDescripcion, double pPrecio)
        {
            this.Id = pIdAccesorio;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;
        }
    }
}

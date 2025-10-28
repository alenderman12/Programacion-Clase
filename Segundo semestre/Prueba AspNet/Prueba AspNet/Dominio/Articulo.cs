namespace Prueba_AspNet.Dominio
{
    public class Articulo
    {
        private int aId;
        private string aNombre;
        private string aRubro;
        private double aPrecio;
        private int aStock;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Rubro { get { return aRubro; } set { aRubro = value; } }
        public double Precio { get { return aPrecio; } set { aPrecio = value; } }
        public int Stock { get { return aStock; } set { aStock = value; } }

        public Articulo(int pId, string pNombre, string pRubro, double pPrecio, int pStock)
        {
            aId = pId;
            aNombre = pNombre;
            aRubro = pRubro;
            aPrecio = pPrecio;
            aStock = pStock;
        }
    }
}

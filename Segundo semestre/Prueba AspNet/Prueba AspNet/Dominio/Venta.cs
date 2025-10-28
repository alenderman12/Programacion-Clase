namespace Prueba_AspNet.Dominio
{
    public class Venta
    {
        private int aId;
        private DateTime aFecha;
        private Cliente aCliente;
        private Articulo aArticulo;
        private double aImporte;

        public int Id { get { return aId; } set { aId = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public Articulo Articulo { get { return aArticulo; } set { aArticulo = value; } }
        public double Importe { get { return aImporte; } set { aImporte = value; } }

        public Venta(int pId, DateTime pFecha, Cliente pCliente, Articulo pArticulo, double pImporte)
        {
            Id = pId;
            Fecha = pFecha;
            Cliente = pCliente;
            Articulo = pArticulo;
            Importe = pImporte;
        }
    }
}
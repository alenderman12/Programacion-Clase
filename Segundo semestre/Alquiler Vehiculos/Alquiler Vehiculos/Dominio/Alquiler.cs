namespace Alquiler_Vehiculos.Dominio
{
    public class Alquiler
    {
        private int aIdAlquiler;
        private DateTime aFechaRealizadaReserva;
        private DateTime aFechaInicio;
        private DateTime aFechaFin;
        private Vehiculo aVehiculo;
        private Cliente aCliente;
        private List<Accesorio> aListaAccesorios;
        private string aLugarRetiro;
        private string aLugarDevolucion;
        private double aPrecioTotal;
        private char aEstado;

        public int Id { get { return aIdAlquiler; } set { aIdAlquiler = value; } }
        public DateTime FechaRealizadaReserva { get { return aFechaRealizadaReserva; } set { aFechaRealizadaReserva = value; } }
        public DateTime FechaInicio { get { return aFechaInicio; } set { aFechaInicio = value; } }
        public DateTime FechaFin { get { return aFechaFin; } set { aFechaFin = value; } }
        public Vehiculo Vehiculo { get { return aVehiculo; } set { aVehiculo = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public List<Accesorio> ListaAccesorios { get { return aListaAccesorios; } set { aListaAccesorios = value; } }
        public string LugarRetiro { get { return aLugarRetiro; } set { aLugarRetiro = value; } }
        public string LugarDevolucion { get { return aLugarDevolucion; } set { aLugarDevolucion = value; } }
        public double PrecioTotal { get { return aPrecioTotal; } set { aPrecioTotal = value; } }
        public char Estado { get { return aEstado; } set { aEstado = value; } }

        public Alquiler(int pIdAlquiler, DateTime pFechaRealizadaReserva, DateTime pFechaInicio, DateTime pFechaFin,
            Vehiculo pVehiculo, Cliente pCliente, List<Accesorio> pListaAccesorios, string pLugarRetiro,
            string pLugarDevolucion, double pPrecioTotal, char pEstado)
        {
            this.Id = pIdAlquiler;
            this.FechaRealizadaReserva = pFechaRealizadaReserva;
            this.FechaInicio = pFechaInicio;
            this.FechaFin = pFechaFin;
            this.Vehiculo = pVehiculo;
            this.Cliente = pCliente;
            this.ListaAccesorios = pListaAccesorios;
            this.LugarRetiro = pLugarRetiro;
            this.LugarDevolucion = pLugarDevolucion;
            this.PrecioTotal = pPrecioTotal;
            this.Estado = pEstado;
        }
    }
}

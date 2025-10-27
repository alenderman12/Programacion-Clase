namespace Prueba_AspNet.Dominio
{
    public class Cliente
    {
        private int aId;
        private string aNombre;
        private string aDireccion;
        private string aTelefono;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public string Telefono { get { return aTelefono; } set { aTelefono = value; } }

        public Cliente(int pId, string pNombre, string pDireccion, string pTelefono) 
        {
            Id = pId;
            Nombre = pNombre;
            Direccion = pDireccion;
            Telefono = pTelefono;
        }
    }
}

namespace Alquiler_Vehiculos.Dominio
{
    public class Cliente
    {
        private int aIdCliente;
        private string aCedula;
        private string aNombre;
        private string aApellido;
        private DateTime aFechaNacimiento;
        private string aTelefono;
        private string aEmail;
        private string aDireccion;
        private string aNroLibreta;
        private DateTime aVencimientoLibreta;

        public int Id { get { return aIdCliente; } set { aIdCliente = value; } }
        public string Cedula { get { return aCedula; } set { aCedula = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Apellido { get { return aApellido; } set { aApellido = value; } }
        public DateTime FechaNacimiento { get { return aFechaNacimiento; } set { aFechaNacimiento = value; } }
        public string Telefono { get { return aTelefono; } set { aTelefono = value; } }
        public string Email { get { return aEmail; } set { aEmail = value; } }
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public string NroLibreta { get { return aNroLibreta; } set { aNroLibreta = value; } }
        public DateTime VencimientoLibreta { get { return aVencimientoLibreta; } set { aVencimientoLibreta = value; } }

        public Cliente(int pId, string pNombre, string pApellido, DateTime pFechaNacimiento, string pCedula, string pTelefono, 
            string pEmail, string pDireccion, string NroLibreta, DateTime pVencimientoLibreta)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.FechaNacimiento = pFechaNacimiento;
            this.Cedula = pCedula;
            this.Telefono = pTelefono;
            this.Email = pEmail;
            this.Direccion = pDireccion;
            this.NroLibreta = NroLibreta;
            this.VencimientoLibreta = pVencimientoLibreta;
        }
    }
}

namespace Alquiler_Vehiculos.Dominio
{
    public class Controladora
    {
        private static List<Vehiculo> aListaVehiculos = new List<Vehiculo>();
        private static List<Cliente> aListaClientes = new List<Cliente>();
        private static List<Alquiler> aListaAlquileres = new List<Alquiler>();
        private static List<Accesorio> aListaAccesorios = new List<Accesorio>();


        #region Vehiculos 

        public List<Cliente> ListarClientes()
        {
            //aListaClientes = Persistencia.ListaClientes();
            return aListaClientes;
        }

        public Cliente BuscarCliente(int pId)
        {
            foreach (Cliente cliente in aListaClientes)
            {
                if (cliente.Id == pId)
                {
                    return cliente;
                }
            }
            return null;
        }

        public bool AltaCliente(Cliente pCliente)
        {
            Cliente cliente = BuscarCliente(pCliente.Id);
            if (cliente == null)
            {
                //if (Persistencia.AltaCliente(pCliente))
                {
                    aListaClientes.Add(pCliente);
                    return true;
                }
            }
            return false;
        }
        public bool BajaCliente(int pId)
        {
            Cliente cliente = BuscarCliente(pId);
            if (cliente != null)
            {
                //if (Persistencia.BajaCliente(pId))
                {
                    aListaClientes.Remove(cliente);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarCliente(int pId, string pNombre, string pApellido, DateTime pFechaNacimiento, string pCedula, string pTelefono,
            string pEmail, string pDireccion, string NroLibreta, DateTime pVencimientoLibreta)
        {
            Cliente cliente = BuscarCliente(pId);
            if (cliente != null)
            {
                //Cliente nuevoCliente = new Cliente(pId, pNombre, pApellido, pFechaNacimiento, pCedula, pTelefono, pEmail, pDireccion, 
                //  NroLibreta, pVencimientoLibreta);
                //if (Persistencia.ModificarCliente(nuevoCliente))
                {
                    cliente.Nombre = pNombre;
                    cliente.Direccion = pDireccion;
                    cliente.Telefono = pTelefono;
                    return true;
                }
            }
            return false;
        }

        #endregion

    }
}

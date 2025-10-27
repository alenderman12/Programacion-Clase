using System.Security.Cryptography;

namespace Prueba_AspNet.Dominio
{
    public class Controladora
    {
        public List<Cliente> aListaClientes = new List<Cliente>();

        public List<Cliente> ListarClientes()
        {
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
                aListaClientes.Add(pCliente);
                return true;
            }
            return false;
        }
        public bool BajaCliente(int pId)
        {
            Cliente cliente = BuscarCliente(pId);
            if (cliente != null)
            {
                aListaClientes.Remove(cliente);
                return true;
            }
            return false;
        }
        public bool ModificarCliente(int pId, string pNombre, string pDireccion, string pTelefono)
        {
            Cliente cliente = BuscarCliente(pId);
            if (cliente != null)
            {
                cliente.Nombre = pNombre;
                cliente.Direccion = pDireccion;
                cliente.Telefono = pTelefono;
                return true;
            }
            return false;
        }
    }
}

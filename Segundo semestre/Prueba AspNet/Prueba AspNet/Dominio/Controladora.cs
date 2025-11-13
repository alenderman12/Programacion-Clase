using Prueba_AspNet.Persistencia;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Prueba_AspNet.Dominio
{
    public class Controladora
    {
        private PControladora Persistencia;

        public static List<Cliente> aListaClientes = new List<Cliente>();
        public static List<Articulo> aListaArticulos = new List<Articulo>();
        public static List<Venta> aListaVentas = new List<Venta>();

        public Controladora()
        {
            Persistencia = new PControladora();
        }   

        #region ABM Clientes
        public List<Cliente> ListarClientes()
        {
            aListaClientes = Persistencia.ListaClientes();
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
                if (Persistencia.AltaCliente(pCliente))
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
                if (Persistencia.BajaCliente(pId))
                {
                    aListaClientes.Remove(cliente);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarCliente(int pId, string pNombre, string pDireccion, string pTelefono)
        {
            Cliente cliente = BuscarCliente(pId);
            if (cliente != null)
            {
                Cliente nuevoCliente = new Cliente(pId, pNombre, pDireccion, pTelefono);
                if (Persistencia.ModificarCliente(nuevoCliente))
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

        #region ABM Articulos
        public List<Articulo> ListarArticulos()
        {
            aListaArticulos = Persistencia.ListaArticulos();
            return aListaArticulos;
        }

        public Articulo BuscarArticulo(int pId)
        {
            foreach (Articulo articulo in aListaArticulos)
            {
                if (articulo.Id == pId)
                {
                    return articulo;
                }
            }
            return null;
        }

        public bool AltaArticulo(Articulo pArticulo)
        {
            Articulo articulo = BuscarArticulo(pArticulo.Id);
            if (articulo == null)
            {
                if (Persistencia.AltaArticulo(pArticulo))
                {
                    aListaArticulos.Add(pArticulo);
                    return true;
                }
            }
            return false;
        }
        public bool BajaArticulo(int pId)
        {
            Articulo articulo = BuscarArticulo(pId);
            if (articulo != null)
            {
                if (Persistencia.BajaArticulo(pId))
                {
                    aListaArticulos.Remove(articulo);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarArticulo(int pId, string pNombre, string pRubro, double pPrecio, int pStock)
        {
            Articulo articulo = BuscarArticulo(pId);
            if (articulo != null)
            {
                Articulo nuevoArticulo = new Articulo(pId, pNombre, pRubro, pPrecio, pStock);
                if (Persistencia.ModificarArticulo(nuevoArticulo))
                {
                    articulo.Nombre = pNombre;
                    articulo.Rubro = pRubro;
                    articulo.Precio = pPrecio;
                    articulo.Stock = pStock;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region ABM Ventas
        public List<Venta> ListarVentas()
        {
            return aListaVentas;
        }

        public Venta BuscarVenta(int pId)
        {
            foreach (Venta venta in aListaVentas)
            {
                if (venta.Id == pId)
                {
                    return venta;
                }
            }
            return null;
        }

        public bool AltaVenta(Venta pVenta)
        {
            Venta venta = BuscarVenta(pVenta.Id);
            if (venta == null)
            {
                aListaVentas.Add(pVenta);
                return true;
            }
            return false;
        }
        public bool BajaVenta(int pId)
        {
            Venta venta = BuscarVenta(pId);
            if (venta != null)
            {
                aListaVentas.Remove(venta);
                return true;
            }
            return false;
        }
        public bool ModificarVenta(int pId, DateTime pFecha, Articulo pArticulo, Cliente pCliente, double pImporte)
        {
            Venta venta = BuscarVenta(pId);
            if (venta != null)
            {
                venta.Fecha = pFecha;
                venta.Articulo = pArticulo;
                venta.Cliente = pCliente;
                venta.Importe = pImporte;
                return true;
            }
            return false;
        }

        #endregion

        public void CargarDatos()
        {
            aListaClientes.Add(new Cliente(1, "Juan Perez", "Calle Falsa 123", "123456789"));
            aListaClientes.Add(new Cliente(2, "Maria Gomez", "Avenida Siempre Viva 456", "987654321"));
            aListaClientes.Add(new Cliente(3, "Carlos Lopez", "Boulevard Central 789", "456123789"));
        }
    }
}

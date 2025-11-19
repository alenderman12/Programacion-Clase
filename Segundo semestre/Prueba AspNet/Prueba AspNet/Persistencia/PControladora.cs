using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Persistencia
{
    public class PControladora
    {
        #region " Clientes "
        public List<Cliente> ListaClientes()
        {
            return new PCliente().ListaClientes();
        }
        public bool AltaCliente(Cliente mCliente)
        {
            return new PCliente().Alta(mCliente);
        }
        public bool BajaCliente(int pId)
        {
            return new PCliente().Baja(pId);
        }
        public bool ModificarCliente(Cliente mCliente)
        {
            return new PCliente().Modificar(mCliente);
        }
        public int ProximoClienteId()
        {
            return new PCliente().ProximoId();
        }
        #endregion 
        #region " Articulos "
        public List<Articulo> ListaArticulos()
        {
            return new PArticulo().ListaArticulos();
        }
        public bool AltaArticulo(Articulo mArticulo)
        {
            return new PArticulo().Alta(mArticulo);
        }
        public bool BajaArticulo(int pId)
        {
            return new PArticulo().Baja(pId);
        }
        public bool ModificarArticulo(Articulo mArticulo)
        {
            return new PArticulo().Modificar(mArticulo);
        }
        public int ProximoArticuloId()
        {
            return new PArticulo().ProximoId();
        }
        #endregion 
        #region " Ventas "
        public List<Venta> ListaVentas()
        {
            return new PVenta().ListaVentas();
        }
        public bool AltaVenta(Venta mVenta)
        {
            return new PVenta().Alta(mVenta);
        }
        public bool BajaVenta(int pId)
        {
            return new PVenta().Baja(pId);
        }
        public bool ModificarVenta(Venta mVenta)
        {
            return new PVenta().Modificar(mVenta);
        }
        public int ProximoVentaId()
        {
            return new PVenta().ProximoId();
        }
        #endregion
    }
}

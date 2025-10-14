using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dominio
{
    class Controladora
    {
        private static List<Familia> aListaFamilias = new List<Familia>();
        private static List<Producto> aListaProductos = new List<Producto>();
        private static List<Empleado> aListaEmpleados = new List<Empleado>();
        private static List<Cliente> aListaClientes = new List<Cliente>();
        private static List<Venta> aListaVentas = new List<Venta>();
        private static List<DetalleVenta> aListaDetalleVentas = new List<DetalleVenta>();
        private static int aIdFamilia = 1;
        private static int aIdProducto = 1;
        private static int aIdEmpleado = 1;
        private static int aIdCliente = 1;
        private static int aIdVenta = 1;
        private static int aIdDetalleVenta = 1;

        #region ABM Familias
        public List<Familia> ListaFamilias()
        {
            return aListaFamilias;
        }
        public Familia BuscarFamilia(int pId)
        {
            foreach (var familia in aListaFamilias)
            {
                if (familia.Id == pId)
                {
                    return familia;
                }
            }
            return null;
        }
        public int IdFamilia()
        {
            return aIdFamilia;
        }
        public bool AltaFamilia(Familia pFamilia)
        {
            Familia unFamilia = this.BuscarFamilia(pFamilia.Id);
            if (unFamilia == null)
            {
                aListaFamilias.Add(pFamilia);
                aIdFamilia++;
                return true;
            }
            return false;
        }
        public bool BajaFamilia(int pId)
        {
            Familia unFamilia = this.BuscarFamilia(pId);
            if (unFamilia != null)
            {
                aListaFamilias.Remove(unFamilia);
                return true;
            }
            return false;
        }
        public bool ModificarFamilia(int pId, string pNombre)
        {
            Familia unFamilia = this.BuscarFamilia(pId);
            if (unFamilia != null)
            {
                unFamilia.Nombre = pNombre;
                return true;
            }
            return false;
        }
        #endregion

        #region ABM Productos
        public List<Producto> ListaProductos()
        {
            return aListaProductos;
        }
        public Producto BuscarProducto(int pId)
        {
            foreach (var producto in aListaProductos)
            {
                if (producto.Id == pId)
                {
                    return producto;
                }
            }
            return null;
        }
        public int IdProducto()
        {
            return aIdProducto;
        }
        public bool AltaProducto(Producto pProducto)
        {
            Producto unProducto = this.BuscarProducto(pProducto.Id);
            if (unProducto == null)
            {
                aListaProductos.Add(pProducto);
                aIdProducto++;
                return true;
            }
            return false;
        }
        public bool BajaProducto(int pId)
        {
            Producto unProducto = this.BuscarProducto(pId);
            if (unProducto != null)
            {
                aListaProductos.Remove(unProducto);
                return true;
            }
            return false;
        }
        public bool ModificarProducto(int pId, string pNombre, string pMarca, Familia pFamilia, string pUnidad, float pPrecio, int pStock)
        {
            Producto unProducto = this.BuscarProducto(pId);
            if (unProducto != null)
            {
                unProducto.Nombre = pNombre;
                unProducto.Marca = pMarca;
                unProducto.Familia = pFamilia;
                unProducto.Unidad = pUnidad;
                unProducto.Precio = pPrecio;
                unProducto.Stock = pStock;
                return true;
            }
            return false;
        }
        #endregion

        #region ABM Empleados
        public List<Empleado> ListaEmpleados()
        {
            return aListaEmpleados;
        }
        public Empleado BuscarEmpleado(int pId)
        {
            foreach (var empleado in aListaEmpleados)
            {
                if (empleado.Id == pId)
                {
                    return empleado;
                }
            }
            return null;
        }
        public int IdEmpleado()
        {
            return aIdEmpleado;
        }
        public bool AltaEmpleado(Empleado pEmpleado)
        {
            Empleado unEmpleado = this.BuscarEmpleado(pEmpleado.Id);
            if (unEmpleado == null)
            {
                aListaEmpleados.Add(pEmpleado);
                aIdEmpleado++;
                return true;
            }
            return false;
        }
        public bool BajaEmpleado(int pId)
        {
            Empleado unEmpleado = this.BuscarEmpleado(pId);
            if (unEmpleado != null)
            {
                aListaEmpleados.Remove(unEmpleado);
                return true;
            }
            return false;
        }
        public bool ModificarEmpleado(int pId, string pNombre, string pDireccion, string pTelefono, float pSueldo, string pCargo)
        {
            Empleado unEmpleado = this.BuscarEmpleado(pId);
            if (unEmpleado != null)
            {
                unEmpleado.Nombre = pNombre;
                unEmpleado.Telefono = pTelefono;
                unEmpleado.Direccion = pDireccion;
                unEmpleado.Sueldo = pSueldo;
                unEmpleado.Cargo = pCargo;
                return true;
            }
            return false;
        }
        #endregion

        #region ABM Clientes
        public List<Cliente> ListaClientes()
        {
            return aListaClientes;
        }
        public Cliente BuscarCliente(int pId)
        {
            foreach (var cliente in aListaClientes)
            {
                if (cliente.Id == pId)
                {
                    return cliente;
                }
            }
            return null;
        }
        public int IdCliente()
        {
            return aIdCliente;
        }
        public bool AltaCliente(Cliente pCliente)
        {
            Cliente unCliente = this.BuscarCliente(pCliente.Id);
            if (unCliente == null)
            {
                aListaClientes.Add(pCliente);
                aIdCliente++;
                return true;
            }
            return false;
        }
        public bool BajaCliente(int pId)
        {
            Cliente unCliente = this.BuscarCliente(pId);
            if (unCliente != null)
            {
                aListaClientes.Remove(unCliente);
                return true;
            }
            return false;
        }
        public bool ModificarCliente(int pId, string pNombre, string pDireccion, string pTelefono, int pDescuento, int pPuntos)
        {
            Cliente unCliente = this.BuscarCliente(pId);
            if (unCliente != null)
            {
                unCliente.Nombre = pNombre;
                unCliente.Direccion = pDireccion;
                unCliente.Telefono = pTelefono;
                unCliente.Descuento = pDescuento;
                unCliente.Puntos = pPuntos;
                return true;
            }
            return false;
        }
        #endregion

        #region ABM Ventas
        public List<Venta> ListaVentas()
        {
            return aListaVentas;
        }
        public Venta BuscarVenta(int pId)
        {
            foreach (var venta in aListaVentas)
            {
                if (venta.Id == pId)
                {
                    return venta;
                }
            }
            return null;
        }
        public int IdVenta()
        {
            return aIdVenta;
        }
        public bool AltaVenta(Venta pVenta)
        {
            Venta unaVenta = this.BuscarVenta(pVenta.Id);
            if (unaVenta == null)
            {
                aListaVentas.Add(pVenta);
                aIdVenta++;
                return true;
            }
            return false;
        }
        public bool BajaVenta(int pId)
        {
            Venta unaVenta = this.BuscarVenta(pId);
            if (unaVenta != null)
            {
                aListaVentas.Remove(unaVenta);
                return true;
            }
            return false;
        }
        public bool ModificarVenta(int pId, DateTime pFecha, Cliente pCliente, Empleado pEmpleado, double pTotal, List<DetalleVenta> pDetalles)
        {
            Venta unaVenta = this.BuscarVenta(pId);
            if (unaVenta != null)
            {
                unaVenta.Fecha = pFecha;
                unaVenta.Cliente = pCliente;
                unaVenta.Empleado = pEmpleado;
                unaVenta.Total = pTotal;
                unaVenta.Detalles = pDetalles;
                return true;
            }
            return false;
        }
        #endregion

        #region ABM DetalleVentas
        public List<DetalleVenta> ListaDetalleVentas()
        {
            return aListaDetalleVentas;
        }
        public DetalleVenta BuscarDetalleVenta(int pId)
        {
            foreach (var detalleVenta in aListaDetalleVentas)
            {
                if (detalleVenta.Id == pId)
                {
                    return detalleVenta;
                }
            }
            return null;
        }
        public int IdDetalleVenta()
        {
            return aIdDetalleVenta;
        }
        public bool AltaDetalleVenta(DetalleVenta pDetalleVenta)
        {
            DetalleVenta unDetalleVenta = this.BuscarDetalleVenta(pDetalleVenta.Id);
            if (unDetalleVenta == null)
            {
                aListaDetalleVentas.Add(pDetalleVenta);
                aIdDetalleVenta++;
                return true;
            }
            return false;
        }
        public bool BajaDetalleVenta(int pId)
        {
            DetalleVenta unDetalleVenta = this.BuscarDetalleVenta(pId);
            if (unDetalleVenta != null)
            {
                aListaDetalleVentas.Remove(unDetalleVenta);
                return true;
            }
            return false;
        }
        public bool ModificarDetalleVenta(int pId, Producto pProducto, double pPrecio, int pCantidad)
        {
            DetalleVenta unDetalleVenta = this.BuscarDetalleVenta(pId);
            if (unDetalleVenta != null)
            {
                unDetalleVenta.Producto = pProducto;
                unDetalleVenta.Precio = pPrecio;
                unDetalleVenta.Cantidad = pCantidad;
                return true;
            }
            return false;
        }
        #endregion

        public void CargarDatos()
        {
            Familia f1 = new Familia(aIdFamilia, "Lacteos");
            this.AltaFamilia(f1);
            Familia f2 = new Familia(aIdFamilia, "Fiambres");
            this.AltaFamilia(f2);
            Familia f3 = new Familia(aIdFamilia, "Bebidas");
            this.AltaFamilia(f3);

            Producto p1 = new Producto(aIdProducto, "Leche", "La Serenisima", f1, "Litros", 150.50f, 20);
            this.AltaProducto(p1);
            Producto p2 = new Producto(aIdProducto, "Queso", "La Paulina", f1, "Kilos", 850.75f, 15);
            this.AltaProducto(p2);
            Producto p3 = new Producto(aIdProducto, "Jamon", "Paladini", f2, "Kilos", 1250.00f, 10);
            this.AltaProducto(p3);

            Empleado e1 = new Empleado(aIdEmpleado, "Juan Perez", "Calle Falsa 123", "123456789", 55000.00f, "Cajero");
            this.AltaEmpleado(e1);
            Empleado e2 = new Empleado(aIdEmpleado, "Maria Gomez", "Avenida Siempre Viva 742", "987654321", 60000.00f, "Repositor");
            this.AltaEmpleado(e2);
            Empleado e3 = new Empleado(aIdEmpleado, "Carlos Lopez", "Boulevard Central 456", "456789123", 70000.00f, "Gerente");
            this.AltaEmpleado(e3);

            Cliente c1 = new Cliente(aIdCliente, "Ana Martinez", "Calle Luna 321", "321654987", 10, 150);
            this.AltaCliente(c1);
            Cliente c2 = new Cliente(aIdCliente, "Luis Rodriguez", "Avenida Sol 654", "789123456", 5, 80);
            this.AltaCliente(c2);
            Cliente c3 = new Cliente(aIdCliente, "Sofia Fernandez", "Boulevard Estrella 987", "654987321", 15, 200);
            this.AltaCliente(c3);

            DetalleVenta dv1 = new DetalleVenta(aIdDetalleVenta, p1, p1.Precio, 2);
            this.AltaDetalleVenta(dv1);
            DetalleVenta dv2 = new DetalleVenta(aIdDetalleVenta, p2, p2.Precio, 1);
            this.AltaDetalleVenta(dv2);
            DetalleVenta dv3 = new DetalleVenta(aIdDetalleVenta, p3, p3.Precio, 3);
            this.AltaDetalleVenta(dv3);
            List<DetalleVenta> lista1 = new List<DetalleVenta> { dv1, dv2 };
            List<DetalleVenta> lista2 = new List<DetalleVenta> { dv3 };
            List<DetalleVenta> lista3 = new List<DetalleVenta> { dv1, dv2, dv3 };

            Venta v1 = new Venta(aIdVenta, DateTime.Now, c1, e1, lista1, dv1.Precio * dv1.Cantidad + dv2.Precio * dv2.Cantidad);
            this.AltaVenta(v1);
            Venta v2 = new Venta(aIdVenta, DateTime.Now, c2, e2, lista2, dv3.Precio * dv3.Cantidad);
            this.AltaVenta(v2);
            Venta v3 = new Venta(aIdVenta, DateTime.Now, c3, e3, lista3, dv1.Precio * dv1.Cantidad + dv2.Precio * dv2.Cantidad + dv3.Precio * dv3.Cantidad);
            this.AltaVenta(v3);

        }
    }
}

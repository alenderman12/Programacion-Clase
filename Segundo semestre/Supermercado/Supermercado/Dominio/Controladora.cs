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
        private static int aIdFamilia = 1;
        private static int aIdProducto = 1;
        private static int aIdEmpleado = 1;
        private static int aIdCliente = 1;

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
        public bool AltaFamilia(Familia pFamilia)
        {
            Familia unFamilia = this.BuscarFamilia(pFamilia.Id);
            if (unFamilia == null)
            {
                aListaFamilias.Add(pFamilia);
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
        public bool AltaProducto(Producto pProducto)
        {
            Producto unProducto = this.BuscarProducto(pProducto.Id);
            if (unProducto == null)
            {
                aListaProductos.Add(pProducto);
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
        public bool AltaEmpleado(Empleado pEmpleado)
        {
            Empleado unEmpleado = this.BuscarEmpleado(pEmpleado.Id);
            if (unEmpleado == null)
            {
                aListaEmpleados.Add(pEmpleado);
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
        public bool AltaCliente(Cliente pCliente)
        {
            Cliente unCliente = this.BuscarCliente(pCliente.Id);
            if (unCliente == null)
            {
                aListaClientes.Add(pCliente);
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
        public bool ModificarCliente(int pId, string pNombre, string pTelefono, string pDireccion, int pDescuento, int pPuntos)
        {
            Cliente unCliente = this.BuscarCliente(pId);
            if (unCliente != null)
            {
                unCliente.Nombre = pNombre;
                unCliente.Telefono = pTelefono;
                unCliente.Direccion = pDireccion;
                unCliente.Descuento = pDescuento;
                unCliente.Puntos = pPuntos;
                return true;
            }
            return false;
        }
        #endregion
    }
}

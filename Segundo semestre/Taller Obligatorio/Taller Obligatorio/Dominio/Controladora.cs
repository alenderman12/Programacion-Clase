using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Obligatorio.Dominio
{
    public class Controladora
    {
        private static List<Cliente> aListaClientes = new List<Cliente>();
        private static List<Reparacion> aListaReparaciones = new List<Reparacion>();
        private static List<Vehiculo> aListaVehiculos = new List<Vehiculo>();
        private static int aIdCliente = 1;
        private static int aIdReparacion = 1;
        private static int aIdVehiculo = 1;

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
        public bool ModificarCliente(int pId, string pNombre, string pTelefono)
        {
            Cliente unCliente = this.BuscarCliente(pId);
            if (unCliente != null)
            {
                unCliente.Nombre = pNombre;
                unCliente.Telefono = pTelefono;
                return true;
            }
            return false;
        }
        #endregion

        #region ABM Vehiculos
        public List<Vehiculo> ListaVehiculos()
        {
            return aListaVehiculos;
        }
        public Vehiculo BuscarVehiculo(int pId)
        {
            foreach (var vehiculo in aListaVehiculos)
            {
                if (vehiculo.Id == pId)
                {
                    return vehiculo;
                }
            }
            return null;
        }
        public int IdVehiculo()
        {
            return aIdVehiculo;
        }
        public bool AltaVehiculo(Vehiculo pVehiculo)
        {
            Vehiculo unVehiculo = this.BuscarVehiculo(pVehiculo.Id);
            if (unVehiculo == null)
            {
                aListaVehiculos.Add(pVehiculo);
                aIdVehiculo++;
                return true;
            }
            return false;
        }
        public bool BajaVehiculo(int pId)
        {
            Vehiculo unVehiculo = this.BuscarVehiculo(pId);
            if (unVehiculo != null)
            {
                aListaVehiculos.Remove(unVehiculo);
                return true;
            }
            return false;
        }
        public bool ModificarVehiculo(int pId, string pMatricula, string pModelo, string pMarca, Cliente pDueno)
        {
            Vehiculo unVehiculo = this.BuscarVehiculo(pId);
            if (unVehiculo != null)
            {
                unVehiculo.Matricula = pMatricula;
                unVehiculo.Modelo = pModelo;
                unVehiculo.Marca = pMarca;
                unVehiculo.Dueno = pDueno;
                return true;
            }
            return false;
        }
        #endregion

        #region ABM Reparaciones
        public List<Reparacion> ListaReparaciones()
        {
            return aListaReparaciones;
        }
        public Reparacion BuscarReparacion(int pId)
        {
            foreach (var reparacion in aListaReparaciones)
            {
                if (reparacion.Id == pId)
                {
                    return reparacion;
                }
            }
            return null;
        }
        public int IdReparacion()
        {
            return aIdReparacion;
        }
        public bool AltaReparacion(Reparacion pReparacion)
        {
            Reparacion unReparacion = this.BuscarReparacion(pReparacion.Id);
            if (unReparacion == null)
            {
                aListaReparaciones.Add(pReparacion);
                aIdReparacion++;
                return true;
            }
            return false;
        }
        public bool BajaReparacion(int pId)
        {
            Reparacion unReparacion = this.BuscarReparacion(pId);
            if (unReparacion != null)
            {
                aListaReparaciones.Remove(unReparacion);
                return true;
            }
            return false;
        }
        public bool ModificarReparacion(int pId, DateTime pFecha, Vehiculo pVehiculo,
            Cliente pDueno, string pDescripcion, int pCosto)
        {
            Reparacion unReparacion = this.BuscarReparacion(pId);
            if (unReparacion != null)
            {
                unReparacion.Fecha = pFecha;
                unReparacion.Vehiculo = pVehiculo;
                unReparacion.Dueno = pDueno;
                unReparacion.Descripcion = pDescripcion;
                unReparacion.Costo = pCosto;
                return true;
            }
            return false;
        }
        #endregion
        public void CargarDatos()
        {
            Cliente cliente1 = new Cliente(aIdCliente, "Juan Perez", "123456789");
            this.AltaCliente(cliente1);
            Cliente cliente2 = new Cliente(aIdCliente, "Maria Gomez", "987654321");
            this.AltaCliente(cliente2);
            Vehiculo vehiculo1 = new Vehiculo(aIdVehiculo, "ABC123", "ModeloX", "MarcaY", cliente1);
            this.AltaVehiculo(vehiculo1);
            Vehiculo vehiculo2 = new Vehiculo(aIdVehiculo, "DEF456", "ModeloA", "MarcaB", cliente2);
            this.AltaVehiculo(vehiculo2);
            Reparacion reparacion1 = new Reparacion(aIdReparacion, DateTime.Now, vehiculo1, cliente1, "Cambio de aceite", 500);
            this.AltaReparacion(reparacion1);
            Reparacion reparacion2 = new Reparacion(aIdReparacion, DateTime.Now, vehiculo2, cliente2, "Reparacion de frenos", 800);
            this.AltaReparacion(reparacion2);
        }
    }
}

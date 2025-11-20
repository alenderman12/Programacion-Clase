namespace Alquiler_Vehiculos.Dominio
{
    public class Controladora
    {
        private static List<Vehiculo> aListaVehiculos = new List<Vehiculo>();
        private static List<Cliente> aListaClientes = new List<Cliente>();
        private static List<Alquiler> aListaAlquileres = new List<Alquiler>();
        private static List<Accesorio> aListaAccesorios = new List<Accesorio>();

        #region Vehiculos 

        public List<Vehiculo> ListarVehiculos()
        {
            //aListaVehiculos = Persistencia.ListaVehiculos();
            return aListaVehiculos;
        }

        public Vehiculo BuscarVehiculo(int pId)
        {
            foreach (Vehiculo vehiculo in aListaVehiculos)
            {
                if (vehiculo.Id == pId)
                {
                    return vehiculo;
                }
            }
            return null;
        }

        public bool AltaVehiculo(Vehiculo pVehiculo)
        {
            Vehiculo vehiculo = BuscarVehiculo(pVehiculo.Id);
            if (vehiculo == null)
            {
                //if (Persistencia.AltaVehiculo(pVehiculo))
                {
                    aListaVehiculos.Add(pVehiculo);
                    return true;
                }
            }
            return false;
        }
        public bool BajaVehiculo(int pId)
        {
            Vehiculo vehiculo = BuscarVehiculo(pId);
            if (vehiculo != null)
            {
                //if (Persistencia.BajaVehiculo(pId))
                {
                    aListaVehiculos.Remove(vehiculo);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarVehiculo(int pId, string pMatricula, string pMarca, string pModelo, int pAnio, string pTipo, int pCapacidad,
            string pCombustible, string pColor, double pPrecioPorDia, char pEstado, string pImagenLink)
        {
            Vehiculo vehiculo = BuscarVehiculo(pId);
            if (vehiculo != null)
            {
                //Vehiculo nuevoVehiculo = new Vehiculo(pId, pNombre, pApellido, pFechaNacimiento, pCedula, pTelefono, pEmail, pDireccion, 
                //  NroLibreta, pVencimientoLibreta);
                //if (Persistencia.ModificarVehiculo(nuevoVehiculo))
                {
                    vehiculo.Matricula = pMatricula;
                    vehiculo.Marca = pMarca;
                    vehiculo.Modelo = pModelo;
                    vehiculo.Anio = pAnio;
                    vehiculo.Tipo = pTipo;
                    vehiculo.Capacidad = pCapacidad;
                    vehiculo.Combustible = pCombustible;
                    vehiculo.Color = pColor;
                    vehiculo.PrecioPorDia = pPrecioPorDia;
                    vehiculo.Estado = pEstado;
                    vehiculo.ImagenLink = pImagenLink;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Clientes 

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
                    cliente.Apellido = pApellido;
                    cliente.FechaNacimiento = pFechaNacimiento;
                    cliente.Cedula = pCedula;
                    cliente.Telefono = pTelefono;
                    cliente.Email = pEmail;
                    cliente.Direccion = pDireccion;
                    cliente.NroLibreta = NroLibreta;
                    cliente.VencimientoLibreta = pVencimientoLibreta;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Alquileres 

        public List<Alquiler> ListarAlquileres()
        {
            //aListaAlquileres = Persistencia.ListaAlquileres();
            return aListaAlquileres;
        }

        public Alquiler BuscarAlquiler(int pId)
        {
            foreach (Alquiler alquiler in aListaAlquileres)
            {
                if (alquiler.Id == pId)
                {
                    return alquiler;
                }
            }
            return null;
        }

        public bool AltaAlquiler(Alquiler pAlquiler)
        {
            Alquiler alquiler = BuscarAlquiler(pAlquiler.Id);
            if (alquiler == null)
            {
                //if (Persistencia.AltaAlquiler(pAlquiler))
                {
                    aListaAlquileres.Add(pAlquiler);
                    return true;
                }
            }
            return false;
        }
        public bool BajaAlquiler(int pId)
        {
            Alquiler alquiler = BuscarAlquiler(pId);
            if (alquiler != null)
            {
                //if (Persistencia.BajaAlquiler(pId))
                {
                    aListaAlquileres.Remove(alquiler);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarAlquiler(int pId, DateTime pFechaRealizadaReserva, DateTime pFechaInicio, DateTime pFechaFin,
            Vehiculo pVehiculo, Cliente pCliente, List<Accesorio> pListaAccesorios, string pLugarRetiro,
            string pLugarDevolucion, double pPrecioTotal, char pEstado)
        {
            Alquiler alquiler = BuscarAlquiler(pId);
            if (alquiler != null)
            {
                //Alquiler nuevoAlquiler = new Alquiler(pId, pNombre, pApellido, pFechaNacimiento, pCedula, pTelefono, pEmail, pDireccion, 
                //  NroLibreta, pVencimientoLibreta);
                //if (Persistencia.ModificarAlquiler(nuevoAlquiler))
                {
                    alquiler.FechaRealizadaReserva = pFechaRealizadaReserva;
                    alquiler.FechaInicio = pFechaInicio;
                    alquiler.FechaFin = pFechaFin;
                    alquiler.Vehiculo = pVehiculo;
                    alquiler.Cliente = pCliente;
                    alquiler.ListaAccesorios = pListaAccesorios;
                    alquiler.LugarRetiro = pLugarRetiro;
                    alquiler.LugarDevolucion = pLugarDevolucion;
                    alquiler.PrecioTotal = pPrecioTotal;
                    alquiler.Estado = pEstado;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Accesorios 

        public List<Accesorio> ListarAccesorios()
        {
            //aListaAccesorios = Persistencia.ListaAccesorios();
            return aListaAccesorios;
        }

        public Accesorio BuscarAccesorio(int pId)
        {
            foreach (Accesorio accesorio in aListaAccesorios)
            {
                if (accesorio.Id == pId)
                {
                    return accesorio;
                }
            }
            return null;
        }

        public bool AltaAccesorio(Accesorio pAccesorio)
        {
            Accesorio accesorio = BuscarAccesorio(pAccesorio.Id);
            if (accesorio == null)
            {
                //if (Persistencia.AltaAccesorio(pAccesorio))
                {
                    aListaAccesorios.Add(pAccesorio);
                    return true;
                }
            }
            return false;
        }
        public bool BajaAccesorio(int pId)
        {
            Accesorio accesorio = BuscarAccesorio(pId);
            if (accesorio != null)
            {
                //if (Persistencia.BajaAccesorio(pId))
                {
                    aListaAccesorios.Remove(accesorio);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarAccesorio(int pId, string pNombre, string pDescripcion, double pPrecio)
        {
            Accesorio accesorio = BuscarAccesorio(pId);
            if (accesorio != null)
            {
                //Accesorio nuevoAccesorio = new Accesorio(pId, pNombre, pApellido, pFechaNacimiento, pCedula, pTelefono, pEmail, pDireccion, 
                //  NroLibreta, pVencimientoLibreta);
                //if (Persistencia.ModificarAccesorio(nuevoAccesorio))
                {
                    accesorio.Nombre = pNombre;
                    accesorio.Descripcion = pDescripcion;
                    accesorio.Precio = pPrecio;
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}

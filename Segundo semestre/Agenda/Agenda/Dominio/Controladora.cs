using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio
{
    class Controladora
    {
        private static List<Ciudad> aListaCiudad = new List<Ciudad>();
        private static int aIdCiudad = 1;
        private static List<Contacto> aListaContacto = new List<Contacto>();
        private static int aIdContacto = 1;


        #region Ciudades
        public int IdCiudad
        {
            get { return aIdCiudad; }
        }
        public void IncrementarIdCiudad()
        {
            aIdCiudad++;
        }
        public List<Ciudad> ListaCiudades()
        {
            return aListaCiudad;
        }
        public Ciudad BuscarCiudad(int pId)
        {
            foreach (var ciudad in aListaCiudad)
            {
                if (ciudad.Id == pId)
                {
                    return ciudad;
                }
            }
            return null;
        }
        public bool AltaCiudad(Ciudad pCiudad)
        {
            Ciudad unaCiudad = this.BuscarCiudad(pCiudad.Id);
            if (unaCiudad == null)
            {
                IncrementarIdCiudad();
                aListaCiudad.Add(pCiudad);
                return true;
            }
            return false;
        }
        public bool BajaCiudad(int pId)
        {
            Ciudad unaCiudad = this.BuscarCiudad(pId);
            if (unaCiudad != null)
            {
                aListaCiudad.Remove(unaCiudad);
                return true;
            }
            return false;
        }
        public bool ModificarCiudad(int pId, string pNombre)
        {
            Ciudad unaCiudad = this.BuscarCiudad(pId);
            if (unaCiudad != null)
            {
                unaCiudad.Nombre = pNombre;
                return true;
            }
            return false;
        }
        #endregion

        #region Contactos
        public int IdContacto
        {
            get { return aIdContacto; }
        }
        public void IncrementarIdContacto()
        {
            aIdContacto++;
        }
        public List<Contacto> ListaContactos()
        {
            return aListaContacto;
        }
        public Contacto BuscarContacto(int pId)
        {
            foreach (var contacto in aListaContacto)
            {
                if (contacto.Id == pId)
                {
                    return contacto;
                }
            }
            return null;
        }
        public bool AltaContacto(Contacto pContacto)
        {
            Contacto unContacto = this.BuscarContacto(pContacto.Id);
            if (unContacto == null)
            {
                IncrementarIdContacto();
                aListaContacto.Add(pContacto);
                return true;
            }
            return false;
        }
        public bool BajaContacto(int pId)
        {
            Contacto unContacto = this.BuscarContacto(pId);
            if (unContacto != null)
            {
                aListaContacto.Remove(unContacto);
                return true;
            }
            return false;
        }
        public bool ModificarContacto(int pId, string pNombre, string pTelefono, string pEmail, Ciudad pCiudad)
        {
            Contacto unContacto = this.BuscarContacto(pId);
            if (unContacto != null)
            {
                unContacto.Nombre = pNombre;
                unContacto.Telefono = pTelefono;
                unContacto.Email = pEmail;
                unContacto.Ciudad = pCiudad;
                return true;
            }
            return false;
        }
        #endregion
    }
}

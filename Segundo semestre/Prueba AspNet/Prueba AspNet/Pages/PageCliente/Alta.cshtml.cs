using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;
using Prueba_AspNet.Pages.PageCliente;
using System.Reflection.Metadata;

namespace Prueba_AspNet.Pages.PageCliente
{
    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 1;
        public void OnGet()
        {
            Controladora controladora = new Controladora();
            id = controladora.ProximoClienteId();
        }
        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un ID");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID debe ser numerico");
                }
                if (Request.Form["nombre"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un Nombre");
                }
                if (Request.Form["direccion"] == string.Empty)
                {
                    throw new Exception("Debe ingresar una Direccion");
                }
                if (Request.Form["telefono"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un Telefono");
                }
                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                string Direccion = Request.Form["direccion"];
                string Telefono = Request.Form["telefono"];

                Cliente cliente = new Cliente(Id, Nombre, Direccion, Telefono);

                Controladora controladora = new Controladora();
                controladora.AltaCliente(cliente);

                return RedirectToPage("/PageCliente/Lista");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            return Page();
        }
    }
}

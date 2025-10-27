using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;
using Prueba_AspNet.Pages.PageCliente;

namespace Prueba_AspNet.Pages.PageCliente
{
    public class ModificarModel : PageModel
    {
        public Cliente cliente { get; set; }
        public void OnGet(int id)
        {
            Controladora controladora = new Controladora();
            cliente = controladora.BuscarCliente(id);
        }

        public IActionResult OnPostModificar()
        {
            int Id = int.Parse(Request.Form["id"]);
            string Nombre = Request.Form["nombre"];
            string Direccion = Request.Form["direccion"];
            string Telefono = Request.Form["telefono"];

            Controladora controladora = new Controladora();
            controladora.ModificarCliente(Id, Nombre, Direccion, Telefono);

            return RedirectToPage("/PageCliente/Lista");
        }
    }
}

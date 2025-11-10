using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageCliente
{
    public class BajaModel : PageModel
    {
        public Cliente cliente { get; set; }
        Controladora controladora = new Controladora();
        public void OnGet(int id)
        {
            cliente = controladora.BuscarCliente(id);
        }
        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);
            controladora.BajaCliente(Id);
            return Redirect("./Lista");
        }
    }
}

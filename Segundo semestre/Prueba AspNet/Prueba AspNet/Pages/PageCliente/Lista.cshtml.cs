using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PagesCliente
{
    public class ListaModel : PageModel
    {
        public List<Cliente> clientes = new List<Cliente>();
        Controladora controladora = new Controladora();
        public void OnGet()
        {
            clientes = controladora.ListarClientes();
        }

        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);
            controladora.BajaCliente(Id);
            return Redirect("./Lista");
        }
    }
}

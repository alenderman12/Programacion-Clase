using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;
using Prueba_AspNet.Pages.PageCliente;

namespace Prueba_AspNet.Pages.PageCliente
{
    public class DetalleModel : PageModel
    {
        public Dominio.Cliente cliente { get; set; }

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            cliente = unaControladora.BuscarCliente(id);
        }
    }
}
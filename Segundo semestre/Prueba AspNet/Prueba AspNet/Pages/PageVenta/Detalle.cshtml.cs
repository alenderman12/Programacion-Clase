using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageVenta
{
    public class DetalleModel : PageModel
    {
        public Dominio.Venta venta { get; set; }

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            venta = unaControladora.BuscarVenta(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageVenta
{
    public class ListaModel : PageModel
    {
        public List<Venta> ventas = new List<Venta>();
        Controladora controladora = new Controladora();
        public void OnGet()
        {
            ventas = controladora.ListarVentas();
        }

        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);
            controladora.BajaVenta(Id);
            return Redirect("./Lista");
        }
    }
}

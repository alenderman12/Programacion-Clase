using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageArticulo
{
    public class BajaModel : PageModel
    {
        public Articulo articulo { get; set; }
        Controladora controladora = new Controladora();
        public void OnGet(int id)
        {
            articulo = controladora.BuscarArticulo(id);
        }
        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);
            controladora.BuscarArticulo(Id);
            return Redirect("./Lista");
        }
    }
}

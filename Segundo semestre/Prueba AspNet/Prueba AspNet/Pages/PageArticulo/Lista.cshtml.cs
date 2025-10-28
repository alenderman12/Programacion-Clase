using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageArticulo
{
    public class ListaModel : PageModel
    {
        public List<Articulo> articulos = new List<Articulo>();
        Controladora controladora = new Controladora();
        public void OnGet()
        {
            articulos = controladora.ListarArticulos();
        }

        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);
            controladora.BajaArticulo(Id);
            return Redirect("./Lista");
        }
    }
}

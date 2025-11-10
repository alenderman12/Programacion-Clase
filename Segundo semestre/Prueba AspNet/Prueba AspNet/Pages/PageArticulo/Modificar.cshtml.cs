using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageArticulo
{
    public class ModificarModel : PageModel
    {
        public Articulo articulo { get; set; }
        public void OnGet(int id)
        {
            Controladora controladora = new Controladora();
            articulo = controladora.BuscarArticulo(id);
        }

        public IActionResult OnPostModificar()
        {
            int Id = int.Parse(Request.Form["id"]);
            string Nombre = Request.Form["nombre"];
            string Rubro = Request.Form["rubro"];
            float Precio = float.Parse(Request.Form["precio"]);
            int Stock = int.Parse(Request.Form["stock"]);

            Controladora controladora = new Controladora();
            controladora.ModificarArticulo(Id, Nombre, Rubro, Precio,Stock);

            return RedirectToPage("/PageArticulo/Lista");
        }
    }
}

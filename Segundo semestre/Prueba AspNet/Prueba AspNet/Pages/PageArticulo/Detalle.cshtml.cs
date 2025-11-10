using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageArticulo
{
    public class DetalleModel : PageModel
    {
        public Dominio.Articulo articulo { get; set; }

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            articulo = unaControladora.BuscarArticulo(id);
        }
    }
}

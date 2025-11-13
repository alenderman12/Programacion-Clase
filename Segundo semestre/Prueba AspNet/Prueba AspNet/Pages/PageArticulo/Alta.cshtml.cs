using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageArticulo
{
    public class AgregarModel : PageModel
    {
        public string Mensaje { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un ID");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID debe ser numerico");
                }
                if (Request.Form["nombre"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Nombre");
                }
                if (Request.Form["rubro"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Rubro");
                }
                if (Request.Form["precio"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Precio");
                }
                if (!double.TryParse(Request.Form["precio"], out _))
                {
                    throw new Exception("El Precio debe ser numerico");
                }
                if (Request.Form["stock"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Stock");
                }
                if (!int.TryParse(Request.Form["stock"], out _))
                {
                    throw new Exception("El Stock debe ser numerico");
                }
                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                string Rubro = Request.Form["rubro"];
                double Precio = double.Parse(Request.Form["precio"]);
                int Stock = int.Parse(Request.Form["stock"]);

                Articulo articulo = new Articulo(Id, Nombre, Rubro, Precio, Stock);

                Controladora controladora = new Controladora();
                if (controladora.AltaArticulo(articulo))
                {
                    return Redirect("/PageArticulo/Lista");
                }
                throw new Exception("Ocurrio un error desconocido al agregar el articulo");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            return Page();
        }
    }
}

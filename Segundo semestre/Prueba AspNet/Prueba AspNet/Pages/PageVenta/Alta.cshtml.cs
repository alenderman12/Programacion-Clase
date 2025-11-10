using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageVenta
{
    public class AgregarModel : PageModel
    {
        public string Mensaje { get; set; }
        Controladora controladora = new Controladora();
        public List<Articulo> articulos { get; set; }
        public List<Cliente> clientes { get; set; }

        public void OnGet()
        {

            clientes = controladora.ListarClientes() ?? new List<Cliente>();
            articulos = controladora.ListarArticulos() ?? new List<Articulo>();
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
                if (DateTime.TryParse(Request.Form["fecha"], out _))
                {
                    throw new Exception("Debe ingresar una fecha valida");
                }
                if (Request.Form["idCliente"] == 0)
                {
                    throw new Exception("Debe ingresar un Cliente");
                }
                if (Request.Form["idArticulo"] == 0)
                {
                    throw new Exception("Debe ingresar un Articulo");
                }
                if (Request.Form["importe"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un importe");
                }
                int Id = int.Parse(Request.Form["id"]);
                DateTime Fecha = DateTime.Parse(Request.Form["fecha"]);
                Cliente Cliente = controladora.BuscarCliente(int.Parse(Request.Form["idCliente"]));
                Articulo Articulo = controladora.BuscarArticulo(int.Parse(Request.Form["idArticulo"]));
                int Importe = int.Parse(Request.Form["importe"]);

                Venta venta = new Venta(Id, Fecha, Cliente, Articulo, Importe);

                controladora.AltaVenta(venta);

                return RedirectToPage("/PageCliente/Lista");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            return Page();
        }
    }
}

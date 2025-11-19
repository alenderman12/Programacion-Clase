using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;
using Prueba_AspNet.Persistencia;

namespace Prueba_AspNet.Pages.PageReportes
{
    public class VentasXArticuloModel : PageModel
    {
        public List<Venta> VentasXArt { get; set; }
        public List<Articulo> articulos { get; set; }
        public string Mensaje { get; set; } = "";
        public double Total { get; set; } = 0;
        Controladora controladora = new Controladora();
        public void OnGet()
        {
            articulos = controladora.ListarArticulos();
        }
        public void OnPostBuscar()
        {
            try
            {
                if (Request.Form["idArticulo"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un Articulo");
                }
                int idCliente = int.Parse(Request.Form["idArticulo"]);
                VentasXArt = controladora.VentasXArticulo(idCliente);
                Total = CalculoTotal();
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            articulos = controladora.ListarArticulos();
        }
        public double CalculoTotal()
        {
            double suma = 0;
            foreach (var ven in VentasXArt)
            {
                suma += ven.Importe;
            }
            return suma;
        }
    }
}

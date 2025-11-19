using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_AspNet.Dominio;

namespace Prueba_AspNet.Pages.PageReportes
{
    public class VentasXClienteModel : PageModel
    {
        public List<Venta> VentasXCli { get; set; }
        public List<Cliente> clientes { get; set; }
        public string Mensaje { get; set; } = "";
        Controladora controladora = new Controladora();
        public void OnGet()
        {
            clientes = controladora.ListarClientes();
        }
        public void OnPostBuscar()
        {
            try
            {
                if (Request.Form["idCliente"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un Cliente");
                }
                int idCliente = int.Parse(Request.Form["idCliente"]);
                VentasXCli = controladora.VentasXCliente(idCliente);
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            clientes = controladora.ListarClientes();
        }
    }
}

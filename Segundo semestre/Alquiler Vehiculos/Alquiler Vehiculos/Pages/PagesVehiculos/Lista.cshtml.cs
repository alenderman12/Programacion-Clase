using Alquiler_Vehiculos.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alquiler_Vehiculos.Pages.PagesVehiculos
{
    public class ListaModel : PageModel
    {
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        Controladora controladora = new Controladora();
        public void OnGet()
        {
            vehiculos = controladora.ListarVehiculos();
        }

        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);
            controladora.BajaCliente(Id);
            return Redirect("./Lista");
        }
    }
}

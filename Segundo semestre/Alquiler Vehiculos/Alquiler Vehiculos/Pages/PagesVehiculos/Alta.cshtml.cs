using Alquiler_Vehiculos.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alquiler_Vehiculos.Pages.PagesVehiculos
{
    public class AltaModel : PageModel
    {
        public int Id { get; set; } = 1;
        public string Mensaje { get; set; }
        Controladora controladora = new Controladora();
        public void OnGet()
        {
            Mensaje = "asdasdad";
        }

        public IActionResult OnPostAgregar()
        {
            string matricula = Request.Form["matricula"];
            string marca = Request.Form["marca"];
            string modelo = Request.Form["modelo"];
            int anio = int.Parse(Request.Form["anio"]);
            string tipo = Request.Form["tipo"];
            int capacidad = int.Parse(Request.Form["capacidad"]);
            string combustible = Request.Form["combustible"];
            string color = Request.Form["color"];
            double precioPorDia = double.Parse(Request.Form["precio"]);
            char estado = 'D';
            string imagenLink = Request.Form["imagenLink"];
            Vehiculo nuevoVehiculo = new Vehiculo(Id, matricula, marca, modelo, anio, tipo, capacidad, combustible, color, precioPorDia, estado, imagenLink);
            controladora.AltaVehiculo(nuevoVehiculo);
            return Redirect("./Lista");
        }
    }
}

using System.Collections.Generic;
using System.Web.Mvc;
using Ejemplo.MVC._2.Dominio;
using Ejemplo.MVC._2.Dominio.Entidades;

namespace Ejemplo.MVC._2.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            var retenciones = new List<IAporte> { new AporteJubilacion(), new AporteObraSocial() };

            var calculadorSueldo = new CalcularSalarioNeto(retenciones, new ImpuestoGanancias());

            var empleado = new Programador("Pedro", "Perez", 150, 160);

            var r = calculadorSueldo.Calcular(empleado);

            return View();
        }
    }
}
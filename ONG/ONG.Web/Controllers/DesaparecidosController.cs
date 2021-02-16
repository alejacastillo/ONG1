using ONG.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONG.Web.Controllers
{
    public class DesaparecidosController : Controller
    {
        // GET: Desaparecidos
        public ActionResult Index()
        {
            var desaparecidoBL = new DesaparecidosBL();
            var listaDesaparecidos = desaparecidoBL.ObtenerDesaparecidos();




            return View(listaDesaparecidos);
        }
    }
}
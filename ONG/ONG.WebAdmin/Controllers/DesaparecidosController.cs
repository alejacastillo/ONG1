using ONG.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONG.WebAdmin.Controllers
{
    public class DesaparecidosController : Controller
    {

        DesaparecidosBL _desaparecidosBL;

        public DesaparecidosController()
        {
            _desaparecidosBL = new DesaparecidosBL();
        }

        // GET: Personas
        public ActionResult Index()
        {
            var listadeDesaparecidos = _desaparecidosBL.ObtenerDesaparecidos();
            return View(listadeDesaparecidos);
        }

    
        public ActionResult Crear()
        {

            var nuevoDesaparecido = new Desaparecidos();

            return View(nuevoDesaparecido);
        }


        [HttpPost]

        public ActionResult Crear(Desaparecidos Desaparecidos)
        {
            _desaparecidosBL.GuardarDesaparecido(Desaparecidos);

            return RedirectToAction("Index");
        }


        public ActionResult Editar( int id)
        {
            var Desaparecidos = _desaparecidosBL.ObtenerDesaparecidos(id);

            return View(Desaparecidos);
        }

        [HttpPost]
        public ActionResult Editar(Desaparecidos Desaparecidos)
        {
            _desaparecidosBL.GuardarDesaparecido(Desaparecidos);

            return RedirectToAction("Index");
        }

        public  ActionResult Detalle(int id)
        {
            var Desaparecidos = _desaparecidosBL.ObtenerDesaparecidos(id);
            return View(Desaparecidos);
        }

        public ActionResult Eliminar(int id)
        {
            var Desaparecidos = _desaparecidosBL.ObtenerDesaparecidos(id);

            return View(Desaparecidos);

        }

        [HttpPost]
        public ActionResult  Eliminar(Desaparecidos Desaparecidos)
        {
            _desaparecidosBL.EliminarDesaparecido(Desaparecidos.Id);
            return RedirectToAction("Index");
        }
    }
}
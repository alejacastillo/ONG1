using ONG.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONG.WebAdmin.Controllers
{
    public class CategoriaController : Controller
    {
        CategoriasBL _CategoriasBL;

        public CategoriaController()
        {
            _CategoriasBL = new CategoriasBL();
        }


    // GET: Categoria
    public ActionResult Index()
    {
        var listadeCategorias = _CategoriasBL.ObtenerCategorias();
        return View(listadeCategorias);
    }


    public ActionResult Crear()
    {

        var nuevaCategoria = new Categorias();

        return View(nuevaCategoria);
    }

    [HttpPost]

    public ActionResult Crear(Categorias Categorias)
    {
        _CategoriasBL.GuardarCategoria(Categorias);

        return RedirectToAction("Index");
    }


    public ActionResult Editar(int id)
    {
        var Categorias = _CategoriasBL.ObtenerCategorias(id);

        return View(Categorias);
    }

    [HttpPost]
    public ActionResult Editar(Categorias Categorias)
    {
        _CategoriasBL.GuardarCategoria(Categorias);

        return RedirectToAction("Index");
    }
        
    public ActionResult Detalle(int id)
    {
        var Categorias = _CategoriasBL.ObtenerCategorias(id);
        return View(Categorias);
    }




    public ActionResult Eliminar(int id)
    {
        var Categorias = _CategoriasBL.ObtenerCategorias(id);

        return View(Categorias);

    }
        
    [HttpPost]
    public ActionResult Eliminar(Categorias Categorias)
    {
        _CategoriasBL.EliminarCategoria(Categorias.Id);
        return RedirectToAction("Index");
    }


}
}
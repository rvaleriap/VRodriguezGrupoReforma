using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ML.Personas personas)
        {

            ML.Result result = BL.Personas.Add(personas);
            if (result.Correct)
            {

                ViewBag.Message = "Se registro exitosamente";
            }
            else
            {
                ViewBag.Message = "No se registro ";
            }
            return View("Modal");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class PersonasController : Controller
    {
        [HttpGet]
        public ActionResult Form()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Form(ML.Personas personas)
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
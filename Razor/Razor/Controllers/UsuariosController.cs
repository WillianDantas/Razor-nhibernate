using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuario
        public ActionResult Form()
        {
            return View("Form");
        }
    }
}
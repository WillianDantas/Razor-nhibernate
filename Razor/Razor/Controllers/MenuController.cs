using Razor.DAO;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            DepartamentosDAO departamentosDAO = new DepartamentosDAO();
            ViewBag.Departamentos = departamentosDAO.Lista();

            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;
using Razor.DAO;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ProtudosDAO produtosDAO = new ProtudosDAO();
            ViewBag.Produtos = produtosDAO.Ofertas();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }

    }
}
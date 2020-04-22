using DAL.Infra;
using NHibernate;
using Razor.DAO;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class AutenticacaoController : Controller
    {
        private ISession session;
        private UsuariosDAO usuarioDao;

        public AutenticacaoController()
        {
            session = NHibernateHelper.OpenSession();
            usuarioDao = new UsuariosDAO(session);
        }
        // GET: Autenticacao
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(string email, string senha)
        {
           
            Usuario usuarioLogado = usuarioDao.Login(email, senha);
            if (usuarioLogado != null)
            {
                Session["usuarioLogado"] = usuarioLogado.Nome;
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
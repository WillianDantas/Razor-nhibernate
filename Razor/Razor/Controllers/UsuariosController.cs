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
    public class UsuariosController : Controller
    {
         private ISession session;
         private UsuariosDAO usuarioDao;

         public UsuariosController()
        {
            session = NHibernateHelper.OpenSession();
            usuarioDao = new UsuariosDAO(session);
        }

        // GET: Usuario
        public ActionResult Form(string email)
        {
            Usuario u = new Usuario()
            {
                Email = email
            };
            return View(u);
        }

        [HttpPost]
        public ActionResult BuscarUsuario(string email, string senha)
        {
            var usuario = usuarioDao.Login(email, senha);

            return View("Home", usuario);
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                usuarioDao.Adiciona(usuario);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Form", usuario);
            }
        }
    }
}
﻿using Razor.Models;
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
            ViewBag.Departamentos = ListaDepartamento();
            return View();
        }


        public List<Departamento> ListaDepartamento()
        {
            List<Categoria> vaListaCategoria = new List<Categoria>();
            List<Departamento> vaListaDepartamento = new List<Departamento>();
            Categoria categoria = new Categoria();
            categoria.Nome = "TV";
            vaListaCategoria.Add(categoria);
            categoria = new Categoria();
            categoria.Nome = "NoteBook";
            vaListaCategoria.Add(categoria);
            Departamento departamento = new Departamento();
            departamento.Nome = "Eletronico";
            departamento.Categorias = vaListaCategoria;
            vaListaDepartamento.Add(departamento);
            return vaListaDepartamento;
        }
    }
}
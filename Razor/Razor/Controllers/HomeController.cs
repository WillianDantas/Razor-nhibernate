using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            ViewBag.Departamentos = ListaDepartamento();
            ViewBag.Produtos = ListaProduto();
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


        public List<Produto> ListaProduto()
        {
            List<Produto> vaListaProduto = new List<Produto>();
            Produto vaProduto = new Produto();
            vaProduto.Nome = "Monitor C123";
            vaProduto.Descricao = "Monitor mais barato do mundo";
            vaProduto.Preco = 200.00;
            vaListaProduto.Add(vaProduto);
            vaProduto = new Produto();
            vaProduto.Nome = "Monitor C987";
            vaProduto.Descricao = "Monitor mais barato do mundo";
            vaProduto.Preco = 200.00;
            vaListaProduto.Add(vaProduto);
            vaProduto = new Produto();
            vaProduto.Nome = "HD 500 TB";
            vaProduto.Descricao = "Monitor mais barato do mundo";
            vaProduto.Preco = 200.00;
            vaListaProduto.Add(vaProduto);

            return vaListaProduto;
        }
    }
}
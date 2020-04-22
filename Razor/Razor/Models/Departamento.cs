using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razor.Models
{
    public class Departamento
    {
        public string Nome { get; set; }
        public List<Categoria> Categorias { get; set; } = new List<Categoria>();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Razor.Models
{
    public class Usuario
    {
        public virtual int Id { get; set; }

        [Required]
        public virtual String Nome { get; set; }

        [Required, EmailAddress]
        public virtual String Email { get; set; }

        [Required, MinLength(100)]
        public virtual String Senha { get; set; }
        /*
        public Sexo Sexo { get; set; }

        public Estado Estado { get; set; }

        

        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        public String Endereco { get; set; }

        public String Complemento { get; set; }

        [Required, RegularExpression("\\d{5}-\\d{3}")]
        public String CEP { get; set; }

        public string Observacoes { get; set; }

        public bool RecebePromocoes { get; set; }
        */
    }
}
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
        
        public virtual String Sexo { get; set; }

        public virtual String Estado { get; set; }

        [Required]
        public virtual DateTime DataNascimento { get; set; }

        [Required]
        public virtual String Endereco { get; set; }

        public virtual String Complemento { get; set; }

        [Required, RegularExpression("\\d{5}-\\d{3}")]
        public virtual  String Cep { get; set; }
  
    }
}
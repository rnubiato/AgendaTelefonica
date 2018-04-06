using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AgendaTelefonica.Models
{
    public enum TipoEmail
    {
        Casa, Trabalho, Celular, Outros
    }
    public class Email
    {
        [Key]
        [DisplayName("ID")]
        public int IDEmail { get; set; }
        [DisplayName("Contato")]
        public int IDContato { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatório.")]
        [DisplayName("E-mail")]
        public string Mail { get; set; }
        [DisplayName("Tipo")]
        public TipoEmail? TipoEmail { get; set; }

        public virtual Contato Contato { get; set; }
    }
}
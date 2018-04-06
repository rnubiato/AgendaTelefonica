using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgendaTelefonica.Models
{
    public enum TipoTelefone
    {
        Casa, Trabalho, Celular, Outros
    }
    public class Telefone
    {
        [Key]
        [DisplayName("ID")]
        public int IDTelefone { get; set; }
        [DisplayName("Contato")]
        public int IDContato { get; set; }
        [Required(ErrorMessage = "Numero é obrigatório.")]
        [DisplayName("Número")]
        public string Numero { get; set; }
        [DisplayName("Tipo")]
        public TipoTelefone? TipoTelefone { get; set; }

        public virtual Contato Contato { get; set; }
    }
}
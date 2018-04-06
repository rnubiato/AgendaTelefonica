using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaTelefonica.Models
{
    public class Contato
    {
        [Key]
        [DisplayName("ID")]
        public int IDContato { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string Empresa { get; set; }

        public virtual List<Telefone> Telefones { get; set; }
        public virtual List<Email> Emails { get; set; }
    }
}
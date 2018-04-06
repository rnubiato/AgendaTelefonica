using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AgendaTelefonica.Models
{
    public class InitDb : DropCreateDatabaseAlways<BancoContext>
    {
        protected override void Seed(BancoContext context)
        {
            new List<Contato>
            {
                new Contato
                {
                    Nome = "Regiane Nubiato Cordeiro",
                    Empresa = "MTTEchne",
                    Endereco = "Dona Avelina 77 - São Paulo",
                    Telefones = new List<Telefone>
                    {
                       new Telefone
                       {
                           Numero = "(11)99633-5705",
                           TipoTelefone = TipoTelefone.Casa,
                       },
                    },
                    Emails = new List<Email>
                    {
                        new Email
                        {
                            Mail = "r.nubiato@gmail.com",
                            TipoEmail = TipoEmail.Casa,
                        }
                    }
                },
                new Contato
                {
                    Nome = "Rodrigo Cordeiro",
                    Empresa = "Ticket",
                    Endereco = "Dona Avelina 77 - São Paulo",
                    Telefones = new List<Telefone>
                    {
                       new Telefone
                       {
                           Numero = "(11)97464-3346",
                           TipoTelefone = TipoTelefone.Casa,
                       },
                    },
                    Emails = new List<Email>
                    {
                        new Email
                        {
                            Mail = "rigocordeiro@gmail.com",
                            TipoEmail = TipoEmail.Casa,
                        }
                    }
                },
            }.ForEach(c => context.Contatoes.Add(c));
            base.Seed(context);
        }
    }
}
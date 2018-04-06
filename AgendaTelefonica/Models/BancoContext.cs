using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendaTelefonica.Models
{
    public class BancoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BancoContext() : base("name=BancoContext") {}

        public DbSet<Contato> Contatoes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Email> Emails { get; set; }
    }
}

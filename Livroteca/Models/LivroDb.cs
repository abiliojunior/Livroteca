using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Livroteca.Models
{
    public class LivroDb:DbContext
    {
        public DbSet<Livro> Livros { get; set; }

    }
}
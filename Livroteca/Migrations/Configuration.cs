namespace Livroteca.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Livroteca.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Livroteca.Models.LivroDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Livroteca.Models.LivroDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Livros.AddOrUpdate(
                  p => p.Titulo,
                  new Livro { Titulo="O Senhor dos Aneis", AnoLancamento=1985, NumeroDePaginas=250},
                  new Livro { Titulo = "O Hobbit", AnoLancamento = 1980, NumeroDePaginas = 357 },
                  new Livro { Titulo = "Os Filhos de Hurim", AnoLancamento = 2010, NumeroDePaginas = 456 },
                  new Livro { Titulo = "O Silmarill", AnoLancamento = 1995, NumeroDePaginas = 520 },
                  new Livro { Titulo = "Contos Inacabandos", AnoLancamento = 1990, NumeroDePaginas = 658 }
               );
            //
        }
    }
}

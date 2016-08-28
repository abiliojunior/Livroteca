using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livroteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public int NumeroDePaginas { get; set; }

    }
}
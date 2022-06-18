using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO.Partial {
    internal partial class Pessoa {
        private DateTime idade;
        private readonly DateTime dataAtual = DateTime.Now;
        private DateTime dataDeNascimento = new(day: 31, month: 03, year: 1998);
    }
}

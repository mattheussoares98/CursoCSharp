using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO.Partial {
    internal partial class Pessoa {
        public void ObterIdadeExata() {

            idade = dataAtual.AddDays(-dataDeNascimento.Day);
            idade = dataAtual.AddMonths(-dataDeNascimento.Month);
            idade = dataAtual.AddYears(-dataDeNascimento.Year);

            Console.WriteLine($"Anos: {idade.Year} \nMeses: {idade.Month} \nDias: {idade.Day}");
        }
    }
}

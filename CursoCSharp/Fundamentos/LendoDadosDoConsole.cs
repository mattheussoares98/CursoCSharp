using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDadosDoConsole {
        static public void Executar() {
            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"O {nome} possui {idade} anos");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {

        public static void Executar() {
            string nome = "Mattheus Soares Barbosa";
            double idade = 24;
            string nacionalidade = "Brasileira";

            Console.WriteLine("Há 3 formas de interpolar. Veja o código para ver as formas!");
            Console.WriteLine("O " + nome + " possui " + idade + " anos e a nacionalidade " + nacionalidade);
            Console.WriteLine("O {0} possui {1} anos e a nacionalidade {2}", //primeiro coloca os índices
                //depois coloca o que será atribuído a esses índices
                nome, idade, nacionalidade);
            Console.WriteLine($"O {nome} possui {idade} anos e a nacionalidade {nacionalidade}");

        }
    }
}

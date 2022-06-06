using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Igualdade {
        public static void Executar() {
            Produto produto1 = new(nome: "Mattheus", preco: 10);
            Produto produto2 = new(nome: "Mattheus", preco: 10);

            Console.WriteLine(produto1 == produto2); //como ocupam locais diferentes da memória,
                                                     //retorna false
            Console.WriteLine(produto1.Equals(produto2));//faz a mesma coisa que a linha acima
            Console.WriteLine(produto1.Nome == produto2.Nome && produto1.Preco == produto2.Preco);

            var produto3 = produto2;
            Console.WriteLine(produto3 == produto2); //como ocupam o mesmo local da memória,
                                                     //retorna true
        }
    }
}

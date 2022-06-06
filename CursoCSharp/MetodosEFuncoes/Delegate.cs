using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class Delegate {
        //pode colocar o delegate tanto dentro quanto fora da classe
        delegate double Operacao(double x, double y);
        //também pode passar como parâmetro para uma função

        //define um tipo que armazena a assinatura de uma função e essa assinatura uma vez sendo
        //respeitada, consegue criar uma variável do tipo delegate e criar uma função que respeita
        //a mesma assinatura
        public static void Executar() {
            Operacao multiplicacao = (x, y) => x * y;
            Operacao soma = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;

            Console.WriteLine(multiplicacao(10, 10));
            Console.WriteLine(soma(10, 10));
            Console.WriteLine(subtracao(10, 10));

        }

    }
}

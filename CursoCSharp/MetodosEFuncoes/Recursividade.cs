using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class Recursividade {
        //recursividade é quando no corpo da função, chama a própria função que está sendo declarada, conforme a seguir que calcula o fatorial de determinado número
        static int Fatorial(int num) {
            if(num <= 0) {
                return 1;
            }
            return num * Fatorial(num - 1);
        }
        public static void Executar() {
            Console.Write("Digite o número que deseja calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"O fatorial de {num} é: " + Fatorial(num));
        }
    }
}

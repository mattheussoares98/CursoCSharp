using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    interface OperacaoBinariaInterface {
        //de padrão, todos métodos de um interface são públicos
        //não é possível implementar o corpo do método
        int Operacao(int a, int b);
    }

    interface TesteInterface {
    }

    abstract class AbstractTeste {
    }

    class Multiplicacao: AbstractTeste, OperacaoBinariaInterface, TesteInterface { //é possível implementar somente uma classe abstrata e quantas interfaces quiser
        public int Operacao(int a, int b) {
            return a * b;
        }
    }
    class Soma: AbstractTeste, OperacaoBinariaInterface, TesteInterface { //é possível implementar somente uma classe abstrata e quantas interfaces quiser
        public int Operacao(int a, int b) {
            return a + b;
        }
    }
    class Subtracao: AbstractTeste, OperacaoBinariaInterface, TesteInterface { //é possível implementar somente uma classe abstrata e quantas interfaces quiser
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    internal class Calculadora {
       private readonly List<OperacaoBinariaInterface> operacaoBinaria = new() {
            new Soma(),
            new Multiplicacao(),
            new Subtracao(),
        };

        public void ExecutarOperacoes(int a, int b) {
            Console.WriteLine($"Valores: {a}, {b}");
            foreach(var op in operacaoBinaria) {
                int value = op.Operacao(a, b);
                Console.WriteLine(op.GetType().Name);
                //Console.WriteLine(op);
                Console.WriteLine(value);
            }
        }
    }
    internal class Interface {
        public static void Executar() {
            Calculadora calculadora = new();
            calculadora.ExecutarOperacoes(10, 10);
        }
    }
}

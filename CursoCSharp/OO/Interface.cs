using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    interface IOperacaoBinaria {
        //Todos os métodos de interface precisam ser públicos
        //não é possível implementar o corpo do método
        int Operacao(int a, int b);
    }

    interface ITeste {
    }

    abstract class AbstractTeste {
    }

    class Multiplicacao: AbstractTeste, IOperacaoBinaria, ITeste {
        //é possível implementar somente uma classe abstrata e quantas interfaces quiser
        public int Operacao(int a, int b) {
            return a * b;
        }
    }
    class Soma: AbstractTeste, IOperacaoBinaria, ITeste {
        //é possível implementar somente uma classe abstrata e quantas interfaces quiser
        public int Operacao(int a, int b) {
            return a + b;
        }
    }
    class Subtracao: AbstractTeste, IOperacaoBinaria, ITeste {
        //é possível implementar somente uma classe abstrata e quantas interfaces quiser
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    internal class Calculadora {
        private readonly List<IOperacaoBinaria> operacaoBinaria = new() {
            new Soma(),
            new Multiplicacao(),
            new Subtracao(),
        };

        public void ExecutarOperacoes(int a, int b) {
            Console.WriteLine($"Valores: {a}, {b}");
            foreach(var op in operacaoBinaria) {
                int value = op.Operacao(a, b);
                Console.WriteLine(op.GetType().Name);
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

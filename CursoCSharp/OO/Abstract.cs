using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public abstract class Implementar {
        public abstract int Incrementar();//quando o método não possui corpo, precisa defini-lo como abstract
        public static int Decrementar(int valor) => --valor;//método com corpo
        //só deu certo porque adicionei o -- antes da variável, pois demonstra que tem precedência antes de retornar seu valor na função. Se colocar depois, vai mostrar o valor incorreto na impressão

        public int valorInicial = 0;//variável com valor definido

        public int Somar(int valor) => valorInicial += valor;//como o método possui corpo e não está marcado como abstract, não precisa implementá-lo

    }


    internal class Incrementando: Implementar {
        public void Teste() {
            //só é possível acessar os valores da classe abstrata caso esteja dentro de uma função
            Console.WriteLine(valorInicial);
        }
        public int Decrementar() => valorInicial;
        public override int Incrementar() => ++valorInicial; //só deu certo porque adicionei o ++ antes da variável, pois demonstra que tem precedência antes de retornar seu valorInicial na função. Se colocar depois, vai mostrar o valorInicial incorreto na impressão
    }

    internal class Abstract {
        //Incrementar implementar = new Implementar();//não é possível instanciar classes abstratas

        public static void Executar() {
            Incrementando incrementando = new();
            Console.WriteLine("Valor inicial: " + incrementando.valorInicial);
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Incrementar());
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Incrementar());
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Incrementar());

            Console.WriteLine("\nDepois de decrementar 1 número: " + incrementando.Decrementar());
            Console.WriteLine("Depois de decrementar 1 número: " + incrementando.Decrementar());
            Console.WriteLine("Depois de decrementar 1 número: " + incrementando.Decrementar());
            Console.WriteLine("Valor final: " + incrementando.valorInicial);


            Console.WriteLine("Valor final: " + incrementando.Somar(10));
        }
    }
}

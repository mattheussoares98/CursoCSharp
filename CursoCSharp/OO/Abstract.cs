using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public abstract class Implementar {
        public static double valorInicial = 0;//variável com valor definido
        public abstract double Operacao(double valor);
        //só é possível definir como abstract quando o método não possui corpo
        public static double Decrementar(double valorASubtrair) => valorInicial -= valorASubtrair;
        //Quando o método possui corpo:
        //1- Não é possível definí-lo como abstract.
        //2- Não precisa implementá-lo na classe que o herda.
        //3- É possível criar um novo método com o mesmo nome que esse para sobrescrever esse.
        //4- O Visual Studio orienta a deixar o método como static.
        public virtual double Somar(double valor) => valorInicial += valor;
        //Quando o método é marcado como virtual:
        //1- Não é possível definí-lo como abstract.
        //2- Não precisa implementá-lo na classe que o herda.
        //3- É possível criar um novo método com o mesmo nome que esse para sobrescrever esse. Para sobrescrever, precisa usar o override ou o new
        //4- Não é possível deixá-lo como static
    }


    internal class Incrementando: Implementar {
        public static void Teste() {
            //só é possível acessar os valores da classe abstrata caso esteja dentro de uma função
            Console.WriteLine(valorInicial);
        }
        //public new static int Decrementar() => valorInicial;
        public override double Operacao(double valor) => valorInicial += valor; //só deu certo porque adicionei o ++ antes da variável, pois demonstra que tem precedência antes de retornar seu valorInicial na função. Se colocar depois, vai mostrar o valorInicial incorreto na impressão


        //public new static double Somar(double valor) => valorInicial += valor; //tanto essa linha quanto a de baixo funcionam
        public override double Somar(double valor) => valorInicial += valor;
    }

    internal class Abstract {
        //Operacao implementar = new Implementar();//não é possível instanciar classes abstratas

        public static void Executar() {
            Incrementando incrementando = new();
            //Implementar.Decrementar(10);
            Console.WriteLine("Valor inicial: " + Implementar.valorInicial);
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Operacao(1));
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Operacao(1));
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Operacao(1));

            Console.WriteLine("\nDepois de decrementar 1 número: " + Implementar.Decrementar(1));
            Console.WriteLine("Depois de decrementar 1 número: " + Implementar.Decrementar(1));
            Console.WriteLine("Depois de decrementar 1 número: " + Implementar.Decrementar(1));
            Console.WriteLine("Valor final: " + Implementar.valorInicial);


            Console.WriteLine("Valor final após somar 10: " + incrementando.Somar(10));
        }
    }
}

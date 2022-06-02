using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public abstract class Implementar {
        public abstract int Incrementar();
        public static int Decrementar(int valor) => valor--;
    }


    internal class Incrementando: Implementar {
        public int valor = 0;
        public int Decrementar() => --valor; //só deu certo porque adicionei o -- antes da variável, pois demonstra que tem precedência entre. Se colocar depois, vai mostrar o valor incorreto na impressão
        public override int Incrementar() => ++valor; //só deu certo porque adicionei o ++ antes da variável, pois demonstra que tem precedência entre. Se colocar depois, vai mostrar o valor incorreto na impressão
    }

    internal class Abstract {
        //Incrementar implementar = new Implementar();//não é possível instanciar classes abstratas

        public static void Executar() {
            Incrementando incrementando = new();
            Console.WriteLine("Valor inicial: " + incrementando.valor);
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Incrementar());
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Incrementar());
            Console.WriteLine("Depois de incrementar 1 número: " + incrementando.Incrementar());
            Console.WriteLine();
            Console.WriteLine("Depois de decrementar 1 número: " + incrementando.Decrementar());
            Console.WriteLine("Depois de decrementar 1 número: " + incrementando.Decrementar());
            Console.WriteLine("Depois de decrementar 1 número: " + incrementando.Decrementar());
            Console.WriteLine("Valor final: " + incrementando.valor);
        }
    }
}

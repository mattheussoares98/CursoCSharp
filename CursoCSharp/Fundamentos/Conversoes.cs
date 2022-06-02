using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double truncado = inteiro;
            Console.WriteLine("Conversão implicita: {0}", truncado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Conversão explícita: {0}", notaTruncada);

            Console.Write("Digite a sua idade: ");
            string idadeDigitada = Console.ReadLine();
            int idade = int.Parse(idadeDigitada);
            Console.WriteLine("Idade digitada: {0}", idade);

            Convert.ToInt32(idadeDigitada);
            Console.WriteLine("idade digitada convertida pra inteiro: {0}", idadeDigitada);

            Console.Write("Digite o primeiro número: ");
            string primeiraPalavra = Console.ReadLine();
            int primeiroNumeroConvertido;
            int.TryParse(primeiraPalavra, out primeiroNumeroConvertido);
            //esse out serve para "jogar" o valor de uma variável dentro de outra variável
            Console.WriteLine("Primeiro número convertido: {0}", primeiroNumeroConvertido);

            Console.Write ("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numeroConvertido );
            //é possível declarar a variável no próprio tryParse. Caso o usuário digite algo diferente de um int, vai imprimir a seguir o valor padrão de um int, que no caso é o número 0
            Console.WriteLine("Segundo número convertido: {0}", numeroConvertido);
        }
    }
}

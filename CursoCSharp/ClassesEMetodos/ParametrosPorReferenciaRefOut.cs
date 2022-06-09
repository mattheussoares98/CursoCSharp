using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosPorReferenciaRefOut {
        public static void AlterarNumero(int numero) {
            numero = numero + 100;
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero += 100;
        }

        public static void AlterarRef(ref int numero) {
            //Um ref faz uma referência para o mesmo espaço da memória, por isso não é muito aconselhável usar
            numero += 100;
        }
        public static void Executar() {
            int a = 0;
            AlterarNumero(a);//não altera o valor porque está fazendo uma cópia na função e somando 100 à cópia
            Console.WriteLine($"int a = {a}");

            AlterarOut(out int b);
            Console.WriteLine($"out b = {b}");

            int c = 0;
            AlterarRef(ref c);
            Console.WriteLine($"ref c = {c}");

        }
    }
}

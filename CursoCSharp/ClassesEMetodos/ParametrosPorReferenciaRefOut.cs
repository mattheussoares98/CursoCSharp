using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosPorReferenciaRefOut {
        public static void alterarNumero(int numero) {
            numero = numero + 100;
        }

        public static void alterarOut(out int numero) {
            numero = 0;
            numero = numero + 100;
        }

        public static void alterarRef(ref int numero) {//o ideal é não usar o ref, pois pode causar mais bugs no app. O ideal é usar o out
            numero = numero + 100;
        }
        public static void Executar() {
            int a = 0;
            alterarNumero(a);//não altera o valor porque está fazendo uma cópia na função e somando 100 à cópia
            Console.WriteLine($"int a = {a}");

            alterarOut(out int b);
            Console.WriteLine($"out b = {b}");

            int c = 0;
            alterarRef(ref c);
            Console.WriteLine($"ref c = {c}");

        }
    }
}

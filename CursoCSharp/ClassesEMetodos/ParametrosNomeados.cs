using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosNomeados {

        static void Data(int dia, int mes, int ano) {
            Console.WriteLine($"{dia}/{mes}/{ano}");
                }
        public static void Executar() {
            Data(dia: 31,mes: 3,ano: 1998);
        }
    }
}

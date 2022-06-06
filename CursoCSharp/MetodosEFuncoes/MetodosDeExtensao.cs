using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    public static class Extensao {
        //o que define a extensão é colocar o this no primeiro parâmetro da função
        //nesse caso abaixo, sempre que utilizar um "." após um double, é possível
        //chamar essa função abaixo
        public static double Soma(this double numero, double outroNumero) {
            return numero + outroNumero;
        }
        public static string Concatenar(this string palavra, string outraPalavra) {
            return palavra + " " + outraPalavra;
        }
    }
    internal class MetodosDeExtensao {

        public static void Executar() {
            Console.WriteLine(2.3.Soma(2.1));
            Console.WriteLine("".Concatenar("Pode digitar qualquer coisa"));
        }
    }
}

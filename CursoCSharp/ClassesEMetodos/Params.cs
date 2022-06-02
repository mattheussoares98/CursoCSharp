using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Params {

        //colocando os parâmetros do método conforme a seguir, quando chamar esse método, é possível passar quantos dados quiser
        static void Recepcionar(params string[] pessoas) {
            foreach(var pessoa in pessoas) {
                Console.WriteLine(pessoa);
            }
        }

        public static void Executar() {
            Recepcionar("Mattheus", "Soares", "Barbosa");
        }
    }
}

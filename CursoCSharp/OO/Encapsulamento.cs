using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO {

    public class FilhoDistante : Atributos {
        public new void MeusAcessos() {
            Console.WriteLine("CorDoOlho: "+ CorDoOlho);
            Console.WriteLine("JeitoDeFalar: "+ JeitoDeFalar);
            Console.WriteLine("InfoPublica: "+ InfoPublica);
        }
    }

    public class AmigoDistante {
        public readonly Atributos amigoDistante = new();

        public void MeusAcessos() {
            Console.WriteLine("InfoPublica: " + amigoDistante.InfoPublica);
        }
    }
    internal class Encapsulamento {

        public static void Executar() {
            Console.WriteLine("############ SubCelebridade ############");
            Console.WriteLine("");

            new Atributos().MeusAcessos();

            Console.WriteLine("");
            Console.WriteLine("############ Filho reconhecido ############");
            Console.WriteLine("");

            new FilhoReconhecido().MeusAcessos();

            Console.WriteLine("");
            Console.WriteLine("############ Filho distante ############");
            Console.WriteLine("Filho distante");
            Console.WriteLine("");

            new FilhoDistante().MeusAcessos();

            Console.WriteLine("");
            Console.WriteLine("############ Amigo distante ############");
            Console.WriteLine("");

            new AmigoDistante().MeusAcessos();
            Console.WriteLine("");

            
        }

    }
}

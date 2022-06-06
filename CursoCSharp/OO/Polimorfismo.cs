using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Comida {
        public double PesoComida;
        public Comida(double pesoComida) {
            PesoComida = pesoComida;
        }
        public Comida() {
        }
    }

    public class Feijao: Comida {
        public Feijao(double peso) : base(pesoComida: peso) {
            PesoComida = peso;
        }
    }
    public class Arroz: Comida {
        public Arroz(double peso) : base(pesoComida: peso) {
            PesoComida = peso;
        }
    }
    public class Mistura: Comida {
        public Mistura(double peso) : base(pesoComida: peso) {
            PesoComida = peso;
        }
    }
    public class Pessoa {
        public double Peso;

        public Pessoa(double peso) {
            Peso = peso;
        }
        public void Comer(Comida comida) {
            Peso += comida.PesoComida;
        }
    }
    internal class Polimorfismo {
        public static void Executar() {

            Pessoa pessoa = new(78);
            Console.WriteLine("Peso da pessoa antes de comer: " + pessoa.Peso);

            Feijao feijao = new(0.3);
            Arroz arroz = new(0.3);
            Mistura mistura = new(0.3);

            pessoa.Comer(feijao);
            pessoa.Comer(arroz);
            pessoa.Comer(mistura);

            Console.WriteLine("Peso da pessoa depois de comer: " + pessoa.Peso);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Animal {

        public string Nome {
            get; set;
        }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro: Animal {
        public double Altura {
            get; set;
        }

        public Cachorro(string nome) : base(nome: nome) { } //pelo menos um construtor deve possuir o base quando há uma herança

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        //public Cachorro(string nome) : this(nome, 0.0) { }//não pode fazer isso senão vai chamar o construtor acima e vai ficar de forma cíclica, somente dentro desse construtor aqui e não vai chamar outros

    }
    internal class ConstrutorThis {

        public static void Executar() {
            Cachorro max = new("max");
            Console.WriteLine(max.Nome);

            Cachorro thor = new(nome: "Thor", altura: 0.9);
            Console.WriteLine($"{thor.Nome} tem {thor.Altura}m");

        }
    }
}

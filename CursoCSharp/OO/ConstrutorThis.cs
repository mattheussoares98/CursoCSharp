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

        public int Idade {
            get; set;
        }

        public Cachorro(string nome) : base(nome: nome) { }
        //como a classe Cachorro está herdando de Animal que possui um construtor, precisa haver pelo menos um construtor pra classe Cachorro e deve usar o base para referenciar o construtor da classe Animal

        public Cachorro(string nome, double altura) : this(nome) {
            //o this está se referenciando ao construtor acima desse aqui. Se retirar o this, da erro porque o construtor não vai fazer referência ao contrutor do Animal, que é uma classe que está sendo herdada
            Altura = altura;
        }
        public Cachorro(string nome, double altura, int idade) : base(nome: nome) {
            Altura = altura;
            Idade = idade;
        }


        //public Cachorro(string nome) : this(nome, 0.0) { }
        //não pode fazer isso senão vai chamar um construtor que não faz referência à algum construtor da classe herdada. Sempre que uma classe herda outra, é necessário usar o base para associar o construtor à classe herdada. 
        //Funciona usar o this quando o construtor que está referenciando utiliza uma referência para a classe herdada

    }
    internal class ConstrutorThis {

        public static void Executar() {
            Cachorro max = new("max");
            Console.WriteLine(max.Nome);

            Cachorro thor = new(nome: "Thor", altura: 0.9);
            Console.WriteLine($"{thor.Nome} tem {thor.Altura}m");

            Cachorro madonna = new(nome: "Madonna", idade: 10, altura: 0.7);
            Console.WriteLine($"{madonna.Nome} possui {madonna.Idade} anos e {madonna.Altura}m de altura");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima; //só será possível alterar uma vez e em alguma classe que herde Carro
        private int VelocidadeAtual = 0;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int velocidadeAdicionada) {

            if(VelocidadeAtual + velocidadeAdicionada > VelocidadeMaxima) {
                Console.WriteLine("A velocidade não pode ser atribuída, pois ultrapassaria a velocidade máxima \nAtribuindo a velocidade máxima ao carro...");
                VelocidadeAtual = VelocidadeMaxima;
            } else if(VelocidadeAtual + velocidadeAdicionada < 0) {
                Console.WriteLine("A velocidade não pode ser atribuída, pois ficaria menor que 0");
                VelocidadeAtual = 0;
            } else {
                //Console.WriteLine("Velocidade atribuída com sucesso");
                VelocidadeAtual += velocidadeAdicionada;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() { //a palavra virtual indica que esse método pode ser sobrescrito. De padrão, os métodos não podem ser sobrescritos
            return AlterarVelocidade(10);

        }

        public virtual int Frear() { //a palavra virtual indica que esse método pode ser sobrescrito. De padrão, os métodos não podem ser sobrescritos
            return AlterarVelocidade(-10);
        }
    }

    public class Uno: Carro {
        public Uno() : base(velocidadeMaxima: 200) { }
        //como o Uno está herdando a classe Carro, ele precisa fazer referência a pelo menos um construtor do Carro utilizando o base
    }

    public class Ferrari: Carro {
        public Ferrari() : base(velocidadeMaxima: 350) { }
        //como a Ferrari está herdando a classe Carro, ele precisa fazer referência a pelo menos um construtor do Carro, utilizando o base

        public override int Acelerar() {
            //só foi possível sobrescrever o método porque foi adicionado um "virtual" na declaração do método. É obrigatório informar que é virtual para conseguir sobrescrever. O método precisa receber os mesmos parâmetros que a classe que está sendo sobrescrita
            return AlterarVelocidade(20);
        }

        public override int Frear() {
            //só foi possível sobrescrever o método porque foi adicionado um "virtual" na declaração do método. É obrigatório informar que é virtual para conseguir sobrescrever. O método precisa receber os mesmos parâmetros que a classe que está sendo sobrescrita
            return AlterarVelocidade(-20);
        }
    }

    public class Teste {
    }
    internal class Heranca {
        public static void Executar() {
            Uno uno = new();
            Ferrari ferrari = new();

            Console.WriteLine("Uninho");
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());

            Console.WriteLine();

            Console.WriteLine("Ferrari");
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());

            Carro carro = new Uno(); //só é possível fazer essa atribuição porque o Uno herda a classe Carro
            Console.WriteLine("#####################################################################################");
            Console.WriteLine("Criando uma variável do tipo Carro e atribuindo um Uno à ela");
            Console.WriteLine("Acelerando o Uninho");
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine("Freando o Uninho");
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());

            carro = new Ferrari(); //só é possível fazer essa atribuição porque a Ferrari herda a classe Carro
            Console.WriteLine("Alterando o tipo do carro para uma Ferrari e acelerando ela");
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine("Freando a Ferrari");
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
        }
    }
}

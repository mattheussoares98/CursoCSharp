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
        protected int AlterarVelocidade(int delta) {

            if(VelocidadeAtual + delta > VelocidadeMaxima) {
                Console.WriteLine("A velocidade não pode ser atribuída, pois ultrapassaria a velocidade máxima");
                VelocidadeAtual = VelocidadeMaxima;
            } else if(VelocidadeAtual + delta < 0) {
                Console.WriteLine("A velocidade não pode ser atribuída, pois ficaria menor que 0");
                VelocidadeAtual = 0;
            } else {
                //Console.WriteLine("Velocidade atribuída com sucesso");
                VelocidadeAtual += delta;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() { //a palavra virtual indica que esse método pode ser
                                        //sobrescrito. De padrão, os métodos não podem ser
                                        //sobrescritos
            return AlterarVelocidade(10);

        }

        public virtual int Frear() { //a palavra virtual indica que esse método pode ser
                                     //sobrescrito. De padrão, os métodos não podem ser
                                     //sobrescritos
            return AlterarVelocidade(-10);
        }
    }

    public class Uno: Carro {
        public Uno() : base(200) { }
        //como o Uno está herdando a classe Carro, ele precisa fazer referência a pelo menos um
        //construtor do Carro, utilizando o base
    }

    public class Ferrari: Carro {
        public Ferrari() : base(velocidadeMaxima: 350) { }
        //como a Ferrari está herdando a classe Carro, ele precisa fazer referência a pelo menos um
        //construtor do Carro, utilizando o base

        public override int Acelerar() {
            //só foi possível sobrescrever o método porque foi adicionado um "virtual" na
            //declaração do método. É obrigatório informar que é virtual para conseguir
            //sobrescrever. O método precisa receber os mesmos parâmetros que a classe que
            //está sendo sobrescrita
            return AlterarVelocidade(20);
        }

        public override int Frear() {
            //só foi possível sobrescrever o método porque foi adicionado um "virtual" na
            //declaração do método. É obrigatório informar que é virtual para conseguir
            //sobrescrever. O método precisa receber os mesmos parâmetros que a classe que
            //está sendo sobrescrita
            return AlterarVelocidade(-20);
        }
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

            Carro carro1 = new Uno();
            Console.WriteLine("#####################################################################################");
            Console.WriteLine("Criando uma variável do tipo Carro e atribuindo um Uno à ela");
            Console.WriteLine("Acelerando o Uninho");
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine("Freando o Uninho");
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            carro1 = new Ferrari();
            Console.WriteLine("Alterando o tipo do carro para uma Ferrari e acelerando ela");
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine("Freando a Ferrari");
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Produto {

        public Produto(double preco, double desconto, string nome) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {
        }

        double preco = 0;
        string nome = "";
        double desconto = -1;


        public string Nome {
            get => nome;
            set => nome = value;
        }

        public double Preco {
            get {
                return (double)preco!;
            }
            set {
                if(value > 0) {
                    preco = value;
                }
            }
        }

        //por mais que o get e set não faça nada, já está habilitado. Caso precise, pode implementar depois
        //Propriedade autoimplementada
        //public double Preco {
        //    get; set;
        //}

        public double Desconto {
            get {
                return (double)desconto;
            }
            set {
                if(value >= 0 && value <= 100) {
                    desconto = value / 100;
                }
            }
        }

        //somente leitura pois possui somente o get
        public double PrecoComDesconto {
            get => Preco - (Preco * Desconto);
        }
    }
    internal class Propriedades {


        public static void Executar() {
            Produto produto = new();

            while(produto.Nome == "") {
                Console.Write("Digite o NOME do produto: ");
                string? dadoDigitadoPeloUsuario = Console.ReadLine();

                bool dadoDigitadoEhValido;

                dadoDigitadoEhValido = dadoDigitadoPeloUsuario != "" ? true : false;
                if(dadoDigitadoEhValido) {
                    produto.Nome = dadoDigitadoPeloUsuario!;

                    Console.WriteLine("Nome adicionado com sucesso!");
                    Console.WriteLine("");

                } else {
                    Console.WriteLine("Dado inválido!");
                    Console.WriteLine("");
                }
            }


            while(produto.Preco == 0) {
                Console.Write("Digite o PREÇO do produto: ");
                string? dadoDigitadoPeloUsuario = Console.ReadLine();

                bool dadoDigitadoEhValido;
                dadoDigitadoEhValido = double.TryParse(dadoDigitadoPeloUsuario!, out double result);

                if(dadoDigitadoEhValido) {
                    produto.Preco = double.Parse(dadoDigitadoPeloUsuario!);

                    Console.WriteLine("Preço adicionado com sucesso!");
                    Console.WriteLine("");

                } else {
                    Console.WriteLine("Dado inválido!");
                    Console.WriteLine("");
                }
            }

            while(produto.Desconto < 0 || produto.Desconto > 100) {
                Console.Write("Digite o DESCONTO do produto: ");
                string? dadoDigitadoPeloUsuario = Console.ReadLine();

                bool dadoDigitadoEhValido;

                dadoDigitadoEhValido = double.TryParse(dadoDigitadoPeloUsuario!, out double result);

                if(dadoDigitadoEhValido && result >=0 && result <= 100) {
                    produto.Desconto = double.Parse(dadoDigitadoPeloUsuario!);

                    Console.WriteLine("Desconto adicionado com sucesso!");
                    Console.WriteLine("");

                } else {
                    Console.WriteLine("O desconto deve estar entre 0 e 100!");
                    Console.WriteLine("");
                }
            }


            Console.WriteLine("Nome do produto: {0}", produto.Nome);
            Console.WriteLine($"Preço do produto: {produto.Preco}");
            Console.WriteLine($"Desconto do produto: {produto.Desconto * 100}%");
            Console.WriteLine($"Preço do produto com desconto: {produto.PrecoComDesconto}");

            Console.WriteLine("");
            Console.WriteLine("##############################################################################");

            Produto produto2 = new() {
                Nome = "Mattheus",
                Preco = 100,
                Desconto = 10
            };

            Console.WriteLine("Nome do produto2: {0}", produto2.Nome);
            Console.WriteLine($"Preço do produto2: {produto2.Preco}");
            Console.WriteLine($"Desconto do produto2: {produto2.Desconto * 100}%");
            Console.WriteLine($"Preço do produto com desconto2: {produto2.PrecoComDesconto}");


            Produto produtoComDadosNoConstrutor = new(nome: "Mattheus", preco: 100, desconto: 10);


            Console.WriteLine("Nome do produto com dados no construtor: {0}", produtoComDadosNoConstrutor.Nome);
            Console.WriteLine();
            Console.WriteLine($"Preço do produto com dados no construtor: {produtoComDadosNoConstrutor.Preco}");
            Console.WriteLine();
            Console.WriteLine($"Desconto do produto com dados no construtor: {produtoComDadosNoConstrutor.Desconto * 100}%");
            Console.WriteLine();
            Console.WriteLine($"Preço do produto com desconto com dados no construtor: {produtoComDadosNoConstrutor.PrecoComDesconto}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    public class Produto {
        string nome = "";
        double preco = 0;
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public double Preco {
            get => preco;
            set => preco = value;
        }

        public string Nome {
            get => nome;
            set => nome = value;
        }
    }
    internal class List {

        public static void Executar() {
            List<Produto> carrinho = new();

            Produto produto1 = new (nome: "Mattheus", preco: 10);

            carrinho.Add(produto1);
            Console.WriteLine(carrinho.ElementAt(0));

            List<Produto> combo = new() {
            new Produto(nome: "Soares", preco: 20),
            new Produto(nome: "Barbosa", preco: 30),
        };

            carrinho.AddRange(combo); //percorre cada item da lista e adiciona no carrinho
        }
    }
}

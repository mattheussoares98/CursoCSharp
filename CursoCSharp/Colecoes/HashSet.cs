using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    internal class HashSet {

        public static void Executar() {
            HashSet<Produto> carrinho = new();

            Produto produto1 = new(nome: "Mattheus", preco: 10);

            carrinho.Add(produto1);
            Console.WriteLine(carrinho.ElementAt(0));

            HashSet<Produto> combo = new() {
            new Produto(nome: "Soares", preco: 20),
            new Produto(nome: "Barbosa", preco: 30),
        };

            carrinho.UnionWith(combo); //Adiciona todos itens do combo no carrinho
        }
    }
}

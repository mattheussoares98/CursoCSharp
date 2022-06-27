using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Dictionary {
        //o Dictionary é igual ao map no dart
        public static void Executar() {
            Dictionary<int, string> filmes = new() {
                //não pode repetir a chave/key, que no caso é um int

                {
                    0,
                    "1998"
                },
                {
                    1,
                    "1999"
                },
                {
                    2,
                    "2000"
                },
                {
                    3,
                    "2001"
                },
                {
                    4,
                    "2002"
                },
                {
                    5,
                    "2003"
                }
            };

            foreach(var filme in filmes) {
                Console.WriteLine("filme.key: " + filme.Key);
                Console.WriteLine("filme.value: " + filmes[filme.Key]+ "\n");
                //Console.WriteLine(filmes.GetValueOrDefault(key)); retorna os valores também
                Console.Write("removeu: " + filmes.Remove(filme.Key, out string? removeu) + $" {removeu}" );

                //bool removeu = filmes.Remove(key);
                //Console.WriteLine($"Removeu o filme: {removeu}");

                filmes.TryGetValue(filme.Key, out string? correctValue);
                Console.WriteLine("\ncorrectValue: " + correctValue);

                bool temEssaChave = filmes.TryGetValue(200, out string? incorrectValue);
                //não tem problema se não houver essa chave 200
                if(temEssaChave) {
                    Console.WriteLine("\nincorrectValue: " + incorrectValue);
                    //quando não possui um valor correspondente à chave digitada, ele não imprime o
                    //valor no console. Imprime nulo
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Dictionary {
        //o Dictionary é igual ao map no dart
        public static void Executar() {
            Dictionary<int, string> filmes = new();
            //não pode repetir a chave/key, que no caso é um int

            filmes.Add(0, "1998");
            filmes.Add(1, "1999");
            filmes.Add(2, "2000");
            filmes.Add(3, "2001");
            filmes.Add(4, "2002");
            filmes.Add(5, "2003");

            foreach(var filme in filmes) {
                int key = filme.Key;
                Console.WriteLine("filme.key: " + key);
                Console.WriteLine(filmes[key]);
                //Console.WriteLine(filmes.GetValueOrDefault(key)); retorna os valores também
                //bool removeu = filmes.Remove(key);
                //Console.WriteLine($"Removeu o filme: {removeu}");

                filmes.TryGetValue(key, out string? correctValue);
                Console.WriteLine("correctValue: " + correctValue);

                bool temEssaChave = filmes.TryGetValue(200, out string? incorrectValue);
                //não tem problema se não houver essa chave 200
                if(temEssaChave) {
                    Console.WriteLine("incorrectValue: " + incorrectValue);
                    //quando não possui um valor correspondente à chave digitada, ele não imprime o
                    //valor no console. Imprime nulo
                }
            }
        }
    }
}
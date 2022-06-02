using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public enum EnumGenero {
        Animacao, Terror, Comedia, Romance, Acao, Infantil
    }
    public class Filme {
        string? nome;
        EnumGenero genero;

        public string Nome {
            get => nome!;
            set => nome = value;
        }

        public EnumGenero Genero {
            get => genero;
            set => genero = value;
        }

        public Filme(EnumGenero genero, string nome) {
            Nome = nome;
            Genero = genero;
        }

        public Filme() {
        }
    }
    internal class ExemploEnum {
        static readonly Filme filme = new(genero: EnumGenero.Terror, nome: "Algum filme de terror");
        static readonly Filme filme2 = new();

        public static void Executar() {
            Console.WriteLine($"O filme '{filme.Nome}' é do gênero '{filme.Genero}'");

            filme2.Genero = EnumGenero.Acao;
            filme2.Nome = "A volta dos que não foram";

            Console.WriteLine($"O filme '{filme2.Nome}' é do gênero '{filme2.Genero}'");

        }
    }
}

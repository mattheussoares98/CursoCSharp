using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ReadOnly {
        public static void Executar() {
            Pessoa pessoa = new(nome: "Mattheus Soares", dataDeNascimento: new DateTime(year: 2022, month: 3, day: 31, hour: 18, minute: 00, second: 59));

            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.dataDeNascimento);
        }
    }
    public class Pessoa {
        public readonly DateTime dataDeNascimento; //quando o atributo é ReadOnly, é possível alterar o valor dele apenas uma vez. Quando é const, funciona igual ao Dart, já precisa iniciar com um valor definido
        public string nome;

        public Pessoa(string nome, DateTime dataDeNascimento) {
            this.nome = nome;
            this.dataDeNascimento = dataDeNascimento;

            this.dataDeNascimento = new DateTime(year: 2022, month: 3, day: 31);
        }

    }

}

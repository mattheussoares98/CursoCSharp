using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {

        public static void Executar() {
            string[] alunos = new string[5]; //define o tamanho do array. Nesse caso o tamanho vai ser fixo em 5
               //os arrays sempre são estáticos

            alunos[0] = "Mattheus";
            alunos[1] = "Soares";
            alunos[2] = "Barbosa";
            alunos[3] = "Teste";
            alunos[4] = "Ué";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double[] notas = { 10, 9, 9.5, 8.5, 5};//o tamanho desse array vai ser fixo também. Como declarou com 5 valores, sempre vai ter 5 valores

            double somaNotas = 0;
            foreach(var nota in notas) {
                somaNotas += nota;
            }

            double mediaNotas = somaNotas / notas.Length;

            Console.WriteLine($"A média das notas é {mediaNotas}");
        }
    }
}

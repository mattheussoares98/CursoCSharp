using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {

    public class Aluno {
        public string? Nome;
        public int? Idade;
        public double? Nota;
    }
    internal class LINQ1 {
        public static void Executar() {
            var alunos = new List<Aluno>() {
                new Aluno(){Nome= "Mattheus", Idade= 24, Nota= 10},
                new Aluno(){Nome= "Soares", Idade= 23, Nota= 9.5},
                new Aluno(){Nome= "Barbosa", Idade= 22, Nota= 9.2},
                new Aluno(){Nome= "Santos", Idade= 21, Nota= 3.4},
                new Aluno(){Nome= "Silva", Idade= 20, Nota= 2.1},
                new Aluno(){Nome= "Augusto", Idade= 19, Nota= 5.0},
                new Aluno(){Nome= "Mattheus", Idade= 18, Nota= 8.7},
            };

            Console.WriteLine("Alunos aprovados ordenado pelo nome");
            var alunosAprovados = alunos.Where(aluno => aluno.Nota > 7).OrderBy(aluno => aluno.Nome); //o where e o orderby só estão disponíveis porque fez o import do LINQ
            foreach(var alunoAprovado in alunosAprovados) {
                Console.WriteLine(alunoAprovado.Nome);
            }


            Console.WriteLine("\nChamada ordenada por nome");
            var chamada = alunos.OrderBy(aluno => aluno.Nome).Select(aluno => aluno.Nome);
            foreach(var nome in chamada) {
                Console.WriteLine(nome);
            }


            Console.WriteLine("\nAlunos aprovados e sendo filtrado por comandos parecidos com do SQL");
            var selectAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Nome
                select aluno.Nome;

            foreach(var aluno in selectAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}

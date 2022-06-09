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
                new Aluno() { Nome= "José", Idade= 18, Nota= 8.7},
            };
        }
    }
}

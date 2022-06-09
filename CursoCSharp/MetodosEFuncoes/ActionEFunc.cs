using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class ActionEFunc {
        //Lambda é uma função anônima
        public static void Executar() {
            Action<string> rintNome = (string nome) => { Console.WriteLine($"Nome: {nome}"); };

            Func<int> rintNumero = () => { return 0; };
            //o último generic é sempre o retorno da função

            Func<double, double, string> rintIdadeEAltura = (double idade, double altura)
            //nesse caso recebe 2 double como parâmetro e retorna uma string
                => {
                    return $"Altura: {altura}, idade: {idade}";
                };

            static string printNomeENascimento(string nome, int nascimento) {
                return $"O {nome} nasceu em {nascimento}";
            }

            rintNome("Mattheus");
            Console.WriteLine("Número: " + rintNumero());
            Console.WriteLine(rintIdadeEAltura(24, 1.84));
            Console.WriteLine(printNomeENascimento(nome: "Matheus", nascimento: 1998));
        }
    }
}

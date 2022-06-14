using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Matriz {
        public static void Executar() {
            double[,] numeros = new double[2, 3];
            //essa vírgula no meio dos [] indica que é uma matriz. Nesse caso, a matriz possui 2 linhas e 3 colunas

            string[,] nomes =  {
                {
                "Mattheus", "Soares", "Barbosa", //como possui 3 colunas, nos próximos dados precisa ter 3 colunas também
                },{
                "Barbosa", "Soares", "Mattheus", 
                },
        };
            numeros[0, 0] = 1; //linha 1 e coluna 1
            numeros[1, 1] = 2; //linha 2 e coluna 2
        }
    }
}

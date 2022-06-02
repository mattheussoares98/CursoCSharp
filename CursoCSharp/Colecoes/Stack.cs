using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Stack {
        public static void Executar() {
            var stack = new Stack<object>();

            stack.Push("Mattheus");
            stack.Push(1);
            stack.Push(1.0);
            stack.Push(true);
            //um Stack ordena ao contrário o que foi adicionado. Nesse caso, o primeiro item a ser retirado será o "true"

            Console.WriteLine(stack.Count);
            var retirado = stack.Pop(); //retira o primeiro item do Stack e o retorna na função
            Console.WriteLine(stack.Count);
            Console.WriteLine(retirado.GetType());

            stack.Peek(); //retira o primeiro item da fila e não o retorna na função
        }
    }
}

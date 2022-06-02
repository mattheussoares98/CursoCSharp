using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class FilaQueue {

        public static void Executar() {
            Queue<object> queueObject = new Queue<object>();
            Queue<string> nomes = new Queue<string>();

            queueObject.Enqueue(1);//adiciona items na fila
            queueObject.Enqueue(1.0);
            queueObject.Enqueue("1");
            queueObject.Enqueue(true);

            Console.WriteLine(queueObject.Count);
            queueObject.Peek();//retorna o item que está em primeiro na fila
            queueObject.Dequeue();//retira o primeiro item que está pra sair da fila
            Console.WriteLine(queueObject.Count);

            Console.WriteLine(queueObject.Contains("1"));
        }
    }
}

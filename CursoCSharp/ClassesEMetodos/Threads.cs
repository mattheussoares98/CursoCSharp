using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CursoCSharp.ClassesEMetodos {
    internal class Threads {
        //as Threads são muito parecidas com as Tasks. Em ambos é possível fazer com que tarefas sejam executadas simultaneamente, sem uma ordem correta de execução
        public static void Executar() {
            Thread thread = new Thread(new ThreadStart(PrintarIndices));
            thread.Start();
            //thread.Join(); //espera terminar a execução de "PrintarIndices" para ir para a próxima thread
            //thread.IsBackground = true;//significa que quando terminar a execução da thread abaixo (a que imprime os índices fora da thread), vai interromper a execução da "thread" quando a thread abaixo for encerrada

            for(int i = 0; i < 10; i++) {
                Console.WriteLine("Índices fora da thread");
            }
            
        }

        private static void PrintarIndices() {
            for(int i = 0; i < 10; i++) {
                Console.WriteLine("Printando índice da thread: " + i);
                System.Threading.Thread.Sleep(1000); //espera esse período para continuar a execução da thread
            }
        }
    }
}

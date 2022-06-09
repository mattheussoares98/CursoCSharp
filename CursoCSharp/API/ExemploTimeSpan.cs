using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API {
    internal class ExemploTimeSpan {
        //public TimeSpan(int seconds) {
        //}

        public static void Executar() {
            TimeSpan timeSpan = new(days: 10, hours: 10, minutes: 10, seconds: 10);
            Console.WriteLine($"Tempo inicial: {timeSpan}");

            Console.WriteLine("timeSpan.Days: " + timeSpan.Days);
            Console.WriteLine("timeSpan.Hours: " + timeSpan.Hours);
            Console.WriteLine("timeSpan.Minutes: " + timeSpan.Minutes);
            Console.WriteLine("timeSpan.Seconds: " + timeSpan.Seconds);

            Console.WriteLine("timeSpan.Duration: " + timeSpan.Duration());

            Console.WriteLine("timeSpan.Add 1 day:" + timeSpan.Add(new TimeSpan(days: 1, hours: 0, minutes: 0, seconds: 0)));
            //quando adiciona ou subtrai algum valor de um TimeSpan, ele não altera o valor que foi passado como parâmetro, ele retorna um valor novo com esse valor caso queira usar

            Console.WriteLine("timeSpan.Subtract 1 day: " + timeSpan.Subtract(new TimeSpan(days: 1, hours: 0, minutes: 0, seconds: 0)));
            //quando adiciona ou subtrai algum valor de um TimeSpan, ele não altera o valor que foi passado como parâmetro, ele retorna um valor novo com esse valor caso queira usar

            TimeSpan intervalo = DateTime.Now - DateTime.Now.AddDays(1);
            //quando subtrai duas datas, retorna a diferença das datas em um TimeSpan
            Console.WriteLine("DateTime.Now - DateTime.Now.AddDays(1): " + intervalo);

            Console.WriteLine("ToString(\"g\"): " + intervalo.ToString("g"));
            Console.WriteLine("ToString(\"G\"): " + intervalo.ToString("G"));
            Console.WriteLine("ToString(\"c\"): " + intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}

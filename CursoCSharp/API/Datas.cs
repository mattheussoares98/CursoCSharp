using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API {

    sealed class AlterarData {

        public AlterarData() {
        }
        public static void AlterarDataInformada(DateTime dataInformada, double dias = 0, int meses = 0, int anos = 0) {
            dataInformada = dataInformada.AddDays(dias);
            dataInformada = dataInformada.AddMonths(meses);
            dataInformada = dataInformada.AddYears(anos);

            Console.WriteLine(dataInformada);
        }
    }
    internal class Datas {

        public static void Executar() {
            AlterarData.AlterarDataInformada(DateTime.Now, dias: 1, meses: 1, anos: 1);
            AlterarData.AlterarDataInformada(DateTime.Now, dias: -1, meses: -1, anos: -1);

            Console.WriteLine("\nDate: " + DateTime.Now.Date);
            Console.WriteLine("Minute: " + DateTime.Now.Minute);
            Console.WriteLine("Month: " + DateTime.Now.Month);
            Console.WriteLine("Year: " + DateTime.Now.Year);
            Console.WriteLine("Day: " + DateTime.Now.Day + "\n");

            Console.WriteLine(DateTime.Now.ToString("d"));
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("D"));
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")); //quando está usando o toString, só de digitar "d", "m" ou "y", o visual studio já mostra sugestões indicando como fica se usar de formas diferentes

        }
    }
}

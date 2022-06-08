using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API {

    sealed class AlterarData {
        public AlterarData(double dias) {
            NovaData = NovaData.AddDays(dias);
        }
        //public AlterarData(double meses) {
        //    NovaData = NovaData.AddDays(meses);
        //}
        DateTime NovaData {
            get; set;
        }

    }
    internal class Datas {

        public static void Executar() {
            //AdicionarData()
            //AdicionarMes(dataInformada: DateTime.Now, meses: 1);
            //AdicionarAno(dataInformada: DateTime.Now, anos: 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1000000;
        }
    }

    //class Filho: SemFilho {
    //} não é possível implementar classes do tipo sealed

    class Avo {
        public virtual bool PodeHonrarAFamilia() {
            return true;
        }
    }

    class Pai: Avo {
        public sealed override bool PodeHonrarAFamilia() {
            return false;
        }
    }

    class Filho: Pai {
        //public override bool PodeHonrarAFamilia() {
        //    return false;
        //} não é possível sobrescrever um método do tipo sealed

        //é possível criar um método com o mesmo nome do sealed. O novo método é o que será
        //levado em consideração quando chamar o método
        public new bool PodeHonrarAFamilia() {
            return false;
        }
    }
    internal class Sealed {
        public static void Executar() {
            Console.WriteLine("Uma classe do tipo sealed não pode ser herdada");
            Console.WriteLine("");
            Console.WriteLine("Não é possível sobrescrever um método do tipo sealed usando o " +
                "override. Porém, é possível criar um método com o mesmo nome");
            Console.WriteLine("");
            Console.WriteLine("Leia o código caso queira entender melhor como funciona!");
        }
    }
}

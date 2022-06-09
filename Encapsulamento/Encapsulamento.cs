namespace Encapsulamento {
    public class Atributos {
        //todos conseguem acessar
        public string InfoPublica = "Tenho instagram!";

        //acessável por herança
        protected string CorDoOlho = "Verde";

        //mesmo projeto (namespace)
        internal ulong NumeroCelular = 11961235430;

        //herança ou mesmo projeto (namespace)
        internal protected string JeitoDeFalar = "Uso muitas gírias";

        //mesma classe ou herança no mesmo projeto
        private protected string SegredoFamilia = "blá blá blá";

        //privado. É o padrão!
        private bool EhAlto = true;

        //obviamente, todos atributos são acessáveis por essa classe

        public void MeusAcessos() {
            Console.WriteLine("InfoPublica: " + InfoPublica);
            Console.WriteLine("CorDoOlho: " + CorDoOlho);
            Console.WriteLine("NumeroCelular: " + NumeroCelular);
            Console.WriteLine("JeitoDeFalar: " + JeitoDeFalar);
            Console.WriteLine("SegredoFamilia: " + SegredoFamilia);
        }
    }
}

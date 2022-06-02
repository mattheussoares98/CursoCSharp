namespace Encapsulamento {
    public class FilhoReconhecido : Atributos {
        //como está herdando, não precisa instanciar uma nova classe para ter acesso aos atributos da SubCelebridade
        public new void MeusAcessos() {//coloquei new para sobrescrever o método do SubCelebridade
            Console.WriteLine("InfoPublica: " + InfoPublica);
            Console.WriteLine("CorDoOlho: " + CorDoOlho);
            Console.WriteLine("NumeroCelular: " + NumeroCelular);
            Console.WriteLine("JeitoDeFalar: " + JeitoDeFalar);
            Console.WriteLine("SegredoFamilia: " + SegredoFamilia);
        }
    }
}

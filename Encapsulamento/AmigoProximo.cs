namespace Encapsulamento {
    public class AmigoProximo {
        public readonly Atributos amigo = new();
        public void MeusAcessos() {
            Console.WriteLine("Amigo");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho);
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia);
        }
    }
}

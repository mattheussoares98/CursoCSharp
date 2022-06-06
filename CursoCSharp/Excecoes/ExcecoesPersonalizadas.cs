using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {
    public class ImparException: Exception {
        public ImparException(string message) : base(message) { }
        public ImparException(string message, Exception innerException)
            : base(message, innerException) { }

        public ImparException() {
        }
    }
    public class NegativoException: Exception {
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception innerException)
            : base(message, innerException) {
            Console.WriteLine(innerException.Message);
        }

        public NegativoException() {
        }
    }

    internal class ExcecoesPersonalizadas {
        static int SortearNumeroPar() {
            int sorteado = new Random().Next(-30, 30);
            if(sorteado % 2 == 1) {
                Console.WriteLine(sorteado);
                throw new ImparException("O número é ímpar");
            } else if(sorteado < 0) {
                Exception exception = new();
                Console.WriteLine(sorteado);
                throw new NegativoException("O número é negativo", exception);
            }

            return sorteado;
        }

        public static void Executar() {
            try {
                Console.WriteLine(SortearNumeroPar());
            } catch(ImparException imparException) {
                Console.WriteLine(imparException.Message);
            } catch(NegativoException negativoException) {
                Console.WriteLine(negativoException.Message);
            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            } finally { }

        }
    }
}

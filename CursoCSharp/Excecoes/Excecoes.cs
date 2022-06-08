using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {

    public class Conta {
       private double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if(valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }

    }
    internal class Excecoes {
        public static void Executar() {
            Conta conta = new(17000);

            try {
                conta.Sacar(18000);
                Console.WriteLine("Sacou com sucesso");
            } catch(Exception e) {
                //esse Exception é o tipo mais genérico que possui
                Console.WriteLine(e.Message);
                //e.Message pega a mensagem que foi lançada no erro
            } finally { 
                //executa SEMPRE. Ocorrendo erro ou não
            }
        }
    }
}

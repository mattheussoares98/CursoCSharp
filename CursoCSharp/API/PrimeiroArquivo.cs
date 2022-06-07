using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //utilizado para manipular arquivos

namespace CursoCSharp.API {
    public static class GetHomePath {
        private static readonly string homePath = (Environment.OSVersion.Platform == PlatformID.Unix ||
                     Environment.OSVersion.Platform == PlatformID.MacOSX)
      ? Environment.GetEnvironmentVariable("HOME")
      : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

        public static string UpdatePath(this string path) {
            return path.Replace("~", homePath);
        }
    }
    internal class PrimeiroArquivo {
        public static void Executar() {
            //o @ serve pra usar a string de forma literal. No caso do \n por exp, não quebra a linha
            //o "~" é a parte HOME do path do caminho do usuário
            var path = @"~/Primeiro arquivo.txt".UpdatePath();

            if(!File.Exists(path)) {
                //motivo de usar o using: quando usa escrita de arquivos, o C# vai alocar/abrir
                //alguns recursos do sistema operacional que é importante que esses recursos sejam
                //fechados quando parar de usá-los. 
                //para usar o using, basta colocar conforme a seguir. Depois que sair do bloco, o
                //sistema vai fechar todos recursos que foram usados para escrever no disco
                using(StreamWriter sw = File.CreateText(path)) {
                    //File.CreateText cria o arquivo
                    //esse StreamWriter é um stream de dados que vai escrevendo em determinado local
                    sw.WriteLine("1"); //adiciona esse texto no primeiroArquivo.txt
                    sw.WriteLine("1"); //adiciona esse texto no primeiroArquivo.txt
                    sw.WriteLine("1"); //adiciona esse texto no primeiroArquivo.txt
                    sw.WriteLine("1"); //adiciona esse texto no primeiroArquivo.txt

                }
            }
            using(StreamWriter sw = File.AppendText(path)) {
                //File.AppendText atualiza o arquivo
                //esse StreamWriter é um stream de dados que vai escrevendo em determinado local
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt

            }


        }
    }
}

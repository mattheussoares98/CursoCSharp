using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //utilizado para manipular arquivos

namespace CursoCSharp.API {
    public static class GetHomePath {
        public static string UpdateHomePath(this string path) {
            string? home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                             Environment.OSVersion.Platform == PlatformID.MacOSX)
              ? Environment.GetEnvironmentVariable("HOME")
              : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }
    internal class ExemploFileEscrevendo {
        public static void Executar() {
            //o @ serve pra usar a string de forma literal. No caso do \n por exp, não quebra a linha
            //o "~" é substituído pelo HOME do usuário logado no sistema operacional
            var path = @"~/Primeiro arquivo.txt".UpdateHomePath();

            if(!File.Exists(path)) {
                //motivo de usar o using: quando usa escrita de arquivos, o C# aloca/abre alguns recursos do sistema operacional e é importante que esses recursos sejam fechados quando parar de usá-los.
                //Só é possível usar o "using" quando o que está entre os (), utiliza algo que implementa um IDisposable. Depois que sair do bloco, o sistema vai fechar todos recursos que foram usados para escrever no disco
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
                //File.AppendText atualiza o arquivo e caso não tenha um arquivo com esse nome e
                //caminho, ele cria um novo
                //esse StreamWriter é um stream de dados que vai escrevendo em determinado local
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt
                sw.WriteLine("2"); //adiciona esse texto no primeiroArquivo.txt

            }
        }
    }
}

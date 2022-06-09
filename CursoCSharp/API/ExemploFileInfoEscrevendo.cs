using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API {
    internal class ExemploFileInfoEscrevendo {

        private static void ExcluirDados(params string[] caminhos) {
            foreach(var caminho in caminhos) {
                FileInfo fi = new(caminho);
                fi.Delete();
            }
        }

        public static void Executar() {
            string origem = @"~/Origem.txt".UpdateHomePath();
            string copiaOrigem = @"~/Copia origem.txt".UpdateHomePath();
            string destino = @"~/Destino".UpdateHomePath();
            string destinoArquivo = $@"{destino}/Destino.txt".UpdateHomePath();


            ExcluirDados(origem, copiaOrigem, destinoArquivo, destino);

            if(!Directory.Exists(destino)) {
                Directory.CreateDirectory(destino);
            }

            using(StreamWriter sw = File.AppendText(origem)) {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo fi = new(origem);
            Console.WriteLine("FullName: " + fi.FullName);
            Console.WriteLine("Name: " + fi.Name);
            Console.WriteLine("Length: " + fi.Length);
            Console.WriteLine("LinkTarget: " + fi.LinkTarget);
            Console.WriteLine("Attributes: " + fi.Attributes);
            Console.WriteLine("Directory: " + fi.Directory);
            Console.WriteLine("DirectoryName: " + fi.DirectoryName);
            Console.WriteLine("Extension: " + fi.Extension);
            Console.WriteLine("IsReadOnly: " + fi.IsReadOnly);
            Console.WriteLine("LastAccessTime: " + fi.LastAccessTime);
            Console.WriteLine("LastAccessTimeUtc: " + fi.LastAccessTimeUtc);
            Console.WriteLine("LastWriteTime: " + fi.LastWriteTime);
            Console.WriteLine("LastWriteTimeUtc: " + fi.LastWriteTimeUtc);

            Console.WriteLine("Digite algo para continuar");
            Console.ReadLine();

            fi.CopyTo(copiaOrigem);
            Console.WriteLine("Digite algo para continuar");
            Console.ReadLine();
            fi.MoveTo(destinoArquivo);
        }
    }
}

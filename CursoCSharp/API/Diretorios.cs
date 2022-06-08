using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API {
    internal class Diretorios {

        private static void GetData(string[] data) {
            //fiz essa função pra não precisar ficar usando um foreach pra cada GET que retorna uma lista e ir percorrendo os dados pra exibir no prompt
            foreach(string dataItem in data) {
                Console.WriteLine(dataItem);
            }
        }

        public static void Executar() {
            string diretorio = @"~/Diretorio".UpdateHomePath();
            string leituraPastas = @"~".UpdateHomePath();
            string destino = @"~/Destino".UpdateHomePath();

            //var directoryInfo = new DirectoryInfo(leituraPastas);
            //é possível pegar informações do diretório usando o DirectoryInfo ou Directory. Os métodos são muito parecidos

            if(Directory.Exists(diretorio)) {
                Directory.Delete(diretorio, true);
            }

            if(Directory.Exists(destino)) {
                Directory.Delete(destino, true);
            }

            Directory.CreateDirectory(diretorio);
            Directory.Move(diretorio, destino);

            Console.WriteLine("GetCreationTime: " + Directory.GetCreationTime(leituraPastas));
            Console.WriteLine("GetCreationTimeUtc: " + Directory.GetCreationTimeUtc(leituraPastas));
            Console.WriteLine("GetDirectoryRoot: " + Directory.GetDirectoryRoot(leituraPastas));
            Console.WriteLine("GetLastAccessTime: " + Directory.GetLastAccessTime(leituraPastas));
            Console.WriteLine("GetLastWriteTime: " + Directory.GetLastWriteTime(leituraPastas));
            Console.WriteLine("GetParent: " + Directory.GetParent(leituraPastas));
            Console.WriteLine("GetCurrentDirectory: " + Directory.GetCurrentDirectory());

            Console.WriteLine("\n" + @"GetDirectories of 'C:\Users\Soares': ");
            GetData(Directory.GetDirectories(leituraPastas));

            Console.WriteLine("\nGetLogicalDrives: ");
            GetData(Directory.GetLogicalDrives());

            Console.WriteLine("\nGetFileSystemEntries: ");
            GetData(Directory.GetFileSystemEntries(leituraPastas));

            Console.WriteLine("\nGetFiles: ");
            GetData(Directory.GetFiles(leituraPastas));
        }
    }
}

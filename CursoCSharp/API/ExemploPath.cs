using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API {
    internal class ExemploPath {
        public static void Executar() {
            string pastaLeituraDados = @"~/".UpdateHomePath();

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(pastaLeituraDados));
            Console.WriteLine("GetExtension: " + Path.GetExtension(pastaLeituraDados));
            Console.WriteLine("GetFileName: " + Path.GetFileName(pastaLeituraDados));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(pastaLeituraDados));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(pastaLeituraDados));
            Console.WriteLine("GetPathRoot: " + Path.GetPathRoot(pastaLeituraDados));
            Console.WriteLine("GetRandomFileName: " + Path.GetRandomFileName());
            Console.WriteLine("GetTempFileName: " + Path.GetTempFileName());
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}

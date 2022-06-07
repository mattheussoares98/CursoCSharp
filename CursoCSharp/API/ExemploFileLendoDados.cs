using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API {
    internal class ExemploFileLendoDados {
        public static void Executar() {
            string path = @"~/lendo dados.txt".UpdateHomePath();

            if(!File.Exists(path)) {
                using(StreamWriter sw = new StreamWriter(path)) {
                    sw.WriteLine("Mattheus Soares Barbosa");
                    sw.WriteLine("31/03/1998");
                    sw.WriteLine("Masculino");
                }
            }

            try {
                using(StreamReader sr = File.OpenText(path)) {
                    string? textoDoArquivo = sr.ReadToEnd();
                    Console.WriteLine(textoDoArquivo);
                }
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

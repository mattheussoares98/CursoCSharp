using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API {
    internal class Environments {
        public static void Executar() {
            Console.WriteLine("x" + Environment.NewLine + "y"); //faz uma quebra de linha
            Console.WriteLine("ProcessPath: " + Environment.ProcessPath);
            Console.WriteLine("CurrentDirectory: " + Environment.CurrentDirectory);
            Console.WriteLine("SpecialFolder.MyDocuments: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine("SpecialFolder.AdminTools: " + Environment.GetFolderPath(Environment.SpecialFolder.AdminTools));

            string[] drives = Environment.GetLogicalDrives();
            foreach(string drive in drives) {
                Console.WriteLine("drive: " + drive);
            }

            Console.WriteLine("Is64BitOperatingSystem: " + Environment.Is64BitOperatingSystem);
            Console.WriteLine("Is64BitProcess: " + Environment.Is64BitProcess);
            Console.WriteLine("MachineName: " + Environment.MachineName);
            Console.WriteLine("OSVersion: " + Environment.OSVersion);
            Console.WriteLine("ProcessId: " + Environment.ProcessId);
            Console.WriteLine("SystemDirectory: " + Environment.SystemDirectory);

        }
    }
}

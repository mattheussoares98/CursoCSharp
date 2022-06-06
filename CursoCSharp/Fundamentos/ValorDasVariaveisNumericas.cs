using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class ValorDasVariaveisNumericas {
        public static void Executar() {
            Console.WriteLine("Executando!!!");

            const double pi = 3.1415;
            Console.WriteLine("pi = " + pi ); //no console imprime com vírgula por causa da
                                              //linguagem padrão do sistema operacional

            bool estaChovendo = false;
            Console.WriteLine("estaChovendo = " + estaChovendo );
            
            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;
            Console.WriteLine("maxByte = " + maxByte );
            Console.WriteLine("minByte = " + minByte );
            
            sbyte maxSbyte = sbyte.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            Console.WriteLine("maxSbyte = " + maxSbyte );
            Console.WriteLine("minSbyte = " + minSbyte );
            
            short maxShort = short.MaxValue;
            short minShort = short.MinValue;
            Console.WriteLine("maxShort = " + maxShort );
            Console.WriteLine("minShort = " + minShort );
            
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine("maxInt = " + maxInt );
            Console.WriteLine("minInt = " + minInt );
            
            uint maxUint = uint.MaxValue;
            uint minUint = uint.MinValue;
            Console.WriteLine("maxUint = " + maxUint );
            Console.WriteLine("minUint = " + minUint );
            
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("maxLong = " + maxLong );
            Console.WriteLine("minLong = " + minLong );
            
            ulong maxULong = ulong.MaxValue;
            ulong minULong = ulong.MinValue;
            Console.WriteLine("maxULong = " + maxULong );
            Console.WriteLine("minULong = " + minULong );
            
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            Console.WriteLine("maxFloat = " + maxFloat );
            Console.WriteLine("minFloat = " + minFloat );
            
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine("maxDouble = " + maxDouble );
            Console.WriteLine("minDouble = " + minDouble );
            
            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;
            Console.WriteLine("maxDecimal = " + maxDecimal );
            Console.WriteLine("minDecimal = " + minDecimal );
            
            char letra = 'a'; //só pode ter uma letra
            Console.WriteLine("letra = " + letra);
        }
    }
}

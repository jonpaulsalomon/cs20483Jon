using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class TiposPorValorIntegral
    {
        public void Executa()
        {
            Console.WriteLine("Tipos por valor");

            Console.WriteLine("Tipos Integrais:");

            char letra = 'a';
            Console.WriteLine($"Tipo Char:{Char.MinValue} - {char.MaxValue}");

            byte num_byte = 255;            
            Console.WriteLine($"Tipo Byte:{Byte.MinValue} - {byte.MaxValue}");
            
            sbyte num_sbyte = 127;
            Console.WriteLine($"Tipo SByte:{SByte.MinValue} - {sbyte.MaxValue}");

            short num_short = 32_000;
            Console.WriteLine($"Tipo Short:{Int16.MinValue} - {short.MaxValue}");

            ushort num_ushort = 64_000;
            Console.WriteLine($"Tipo UShort:{UInt16.MinValue} - {ushort.MaxValue}");

            int numero = 2147483647;
            Console.WriteLine($"Tipo inteiro:{Int32.MinValue} - {int.MaxValue}" );
            
            uint numero_uint = 4_294_967_295;           
            Console.WriteLine($"Tipo uinteiro:{UInt32.MinValue} - {uint.MaxValue}");

            long num_long = 9_223_372_036_854_775_807;
            Console.WriteLine($"Tipo long:{Int64.MinValue} - {long.MaxValue}");
            ulong num_ulong = 18_446_744_073_709_551_615;
            Console.WriteLine($"Tipo ulong:{UInt64.MinValue} - {ulong.MaxValue}");

            //tamanho ultrapassa os integrais
            //ulong num_massa_terra = 5_972_200_000_000_000_000_000_000;
            
        }

    }
}

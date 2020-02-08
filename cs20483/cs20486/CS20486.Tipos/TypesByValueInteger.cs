using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20486.Tipos
{
    public class TypesByValueInteger
    {
        public void Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("****** Tipos Integrais:");// Inteiros

            char letra = 'a';
            Console.WriteLine($"letra: {letra}");
            Console.WriteLine($"char: min:{char.MinValue} max:{char.MaxValue}");

            byte num_byte = 255;
            Console.WriteLine($"byte: min:{Byte.MinValue} max:{Byte.MaxValue}");

            sbyte num_sbyte = 127;
            Console.WriteLine($"sbyte: min:{SByte.MinValue} max:{SByte.MaxValue}");

            short num_short = 32_767;
            Console.WriteLine($"short: min:{Int16.MinValue} max:{short.MaxValue}");    
            
            ushort num_ushort = 65535;
            Console.WriteLine($"ushort : min:{UInt16.MinValue} max:{ushort.MaxValue}");

            int num_int = 2147483647;
            Console.WriteLine($"int: min:{Int32.MinValue} max:{Int32.MaxValue}");

            uint num_uint = 4294967295;
            Console.WriteLine($"uint: min:{UInt32.MinValue} max:{UInt32.MaxValue}");

            long num_long = 9223372036854775807;
            Console.WriteLine($"long: min:{Int64.MinValue} max:{long.MaxValue}");

            ulong num_ulong = 18446744073709551615;
            Console.WriteLine($"ulong: min:{UInt64.MinValue} max:{ulong.MaxValue}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula1.TiposPorValor
{
    public class NumerosInteiros
    {
        public void Executar()
        {
           

            // --- Tipo 1 de Numero Inteiro - Byte = Armazena 1 Byte que representa 8 bits que vai de 0-255
            // --- Declaração de byte do tipo C#
            byte idade1 = 18;
            // --- Declaração de Byte do tipo .Net atribuindo um valor em Hexadecimal
            System.Byte idade2 = 0x12;
            // --- Impressão do valor da variável contendo o valor em Hexadecimal que representa o 18 em decimal
            Console.WriteLine($"Impressão de variável byte : {idade2}");
            Console.WriteLine($"Menor valor armazenado {byte.MinValue}");
            Console.WriteLine($"Maior valor armazenado {byte.MaxValue}");

            // --- Tipo 2 de Numero Inteiro - SByte = Variação com sinal do tipo Byte, Armazena 1 Byte que representa 8 bits que vai de -128-127
            // --- Declaração de sbyte do tipo C#
            byte idade3 = 18;
            // --- Declaração de SByte do tipo .Net atribuindo um valor em Hexadecimal
            System.SByte idade4 = 0x12;
            // --- Impressão do valor da variável contendo o valor em Hexadecimal que representa o 18 em decimal
            Console.WriteLine($"Impressão de variável sbyte : {idade4}");
            Console.WriteLine($"Menor valor armazenado {sbyte.MinValue}");
            Console.WriteLine($"Maior valor armazenado {sbyte.MaxValue}");

            // --- Tipo 3 de Numero Inteiro - Char, armazena caracteres, porém internamente armazena um numnero com 2 Bytes
            char letra1 = 'M';
            System.Char letra2 = 'D';
            // --- Convertendo um numero para char de acordo com a tebela ASCII
            // --- O número 77 representa a letra 'M' em maiúsculo na tabela ASCII
            char letra1Numero = (char)77;
            // --- Impressão da variável char após a conversão 
            Console.WriteLine($"Impressão de variável char : {letra1Numero}");
            Console.WriteLine($"Menor valor armazenado {Convert.ToInt32(char.MinValue)}");
            Console.WriteLine($"Maior valor armazenado {Convert.ToInt32(char.MaxValue)}");

            // --- Tipo 4 de Numero Inteiro - Short = Armazena 2 Bytes que representa 16 bits que vai de -32768-32767 permitindo negativos
            // --- Declaração de Short do tipo C#
            short projetos1 = 1650;
            // --- Declaração de Short do tipo .Net 
            System.Int16 projetos2 = 1760;
            // --- Impressão da variável short
            Console.WriteLine($"Impressão de variável short : {projetos2}");
            Console.WriteLine($"Menor valor armazenado {short.MinValue}");
            Console.WriteLine($"Maior valor armazenado {short.MaxValue}");

            // --- Tipo 5 de Numero Inteiro - UShort = Que é uma variação sem sinal do Short, Armazena 2 Bytes que representa 16 bits que vai de 0-65535 permitindo negativos
            // --- Declaração de UShort do tipo C#
            short projetos3 = 1650;
            // --- Declaração de UShort do tipo .Net 
            System.UInt16 projetos4 = 1760;
            // --- Impressão da variável ushort
            Console.WriteLine($"Impressão de variável ushort : {projetos4}");
            Console.WriteLine($"Menor valor armazenado {ushort.MinValue}");
            Console.WriteLine($"Maior valor armazenado {ushort.MaxValue}");

            // --- Tipo 6 de Numero Inteiro - Int = Armazena 4 Bytes que representa 32 bits que vai de -2147483648-2147483647 permitindo negativos
            // --- Declaração de Int do tipo C# usando '_' para separação de milhar
            // --- Esta separação é ignorada pelo c#, ficando apenas visual para o programador
            int funcionarios1 = 60_400;
            // --- Declaração de Int do tipo .Net 
            System.Int32 funcionarios2 = 1_120_000;
            // --- Impressão da variável int
            Console.WriteLine($"Impressão de variável int : {funcionarios2}");
            Console.WriteLine($"Menor valor armazenado {int.MinValue}");
            Console.WriteLine($"Maior valor armazenado {int.MaxValue}");

            // --- Tipo 7 de Numero Inteiro - UInt = Variação sem sinal do tipo Int Armazena 4 Bytes que representa 32 bits que vai de 0-4294967295 permitindo negativos
            int funcionarios3 = 60_400;
            // --- Declaração de UInt do tipo .Net 
            System.UInt32 funcionarios4 = 1_120_000;
            // --- Impressão da variável uint
            Console.WriteLine($"Impressão de variável uint : {funcionarios4}");
            Console.WriteLine($"Menor valor armazenado {uint.MinValue}");
            Console.WriteLine($"Maior valor armazenado {uint.MaxValue}");

            // --- Tipo 8 de Numero Inteiro - Long = Armazena 8 Bytes que representa 64 bits que vai de -9223372036854775808-9223372036854775807 permitindo negativos
            // --- Declaração de Long do tipo C#
            long populacao1 = 3_560_080;
            // --- Declaração de Long do tipo .Net 
            System.Int64 populacao2 = 20_789_524;
            // --- Impressão da variável long
            Console.WriteLine($"Impressão de variável long : {populacao2}");
            Console.WriteLine($"Menor valor armazenado {long.MinValue}");
            Console.WriteLine($"Maior valor armazenado {long.MaxValue}");

            // --- Tipo 9 de Numero Inteiro - ULong = Variação sem sinal do tipo Long, Armazena 8 Bytes que representa 64 bits que vai de 0-18446744073709551615 permitindo negativos
            // --- Declaração de Long do tipo C#
            long populacao3 = 3_560_080;
            // --- Declaração de ULong do tipo .Net 
            System.UInt64 populacao4 = 20_789_524;
            // --- Impressão da variável ulong
            Console.WriteLine($"Impressão de variável ulong : {populacao4}");
            Console.WriteLine($"Menor valor armazenado {ulong.MinValue}");
            Console.WriteLine($"Maior valor armazenado {ulong.MaxValue}");



        }
    }
}

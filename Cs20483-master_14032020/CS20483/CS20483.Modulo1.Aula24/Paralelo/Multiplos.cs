using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula24.Paralelo
{
    public class Multiplos
    {
        public void Executa()
        {
            System.Console.WriteLine("Chamdas paralelas multiplas");
            ChamdaSequencial();
            ChamadaParalela();


        }

        public void ChamdaSequencial()
        {
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            System.Console.WriteLine("\n chamado de forma sequencial" );
            for (int i = 1; i < 50000; i++)
            {
                Infecta.Coronga(i);
            }
            sw2.Stop();
            var tempo1 = sw2.ElapsedMilliseconds;
            Console.WriteLine($"************************************************Executando coronga em  Sequencial em: {tempo1} ms ");
            Console.WriteLine();
        }
        public void ChamadaParalela()
        {
            System.Console.WriteLine("\n chamado de forma paralela");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Parallel.For(1, 50000, (i) => Infecta.Coronga(i));
            sw2.Stop();
            var tempo1 = sw2.ElapsedMilliseconds;
            Console.WriteLine($"Executando Coronga em paralelo em: {tempo1} ms ");
            Console.WriteLine();
        }
    }
}

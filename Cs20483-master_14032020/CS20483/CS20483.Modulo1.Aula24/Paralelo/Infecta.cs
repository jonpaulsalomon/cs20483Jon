using System;

namespace CS20483.Modulo1.Aula24.Paralelo
{
    public static class Infecta
    {
        public static void Coronga()
        {
            Console.WriteLine("Infectando com o Coronga ...");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Infectado Coronga");
        }

        public static void HIVA()
        {
            Console.WriteLine("Infectando com HIVA ...");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("Infectado HIVA");
        }

        public static void Coronga(int pessoa)
        {
            Console.WriteLine($"Infectando pessoa {pessoa} com coronga...");            
        }

        public static void HIVA(int pessoa)
        {
            Console.WriteLine($"Infectando pessoa {pessoa} com HIVA...");
        }
    }
}

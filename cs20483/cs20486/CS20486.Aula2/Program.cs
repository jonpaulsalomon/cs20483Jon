using System;

namespace CS20483.Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParteUm.Execute();
            //ParteDois.Execute();
            //ParteTres.Executa();
            //ParteQuatro.Execute();
            float asd = 12.6595f;

            teste(asd);

            Console.ReadKey();
        }

        public static void teste(float teste )
        {
            object degreesRef = teste;

            int result = (int)(float)teste;

            Console.WriteLine(result);
        }
    }
}

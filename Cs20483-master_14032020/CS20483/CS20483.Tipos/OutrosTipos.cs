using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class OutrosTipos : Aulas
    {
        public void Executa()
        {
            Console.WriteLine("Outros tipos por valor");
            Console.WriteLine("Boolean");
            bool deMaior = true;
            bool deMenor = false;
            byte n1 = 10;
            byte n2 = 2;
            bool par = (n1 % n2 == 0);
            Console.WriteLine($"O resto da divisao entre {n1} e {n2} é {(n1 % n2)}");
            Console.WriteLine($"É zero {par}");

            DiasDaSemana diasTrabalho = (DiasDaSemana)28;
            Console.WriteLine(diasTrabalho);
            char letra = (char)74;
            Console.WriteLine($"Char {letra == 74}");



        }
    }
    [Flags]
    enum DiasDaSemana 
    {
        domingo = 1,
        segunda = 2,
        terca = 4,
        quarta = 8,
        quinta = 16,
        sexta = 32,
        sabado = 64,
    }
}

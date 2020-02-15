using System;

namespace CS20483.Aula2
{
    public class LegalPerson : Person
    {
        // substituicao de metodos
        public override void Print()
        {
            Console.WriteLine("Imprimindo Pessoa Juririca");
        }

        //public new void Print()
        //{
        //    Console.WriteLine("Imprimindo Pessoa Juririca");
        //}
    }
}

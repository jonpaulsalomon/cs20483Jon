using System;

namespace CS20483.Aula9
{
    partial class Program
    {
        public class Pessoa
        {
            private int id;
            public Pessoa(int id)
            {
                this.id = id;

                System.Console.WriteLine($"Criou uma Pessoa id: {this.id}");

                GC.Collect();
            }

            ~Pessoa()
            {
                System.Console.WriteLine($"Destruindo uma Pessoa id: {this.id}");
            }

        }
    }
}

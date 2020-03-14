using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula09._2_ColetorDeLixo
{
    public class Finalizadores
    {
        public void Executa()
        {
            for (int i = 0; i < 10; i++)
            {
                new Pessoa { Nome = "p"+i};
            }
            
            GC.Collect();
        }
    }
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            Trace.WriteLine($"Criando pessoa {this.Nome}");
        }
        ~Pessoa()
        {
            Trace.WriteLine($"Finalizando pessoa {this.Nome}");
        }
    }
}

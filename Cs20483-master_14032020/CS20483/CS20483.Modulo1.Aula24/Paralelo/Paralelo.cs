using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula24.Paralelo
{
    public class Paralelo
    {
        public void Executa()
        {
            ChamadaSequencial1();
            Console.WriteLine();
            ChamadaParalela();
        }

        public void ChamadaParalela()
        {
            Console.WriteLine("Chamda de metodo paralelo");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.Invoke(
                () => infectandoCoronga(),
                () => infectandoHIVA()
            );
            sw.Stop();
            var tempo = sw.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Executando tramissões em paralelo com sucesso em: {tempo} s");
        }

        private void ChamadaSequencial1()
        {
            Console.WriteLine("Chamda de metodo sequencial");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            infectandoCoronga();
            infectandoHIVA();
            sw.Stop();
            var tempo = sw.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Executando tramissões com sucesso em: {tempo} s");
        }

        private void infectandoCoronga()
        {
            Console.WriteLine("Infectando com o Coronga ...");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Infectado Coronga");
        }

        private void infectandoHIVA()
        {
            Console.WriteLine("Infectando com HIVA ...");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("Infectado HIVA");
        }
    }
}

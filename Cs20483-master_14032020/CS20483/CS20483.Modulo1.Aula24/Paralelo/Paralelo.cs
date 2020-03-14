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
                () => Infecta.Coronga(),
                () => Infecta.HIVA()
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
            Infecta.Coronga();
            Infecta.HIVA();
            sw.Stop();
            var tempo = sw.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Executando tramissões com sucesso em: {tempo} s");
        }
    }
}

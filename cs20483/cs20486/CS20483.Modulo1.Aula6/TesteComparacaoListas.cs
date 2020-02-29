using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6
{
    public class TesteComparacaoListas
    {
        public void Executa()
        {
            List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();
            PessoaJuridica pj1 = new PessoaJuridica { Cnpj = "50", Nome = "a", Nascimento = new DateTime(1950, 05, 2) };
            PessoaJuridica pj2 = new PessoaJuridica { Cnpj = "40", Nome = "b", Nascimento = new DateTime(1975, 05, 2) };
            PessoaJuridica pj3 = new PessoaJuridica { Cnpj = "30", Nome = "c", Nascimento = new DateTime(1970, 05, 2) };

            listaPJ.Add(pj1);
            listaPJ.Add(pj2);
            listaPJ.Add(pj3);

            listaPJ.Sort();
            listaPJ.OrderByDescending(pj => pj.Cnpj);

            foreach (var item in listaPJ)
            {
                Console.WriteLine(item);
            }        
        }
    }
}

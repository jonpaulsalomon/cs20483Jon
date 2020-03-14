using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6.HierarquiaClasse
{
    public class TesteComparacaoListas
    {
        public void Executa()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();
            PessoaJuridica pj1 = new PessoaJuridica { Nome="Proway", Nascimento = new DateTime(2020,01,01), Cnpj="05355613232" };
            PessoaJuridica pj2 = new PessoaJuridica { Nome = "Empresa2", Nascimento = new DateTime(2018, 01, 01), Cnpj = "154653356000198" };
            PessoaJuridica pj3 = new PessoaJuridica { Nome = "Empresa3", Nascimento = new DateTime(2019, 01, 01), Cnpj = "251555552000139" };
            listaPj.Add(pj1);
            listaPj.Add(pj2);
            listaPj.Add(pj3);

            // Os objetos da lista devem implementar a interface IComparable
            // listaPj.Sort();

            foreach (var item in listaPj.Where( pj => pj.Nome == "Proway" ))
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(listaPj.First(pj=));
        }
    }
}

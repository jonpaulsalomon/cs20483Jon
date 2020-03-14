using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6.HierarquiaClasse
{
    public class TesteComparacao
    {
        public void Executa()
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Cpf = "053.065.089-78";
            pf.Nome = "Maykon";
            pf.Nascimento = new DateTime(2002, 11, 05);

            PessoaFisica pf2 = new PessoaFisica();
            pf2.Cpf = "053.065.089-78";
            pf2.Nome = "Maykon";
            pf2.Nascimento = new DateTime(2002, 11, 05);

            PessoaFisica pf3 = pf2;

            if (pf.Equals(pf2))
            {
                Console.WriteLine("pf e pf2 Igual");
            }
            else
            {
                Console.WriteLine("pf e pf2 Diferente");
            }

            if (pf2.Equals(pf3))
            {
                Console.WriteLine("pf2 e pf3 Igual");
            }
            else
            {
                Console.WriteLine("pf2 e pf3 Diferente");
            }

        }
    }
}

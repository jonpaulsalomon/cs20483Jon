using System;

namespace CS20483.Modulo1.Aula6
{
    public class TesteComparacao
    {
        public void Executa()
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Cpf = "00989287873";
            pf.Nome = "Jon";
            pf.Nascimento = new DateTime(1999,05,2);
            
            PessoaFisica pf2 = new PessoaFisica();
            pf2.Cpf = "00989287873";
            pf2.Nome = "Jon";
            pf2.Nascimento = new DateTime(1999, 05, 2);

            if (pf.Equals(pf2))
            {
                Console.WriteLine("pf e pf2 é igual");
            }
            else
            {
                Console.WriteLine("pf e pf2 não é igual");
            }

        }
    }

}

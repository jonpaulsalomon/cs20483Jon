using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class UsandoTipos2 : Aulas
    {
        public void Executa()
        {
            Console.WriteLine("Usuando tipos - conversoes");
            PessoaFisica pf = new PessoaFisica { Nome = "Maykon", DataNascimento= DateTime.Now }; 
            PessoaJuridica pj = new PessoaJuridica { CNPJ = "15.463.356/0001-99"};
            //PessoaBase p = pf;
            PessoaBase p2 = pj;
            pj = (PessoaJuridica)p2;

            Console.WriteLine($"pj{pj.CNPJ}");
        }
    }
    public class PessoaBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nome:{this.Nome},Data de Nascimento {this.DataNascimento} ");
        }
    }
    public class PessoaFisica : PessoaBase
    {
        public string CPF { get; set; }

    }
    public class PessoaJuridica : PessoaBase
    {
        public string CNPJ { get; set; }
    }
}

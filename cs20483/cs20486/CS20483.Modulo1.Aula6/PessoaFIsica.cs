using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public override bool Equals(object obj)
        {
            PessoaFisica outraPessoa = (PessoaFisica)obj;

            return base.Equals(outraPessoa) && this.Cpf.Equals(outraPessoa.Cpf) ;
        }
    }

}

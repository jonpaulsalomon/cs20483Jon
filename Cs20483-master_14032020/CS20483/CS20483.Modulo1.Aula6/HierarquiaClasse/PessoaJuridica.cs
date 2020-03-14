using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6.HierarquiaClasse
{
    sealed class PessoaJuridica : Pessoa , IComparable
    {
        public string Cnpj { get; set; }

        public string Atualizar()
        {
            // Acessando um metodo protected, so acessivel por classe herdada
            return this.Cadastrar();
        }
        public override string ToString()
        {
            return $"{this.Nome} - {this.Nascimento} - {this.Cnpj}";
        }
        public int CompareTo(object obj)
        {
            PessoaJuridica outraPj = (PessoaJuridica)obj;
            int classificacao = 0;
            if ( this.Nascimento.Equals(outraPj.Nascimento) )
            {
                classificacao = 0;
            }
            else if(this.Nascimento > outraPj.Nascimento)
            {
                classificacao = 1;
            }
            else
            {
                classificacao = -1;
            }
            return classificacao;
        }
    }
}

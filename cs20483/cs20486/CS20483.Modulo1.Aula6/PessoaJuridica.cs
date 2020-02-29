using System;

namespace CS20483.Modulo1.Aula6
{
    sealed class PessoaJuridica : Pessoa, IComparable
    {
        public string Cnpj { get; set; }

        public string Atualizar()
        {
            return this.Cadastrar();
        }

        public override bool Equals(object obj)
        {
            PessoaJuridica outraPessoa = (PessoaJuridica)obj;

            return base.Equals(outraPessoa) && this.Cnpj.Equals(outraPessoa.Cnpj);
        }

        public override string ToString()
        {
            return $"Nome:{this.Nome} , Nascimento {this.Nascimento}, CNPJ {this.Cnpj}";
        }

        public int CompareTo(object obj)
        {
            PessoaJuridica outraPessoa = (PessoaJuridica)obj;
            int classificacao = 0;

            if (this.Nascimento.Equals(outraPessoa.Nascimento))
            {
                classificacao = 0;
            }
            else if (this.Nascimento > outraPessoa.Nascimento)
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

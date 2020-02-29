using System;

namespace CS20483.Modulo1.Aula6
{
    public abstract class Pessoa
    {
        public DateTime Nascimento { get; set; }
        public string Nome { get; set; }
        
        // Private -> protected -> internal -> public
        protected string Cadastrar()
        {
            return $"Pessoa {this.Nome} cadastrada";
        }

        public override bool Equals(object obj)
        {
            PessoaFisica outraPessoa = (PessoaFisica)obj;

            return this.Nome.Equals(outraPessoa.Nome);
        }
    }

}

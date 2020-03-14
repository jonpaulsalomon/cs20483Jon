using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6.HierarquiaClasse
{
    abstract class Pessoa
    {
        public DateTime Nascimento { get; set; }
        public string Nome { get; set; }
        // private -> protected -> internal -> public
        protected string Cadastrar()
        {
            return $"Pessoa {this.Nome} cadastrada";
        }

        public override bool Equals(object obj)
        {
            Pessoa outraPessoa = (Pessoa)obj;
            return this.Nome.Equals(outraPessoa.Nome);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula5.Encapsulamento
{
    class Pessoa
    {

        private byte idade;

        //public void SetIdade(byte idade)
        //{
        //    if (idade > 0)
        //        this.idade = idade;
        //    else
        //        throw new ArgumentOutOfRangeException("Idade não pode ser igual a zero");
        //}
        //public byte GetIdade()
        //{
        //    return this.idade;
        //}

        //public byte Idade
        //{
        //    get 
        //    { 
        //        return this.idade;
        //    }
        //    set 
        //    {
        //        if (value > 0)
        //            this.idade = value;
        //        else
        //            throw new ArgumentOutOfRangeException("Idade não pode ser igual a zero");
        //    }
        //}
        public byte Idade
        {
            get
            {
                return this.idade;
            }
            private set
            {
                if (value > 0)
                    this.idade = value;
                else
                    throw new ArgumentOutOfRangeException("Idade não pode ser igual a zero");
            }
        }
        // Somente leitura
        public int Id { get; }
        // == Propriedade auto-declarada
        public string Nome { get; set; }

        public Pessoa(byte idade)
        {
            this.Idade = idade;
        }
    }
}

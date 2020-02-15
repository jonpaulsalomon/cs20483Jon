using System;
using System.Collections.Generic;
using System.Text;

namespace CS20483.Aula2
{
    class SalaAula
    {
        public Pessoa this[string chave]
        {
            get
            {
                return this.assentos[chave];
            }
            set
            {
                assentos.Add(chave, value);
            }
        }

        private IDictionary<string, Pessoa> assentos = new Dictionary<string, Pessoa>();
    }
}

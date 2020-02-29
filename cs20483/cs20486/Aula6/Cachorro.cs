using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Aula6
{
    class Cachorro : IAnimal, IDomestico
    {
        public byte Idade { get; set; }
        public string Cor { get; set; }
        public string Sexo { get; set; }
        public string Apelido { get; set; }
        string IDomestico.Apelido { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IAnimal.Comer()
        {
            throw new NotImplementedException();
        }
        
        void IDomestico.Comer()
        {
            throw new NotImplementedException();
        }

        public void Dormir()
        {

        }
                }
}

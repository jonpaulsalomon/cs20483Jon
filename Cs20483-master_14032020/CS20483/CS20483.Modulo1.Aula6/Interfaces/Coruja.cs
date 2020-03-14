using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6.Interfaces
{
    class Coruja : IAnimal
    {
        public byte Idade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Cor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sexo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Comer()
        {
            throw new NotImplementedException();
        }

        public void Dormir()
        {
            throw new NotImplementedException();
        }
    }
}

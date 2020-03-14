using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula6.Interfaces
{
    class Cachorro : IAnimal, IAnimalDomestico
    {
        public byte Idade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Cor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sexo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Apelido { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Interface Explicita - 
        // Deve ser convertido o objeto para o tipo da interface para chamar o método
        void IAnimal.Comer()
        {
            Console.WriteLine("Animal Comendo");
        }
        // Interface Explicita
        // Deve ser convertido o objeto para o tipo da interface para chamar o método
        void IAnimalDomestico.Comer()
        {
            Console.WriteLine("Domestico Comendo");
        }

        public void Dormir()
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace CS20483.Modulo1.Aula12.ConverterJson
{
    [Serializable]
    public class Funcionario
    {
        public string Nome{ get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
    }
}

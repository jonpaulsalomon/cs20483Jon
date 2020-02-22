namespace CS20483_Exercicio.Domain.Entities
{
    public class PessoaFisica : Pessoa
    {
        public string Sobrenome { get; set; }

        // --- Popriedade do tipo Byte ( 0 - 255)
        public byte Idade { get; set; }

        public string Rg { get; set; }

        public string Cpf {get;set;}
    }
}

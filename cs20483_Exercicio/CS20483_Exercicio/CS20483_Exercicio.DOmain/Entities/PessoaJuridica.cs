namespace CS20483_Exercicio.Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public string InscricaoEstadual { get; set; }
    }
}

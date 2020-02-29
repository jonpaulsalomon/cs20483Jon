namespace CS20483.Aula6
{
    class Gato : IAnimal,  IDomestico
    {
        public byte Idade { get; set; }
        public string Cor { get; set; }
        public string Sexo { get; set; }
        public string Apelido { get; set; }

        public void Comer()
        {

        }
        public void Dormir()
        {

        }
    }
}

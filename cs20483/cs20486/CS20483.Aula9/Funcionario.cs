namespace CS20483.Aula9
{
    public class Funcionario
    {
        public decimal CalculaSalarioLiqueido(decimal salarioBruto)
        {
            return CalculaDescontos(salarioBruto);
        }

        private decimal CalculaDescontos(decimal salarioBruto)
        {
            decimal salarioComDescontos = salarioBruto - 10.0m;

            return CalculaINSS(salarioComDescontos);
        }

        private decimal CalculaINSS(decimal salarioDesconto)
        {

            decimal salarioINSS = salarioDesconto * 0.92m;
            return CalculaIRPF(salarioINSS);
        }

        private decimal CalculaIRPF(decimal salarioInss)
        {
            return  salarioInss * 0.89m;
        }
    }
}

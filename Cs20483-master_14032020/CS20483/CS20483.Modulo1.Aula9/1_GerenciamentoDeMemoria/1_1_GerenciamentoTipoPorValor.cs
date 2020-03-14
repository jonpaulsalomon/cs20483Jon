using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula09._1_GerenciamentoDeMemoria
{
    public class GerenciamentoTipoPorValor
    {
        public void Executa()
        {
            // --- Ponto de parada para analise da montagem e desmontagem da pilha
            // --- Acesso ao gerenciador de pilha : Menu-> Depurar -> Janelas -> Pilhas de Chamadas
            decimal salarioBruto = 1_100M;
            decimal descontos = 50.55M;
            decimal salarioLiquido  = CalculoDescontos(salarioBruto, descontos);
            // --- Impressão do salário usando interpolação de strings e tambem formatação para currency com dusa casas decimais
            Console.WriteLine($"Salario liquido impresso depois da execução em pilha: R$ { salarioLiquido.ToString("c2")}");
        }
        private decimal CalculoDescontos(decimal salarioBruto, decimal descontos)
        {
            decimal salarioDescontos = salarioBruto - descontos;
            decimal salarioLiquido = CalculoInss(salarioDescontos);
            return salarioLiquido;
        }

        private decimal CalculoInss(decimal salarioDescontos)
        {
            decimal salarioDecontadoInss = salarioDescontos * 0.92M;
            decimal salarioDescontoIss = CalculoIss(salarioDecontadoInss);
            return salarioDescontoIss;
        }
        private decimal CalculoIss(decimal salarioDecontadoInss)
        {
            decimal salarioDescontadoIss = salarioDecontadoInss;
            return salarioDescontadoIss;
        }
    }
}

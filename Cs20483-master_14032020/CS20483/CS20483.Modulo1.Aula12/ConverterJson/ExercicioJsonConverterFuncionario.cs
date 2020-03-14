using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula12.ConverterJson
{
    public class ExercicioJsonConverterFuncionario
    {
        private JsonConverter jsonConverter;
        public ExercicioJsonConverterFuncionario()
        {
            jsonConverter = new JsonConverter();
        }
        public void Executa()
        {
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Console.WriteLine("Exercicio para Serialização de Objetos para Json");
            Console.WriteLine("________________________________________________");
            var funcionarios = new List<Funcionario>()
            {
                new Funcionario() {Cpf="00956568748",Nome="Natalino",Sobrenome="Arantes"},
                new Funcionario() {Cpf="45646546546",Nome="Elvaclir",Sobrenome="Schultz"},
                new Funcionario() {Cpf="44856545780",Nome="Adrinalda",Sobrenome="Peneira"},
                new Funcionario() {Cpf="05487520056",Nome="Uoxintom",Sobrenome="Dos Santos"}
            };
            Console.WriteLine();

            string json = jsonConverter.Serializa(funcionarios);
            jsonConverter.SalvarJsonArquivo(json,"funcionarios");

            string jsonArq = jsonConverter.LerArquivoJson("funcionarios");
            var listaDeserealizada = jsonConverter.Deserializa(jsonArq);

            Console.WriteLine();
            Console.WriteLine("Imprimindo deserealizado:");
            foreach (var funcionario in listaDeserealizada)
            {
                Console.WriteLine($"CPF: {funcionario.Cpf} - Nome:{funcionario.Nome} {funcionario.Sobrenome}");
            }
            sw2.Stop();
            var tempo1 = sw2.ElapsedMilliseconds ;
            Console.WriteLine($"Executando Deserializa normal em: {tempo1} ");

            Stopwatch sw = new Stopwatch();
            sw.Start();



            Console.WriteLine("Imprimindo BINARIO deserealizado:");
            Console.WriteLine();
            Console.WriteLine("Json Binario");
            Console.WriteLine();
            //Chamar um metodo de converaso para binario
                        
            jsonConverter.ConverterParaBinario(funcionarios, "funcionarios.bin");
            var deserealizado = jsonConverter.DeserealizaParaBinario("funcionarios.bin");
            Console.WriteLine();
            
            foreach (var funcionario in listaDeserealizada)
            {
                Console.WriteLine($"CPF: {funcionario.Cpf} - Nome:{funcionario.Nome} {funcionario.Sobrenome}");
            }
            sw.Stop();
            var tempo2 = sw.ElapsedMilliseconds ;
            Console.WriteLine($"Executando DeserealizaParaBinario em: {tempo2} ");
            //salvar o arquivo em formato binario

            //Ler o arquivo em formato binario
            //Converter de binario para objeto 



        }
    }
}

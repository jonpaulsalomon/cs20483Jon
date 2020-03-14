using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CS20483.Modulo1.Aula12.ConverterJson
{
    public class JsonConverter
    {
        //Install-Package Newtonsoft.Json
        public void Executa()
        {
            Console.WriteLine("Serialização de Objetos para Json");

            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome="Maykon", Sobrenome="Granemann", Idade=17 },
                new Pessoa { Nome="Dyego", Sobrenome="Rauen", Idade=17 },
                new Pessoa { Nome="Zé", Sobrenome="DasCoves", Idade=17 }
            };

            string json = Serializa(pessoas);
            SalvarJsonArquivo(json);

            string jsonArq = LerArquivoJson();
            var listaPessoas = Deserializa(jsonArq);

            Console.WriteLine("Imprimindo pessoas vindas do arquivo Json");
            foreach (var item in listaPessoas)
            {
                Console.WriteLine($"{item.Nome} - {item.Sobrenome} - {item.Idade}");
            }
        }

        private string LerArquivoJson()
        {
            string json;
            using (var sr = new StreamReader("Pessoas.json"))
            {
                json = sr.ReadToEnd();
            }
            return json;
        }

        private static void SalvarJsonArquivo(string json)
        {
            Console.WriteLine(json);
            using (var sw = new StreamWriter("Pessoas.json"))
            {
                Console.WriteLine("Gravando Json...");
                sw.Write(json);
            }
        }

        string Serializa(List<Pessoa> lista)
        {     
            string pessoaJson = JsonConvert.SerializeObject(lista);
            return pessoaJson;
        }
        List<Pessoa> Deserializa(string json)
        {
            var objetos = JsonConvert.DeserializeObject<List<Pessoa>>(json);
            return objetos;
        }
    }
}

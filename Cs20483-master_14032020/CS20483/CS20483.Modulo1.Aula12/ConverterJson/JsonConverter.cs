using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CS20483.Modulo1.Aula12.ConverterJson
{
    public class JsonConverter
    {
        public string LerArquivoJson(string nomeArquivo)
        {
            string json;
            using (var sr = new StreamReader($"{nomeArquivo}.json"))
            {
                json = sr.ReadToEnd();
            }
            return json;
        }

        public void SalvarJsonArquivo(string json,string nomeArquivo)
        {
            Console.WriteLine("**** JSON:");
            Console.WriteLine(json);
            Console.WriteLine();
            using (var sw = new StreamWriter($"{nomeArquivo}.json"))
            {
                sw.Write(json);
            }
        }

        public string Serializa(IEnumerable<object> lista)
        {
            string jsonObjectList = JsonConvert.SerializeObject(lista);
            return jsonObjectList;
        }
        public List<Funcionario> Deserializa(string json)
        {
            var objetos = JsonConvert.DeserializeObject<List<Funcionario>>(json);
            return objetos;
        }
    }
}

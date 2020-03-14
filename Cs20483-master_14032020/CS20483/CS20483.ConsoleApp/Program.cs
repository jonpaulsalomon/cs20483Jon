
using CS20483.Modulo1.Aula09._1_GerenciamentoDeMemoria;
using CS20483.Modulo1.Aula09._2_ColetorDeLixo;
using CS20483.Modulo1.Aula1.TiposPorValor;
using CS20483.Modulo1.Aula12.ConverterJson;
using CS20483.Modulo1.Aula6.HierarquiaClasse;
using CS20483.Modulo1.Aula8;
using CS20483.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curso 20483");

            //NumerosInteiros nI = new NumerosInteiros();
            //nI.Executar();

            //PontoFlutuante pF = new PontoFlutuante();
            //pF.Executar();

            //Booleanos bo = new Booleanos();
            //bo.Executar();

            //Estruturas es = new Estruturas();
            //es.Executar();

            //Enumeradores en = new Enumeradores();
            //en.Executar();

            //TiposVR tipos = new TiposVR();
            ////tipos.Executa();
            //TiposPorValorIntegral tp = new TiposPorValorIntegral();
            ////tp.Executa();
            //TiposValorFlutuante tf = new TiposValorFlutuante();
            ////tf.Executa();
            //Structs estruturas = new Structs();
            ////estruturas.Executa();
            //TipoReferencia tr = new TipoReferencia();
            ////tr.Executa();
            //UsandoTipos ut = new UsandoTipos();
            ////ut.Execute();

            //UsandoTipos2 ot2 = new UsandoTipos2();
            //ot2.Executa();

            //Delegados delegado = new Delegados();
            ////delegado.Executa();


            //GerenciamentoTipoPorValor gTV = new GerenciamentoTipoPorValor();
            //gTV.Executa();

            //GerenciamentoTipoPorReferencia gTR = new GerenciamentoTipoPorReferencia();
            //gTR.Executa();

            //Finalizadores fn = new Finalizadores();
            //fn.Executa();

            //TesteComparacao t = new TesteComparacao();
            //t.Executa();

            //TesteComparacaoListas tcl = new TesteComparacaoListas();
            //tcl.Executa();

            //CS20483.Modulo4.Aula13.Eventos.Delegados delegados = new Modulo4.Aula13.Eventos.Delegados();
            //delegados.Executa();

            //Modulo4.Aula13.Eventos.Evento evento = new Modulo4.Aula13.Eventos.Evento();
            //evento.Executa();

            //Modulo4.Aula13.Eventos.ExChat.ChatDoTerra chatDoTerra = new Modulo4.Aula13.Eventos.ExChat.ChatDoTerra();
            //chatDoTerra.Executa();

            //JsonConverter jsonConverter = new JsonConverter();
            //jsonConverter.Executa();

            //ExercicioJsonConverterFuncionario exercicioJsonConverterFuncionario = new Modulo1.Aula12.ConverterJson.ExercicioJsonConverterFuncionario();
            //exercicioJsonConverterFuncionario.Executa();

            CapturarETratamento capturarETratamento = new CapturarETratamento();
            capturarETratamento.Executa();

            Console.ReadKey();
        }
    }
}

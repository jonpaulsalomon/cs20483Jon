using CS20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483_Exercicio.Data.Context
{
    public class Cs20483Context : DbContext
    {
        // Propriedade do tipo DbSet que gerará nova tabela no banco de dados
        // A tabela será gerada de acordo com as propriedades da classe de dominio 
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }

        public Cs20483Context()
            : base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\47478\Desktop\JonathanSalomon\Curso Microsoft\cs20483_Exercicio\CS20483_Exercicio\CS20483_Exercicio.Data\DataBase\Cs20483DataBase.mdf;Integrated Security = True")
        {
        }
    }
}

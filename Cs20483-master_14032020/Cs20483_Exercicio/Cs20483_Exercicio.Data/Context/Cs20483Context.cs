using Cs20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Data.Context
{
    public class Cs20483Context : DbContext
    {
        // --- Propriedade do tipo DbSet irá gerar uma nova tabela no bando de dados
        // --- A tabela será gerada de acordo com as propriedades da classe de dominio
        public DbSet<Produto> Produto { get; set; }

        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }


        public Cs20483Context():base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\maykon.granemann\Documents\Github\Cs20483\Cs20483_Exercicio\Cs20483_Exercicio.Data\Database\Cs20483DataBase.mdf;Integrated Security = True")
        {
            
        }
    }
}

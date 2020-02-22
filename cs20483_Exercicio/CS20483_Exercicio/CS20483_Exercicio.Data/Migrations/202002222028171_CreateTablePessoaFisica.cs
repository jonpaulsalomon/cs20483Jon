namespace CS20483_Exercicio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePessoaFisica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaFisicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sobrenome = c.String(),
                        Idade = c.Byte(nullable: false),
                        Rg = c.String(),
                        Cpf = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PessoaFisicas");
        }
    }
}

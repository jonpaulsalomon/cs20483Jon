namespace Cs20483_Exercicio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProdutoEEstoque : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estoques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Short(nullable: false),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        PrecoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Codigo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoques", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.Estoques", new[] { "Produto_Id" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Estoques");
        }
    }
}

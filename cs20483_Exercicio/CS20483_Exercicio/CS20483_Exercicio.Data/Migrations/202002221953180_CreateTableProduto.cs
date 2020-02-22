﻿namespace CS20483_Exercicio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nome = c.String(),
                        Descricao = c.String(),
                        PrecoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtoes");
        }
    }
}

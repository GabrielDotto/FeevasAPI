namespace FeevasApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Banco_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Direitos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Senha = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Acao = c.String(),
                        Data = c.DateTime(nullable: false),
                        Usuario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_ID)
                .Index(t => t.Usuario_ID);
            
            CreateTable(
                "dbo.UsuarioDireitos",
                c => new
                    {
                        Usuario_ID = c.Int(nullable: false),
                        Direitos_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_ID, t.Direitos_ID })
                .ForeignKey("dbo.Usuarios", t => t.Usuario_ID, cascadeDelete: true)
                .ForeignKey("dbo.Direitos", t => t.Direitos_ID, cascadeDelete: true)
                .Index(t => t.Usuario_ID)
                .Index(t => t.Direitos_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "Usuario_ID", "dbo.Usuarios");
            DropForeignKey("dbo.UsuarioDireitos", "Direitos_ID", "dbo.Direitos");
            DropForeignKey("dbo.UsuarioDireitos", "Usuario_ID", "dbo.Usuarios");
            DropIndex("dbo.UsuarioDireitos", new[] { "Direitos_ID" });
            DropIndex("dbo.UsuarioDireitos", new[] { "Usuario_ID" });
            DropIndex("dbo.Logs", new[] { "Usuario_ID" });
            DropTable("dbo.UsuarioDireitos");
            DropTable("dbo.Logs");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Direitos");
        }
    }
}

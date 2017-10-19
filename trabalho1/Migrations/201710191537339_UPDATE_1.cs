namespace trabalho1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDATE_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Acao = c.String(),
                        Data = c.DateTime(nullable: false),
                        Usuario_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "Usuario_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Logs", new[] { "Usuario_Id" });
            DropTable("dbo.Logs");
        }
    }
}

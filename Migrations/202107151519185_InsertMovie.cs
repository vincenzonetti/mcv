namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 45),
                        dataRilascio = c.DateTime(nullable: false),
                        dataRegistrazione = c.DateTime(nullable: false),
                        stock = c.Int(nullable: false),
                        genereID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Generes", t => t.genereID, cascadeDelete: true)
                .Index(t => t.genereID);
            
            CreateTable(
                "dbo.Generes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "genereID", "dbo.Generes");
            DropIndex("dbo.Movies", new[] { "genereID" });
            DropTable("dbo.Generes");
            DropTable("dbo.Movies");
        }
    }
}

namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserisciAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Disponibilit√†", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Disponibilit√†");
        }
    }
}

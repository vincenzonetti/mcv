namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inserisciTextAbbonamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "textAbbonamento", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "textAbbonamento");
        }
    }
}

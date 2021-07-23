namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aggiungiCompleannoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Compleanno", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Compleanno");
        }
    }
}

namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aggiornaTextAbbonamento : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET textAbbonamento = 'Non pagah' WHERE id = 1; ");
            Sql("UPDATE MembershipTypes SET textAbbonamento = 'Paga ogni mese' WHERE id = 2; ");
            Sql("UPDATE MembershipTypes SET textAbbonamento = 'Paga ogni tre mesi' WHERE id = 3; ");
            Sql("UPDATE MembershipTypes SET textAbbonamento = 'Paga ogni dodici mesi' WHERE id = 4"); 
        }
        
        public override void Down()
        {
        }
    }
}

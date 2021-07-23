namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCompleanno : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Compleanno = '2002-03-16 00:00:00.000' WHERE id = 1; ");
            Sql("UPDATE Customers SET Compleanno = '2001-03-16 00:00:00.000' WHERE id = 4; ");
            Sql("UPDATE Customers SET Compleanno = '1998-03-16 00:00:00.000' WHERE id = 7; ");
            Sql("UPDATE Customers SET Compleanno = '1980-03-16 00:00:00.000' WHERE id = 9;");
            Sql("UPDATE Customers SET Compleanno = '1980-03-16 00:00:00.000' WHERE id = 2;");
        }
        
        public override void Down()
        {
        }
    }
}

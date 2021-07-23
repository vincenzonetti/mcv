namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenere : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Generes(name)VALUES('Commedia')");
            Sql("INSERT INTO Generes(name)VALUES('Fantascienza')");
            Sql("INSERT INTO Generes(name)VALUES('Animazione')");
            Sql("INSERT INTO Generes(name)VALUES('Azione')");
            Sql("INSERT INTO Generes(name)VALUES('Drammatico')");
            Sql("INSERT INTO Generes(name)VALUES('Romantico')");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertFilms : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(name,dataRilascio,dataRegistrazione,stock,genereID) VALUES ('LadyOscar', '1994-03-16 00:00:00.000','2002-03-16 00:00:00.000',30,6 )");
            Sql("INSERT INTO Movies(name,dataRilascio,dataRegistrazione,stock,genereID) VALUES ('Terminator', '1970-03-16 00:00:00.000','1980-03-16 00:00:00.000',30,4 )");
            Sql("INSERT INTO Movies(name,dataRilascio,dataRegistrazione,stock,genereID) VALUES ('Friends', '1980-03-16 00:00:00.000','1990-03-16 00:00:00.000',50,1 )");
            Sql("INSERT INTO Movies(name,dataRilascio,dataRegistrazione,stock,genereID) VALUES ('Miranda', '1994-03-16 00:00:00.000','2001-03-16 00:00:00.000',30,5 )");
            Sql("INSERT INTO Movies(name,dataRilascio,dataRegistrazione,stock,genereID) VALUES ('UltimoGiorno', '1934-03-16 00:00:00.000','1950-03-16 00:00:00.000',30,3 )");
            Sql("INSERT INTO Movies(name,dataRilascio,dataRegistrazione,stock,genereID) VALUES ('Farinella', '1945-03-16 00:00:00.000','2020-03-16 00:00:00.000',30,2 )");

        }   
        
        public override void Down()
        {
        }
    }
}

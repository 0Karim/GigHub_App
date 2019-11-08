namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenresTablewithDatainUpmethod : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Jazz')");
            Sql("INSERT INTO Genres (Name) VALUES ('Rock')");
            Sql("INSERT INTO Genres (Name) VALUES ('Rapper')");
            Sql("INSERT INTO Genres (Name) VALUES ('Pop Music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Folk Music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Classical Music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Reggae')");
            Sql("INSERT INTO Genres (Name) VALUES ('Disco')");
            Sql("INSERT INTO Genres (Name) VALUES ('Techno')");
            Sql("INSERT INTO Genres (Name) VALUES ('Singing')");
            Sql("INSERT INTO Genres (Name) VALUES ('Funk')");
            Sql("INSERT INTO Genres (Name) VALUES ('Blues')");
            Sql("INSERT INTO Genres (Name) VALUES ('Instrumental')");
            Sql("INSERT INTO Genres (Name) VALUES ('Dance Music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Soul Music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drum and Bass')");
            Sql("INSERT INTO Genres (Name) VALUES ('Death metal')");
            Sql("INSERT INTO Genres (Name) VALUES ('Electro')");
            Sql("INSERT INTO Genres (Name) VALUES ('Emo')");
            Sql("INSERT INTO Genres (Name) VALUES ('Orchestra')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Genres Where ID IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20)");
        }
    }
}

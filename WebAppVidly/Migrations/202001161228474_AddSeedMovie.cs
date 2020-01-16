namespace WebAppVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeedMovie : DbMigration
    {
        public override void Up()
        {
          Sql("SET IDENTITY_INSERT Movies On");
          Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock ) VALUES (1,'Shreck', 1, '10/01/2017', '10/02/2018', 5)");
          Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock ) VALUES (2,'MrBean', 3, '10/03/2018', '10/02/2018', 3)");
        }

        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 5, CAST ('2009-05-30T00:00:00' AS DATE), CAST (GETDATE() AS DATETIME2), 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 1, CAST ('1988-07-12T00:00:00' AS DATE), CAST (GETDATE() AS DATETIME2), 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 1, CAST ('1984-10-26T00:00:00' AS DATE), CAST (GETDATE() AS DATETIME2), 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 3, CAST ('1995-11-19T00:00:00' AS DATE), CAST (GETDATE() AS DATETIME2), 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, CAST ('1997-12-19T00:00:00' AS DATE), CAST (GETDATE() AS DATETIME2), 5)");

        }

        public override void Down()
        {
        }
    }
}

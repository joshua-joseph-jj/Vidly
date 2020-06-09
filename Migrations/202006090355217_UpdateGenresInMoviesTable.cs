namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenresInMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre = 'Action' WHERE Name = 'Die Hard'");
            Sql("UPDATE Movies SET Genre = 'Action' WHERE Name = 'The Terminator'");
            Sql("UPDATE Movies SET Genre = 'Family' WHERE Name = 'Toy Story'");
            Sql("UPDATE Movies SET Genre = 'Romance' WHERE Name = 'Titanic'");
        }
        
        public override void Down()
        {
        }
    }
}

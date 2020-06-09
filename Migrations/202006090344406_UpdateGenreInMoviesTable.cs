namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreInMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre = 'Comedy' WHERE Name = 'Hangover'");
        }
        
        public override void Down()
        {
        }
    }
}

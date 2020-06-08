namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIndexGenreIDMoviesTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Movies", "GenreID");
        }
        
        public override void Down()
        {
        }
    }
}

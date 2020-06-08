namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReIndexMoviesTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Movies', RESEED, 1)");
        }
        
        public override void Down()
        {
        }
    }
}

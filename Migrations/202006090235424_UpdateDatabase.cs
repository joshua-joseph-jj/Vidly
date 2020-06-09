namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
          
            DropTable("dbo.Movies");
        }
        
        public override void Down()
        {
           
        }
    }
}

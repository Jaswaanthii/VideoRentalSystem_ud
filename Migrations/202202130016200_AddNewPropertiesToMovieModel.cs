namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewPropertiesToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Quality", c => c.String());
            AddColumn("dbo.Movies", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Description");
            DropColumn("dbo.Movies", "Quality");
        }
    }
}

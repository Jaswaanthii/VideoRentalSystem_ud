namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveQualityFromMovie : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Quality");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Quality", c => c.String());
        }
    }
}

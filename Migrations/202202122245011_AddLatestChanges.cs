namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLatestChanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rentals", "DueDate");
            DropColumn("dbo.Rentals", "NumberOfMoviesRented");
            DropColumn("dbo.Rentals", "MovieReturned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "MovieReturned", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rentals", "NumberOfMoviesRented", c => c.Int(nullable: false));
            AddColumn("dbo.Rentals", "DueDate", c => c.DateTime(nullable: false));
        }
    }
}

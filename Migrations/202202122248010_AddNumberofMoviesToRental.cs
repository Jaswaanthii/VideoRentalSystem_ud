namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberofMoviesToRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "NumberOfMoviesRented", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "NumberOfMoviesRented");
        }
    }
}

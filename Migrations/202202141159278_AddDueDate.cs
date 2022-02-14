namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDueDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Description", c => c.String());
            AddColumn("dbo.Rentals", "NumberOfMoviesRented", c => c.Int(nullable: false));
            AddColumn("dbo.Rentals", "DueDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "DueDate");
            DropColumn("dbo.Rentals", "NumberOfMoviesRented");
            DropColumn("dbo.Movies", "Description");
        }
    }
}

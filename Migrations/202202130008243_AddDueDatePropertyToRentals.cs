namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDueDatePropertyToRentals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "DueDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "DueDate");
        }
    }
}

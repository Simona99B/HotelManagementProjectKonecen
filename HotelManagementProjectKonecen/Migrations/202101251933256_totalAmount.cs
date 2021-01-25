namespace HotelManagementProjectKonecen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class totalAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "TotalAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "TotalAmount");
        }
    }
}

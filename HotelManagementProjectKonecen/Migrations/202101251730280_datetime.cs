namespace HotelManagementProjectKonecen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "BookingFrom", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bookings", "BookingTo", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "BookingTo", c => c.Int(nullable: false));
            AlterColumn("dbo.Bookings", "BookingFrom", c => c.Int(nullable: false));
        }
    }
}

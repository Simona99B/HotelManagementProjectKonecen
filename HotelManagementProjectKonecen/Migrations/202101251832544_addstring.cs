namespace HotelManagementProjectKonecen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "BookingStatusId", c => c.String());
            AlterColumn("dbo.Rooms", "RoomTypeId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "RoomTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Rooms", "BookingStatusId", c => c.Int(nullable: false));
        }
    }
}

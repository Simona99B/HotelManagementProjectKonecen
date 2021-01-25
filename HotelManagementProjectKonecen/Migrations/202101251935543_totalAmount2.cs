namespace HotelManagementProjectKonecen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class totalAmount2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "RoomNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "RoomNumber", c => c.String(nullable: false));
        }
    }
}

namespace HotelManagementProjectKonecen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbooked : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "BookedFrom", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rooms", "BookedTo", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "BookedTo");
            DropColumn("dbo.Rooms", "BookedFrom");
        }
    }
}

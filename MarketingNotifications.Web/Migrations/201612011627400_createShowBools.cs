namespace MarketingNotifications.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createShowBools : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribers", "Boat", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.Subscribers", "Rv", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.Subscribers", "Bridal", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribers", "Bridal");
            DropColumn("dbo.Subscribers", "Rv");
            DropColumn("dbo.Subscribers", "Boat");
        }
    }
}

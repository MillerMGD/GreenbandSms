using MarketingNotifications.Web.Models;

namespace MarketingNotifications.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestGroupBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribers", "TestGroup", c => c.Boolean(nullable: false));
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribers", "TestGroup");
        }
    }
}

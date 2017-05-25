namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIssubscribe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribetoNews", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribetoNews");
        }
    }
}

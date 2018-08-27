namespace IssueTrackingSystemBLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Database_Column_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AddDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsActive");
            DropColumn("dbo.Users", "AddDate");
        }
    }
}

namespace IssueTrackingSystemBLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        AddDate = c.DateTime(nullable: false),
                        AddedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Users", t => t.AddedBy, cascadeDelete: true)
                .Index(t => t.AddedBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Details = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        AddedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Users", t => t.AddedBy, cascadeDelete: true)
                .Index(t => t.AddedBy);
            
            CreateTable(
                "dbo.ProjectModules",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectId, t.ModuleId })
                .ForeignKey("dbo.Modules", t => t.ModuleId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.ModuleId);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ModuleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        AddedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModuleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AddedBy", "dbo.Users");
            DropForeignKey("dbo.Projects", "AddedBy", "dbo.Users");
            DropForeignKey("dbo.ProjectModules", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ProjectModules", "ModuleId", "dbo.Modules");
            DropIndex("dbo.ProjectModules", new[] { "ModuleId" });
            DropIndex("dbo.ProjectModules", new[] { "ProjectId" });
            DropIndex("dbo.Projects", new[] { "AddedBy" });
            DropIndex("dbo.Customers", new[] { "AddedBy" });
            DropTable("dbo.Modules");
            DropTable("dbo.ProjectModules");
            DropTable("dbo.Projects");
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
        }
    }
}

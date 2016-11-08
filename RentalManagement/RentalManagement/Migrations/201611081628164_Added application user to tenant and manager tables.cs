namespace RentalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedapplicationusertotenantandmanagertables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyManagers", "ApplicationUserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Tenants", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.PropertyManagers", "ApplicationUserId");
            CreateIndex("dbo.Tenants", "ApplicationUserId");
            AddForeignKey("dbo.PropertyManagers", "ApplicationUserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Tenants", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tenants", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.PropertyManagers", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Tenants", new[] { "ApplicationUserId" });
            DropIndex("dbo.PropertyManagers", new[] { "ApplicationUserId" });
            DropColumn("dbo.Tenants", "ApplicationUserId");
            DropColumn("dbo.PropertyManagers", "ApplicationUserId");
        }
    }
}

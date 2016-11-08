namespace RentalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrequeststringtomaintainencerequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaintainenceRequests", "Request", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MaintainenceRequests", "Request");
        }
    }
}

namespace MVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisplayName : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Reviews", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "UserName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Reviews", "UserName");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Reviews", "UserName", c => c.String());
            AlterColumn("dbo.Reviews", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Reviews", "ID");
        }
    }
}

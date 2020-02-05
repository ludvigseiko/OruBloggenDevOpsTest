namespace OruBloggen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Notification : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "UserSmsNotification", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserModels", "UserPmNotification", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserModels", "UserEmailNotification", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "UserEmailNotification");
            DropColumn("dbo.UserModels", "UserPmNotification");
            DropColumn("dbo.UserModels", "UserSmsNotification");
        }
    }
}

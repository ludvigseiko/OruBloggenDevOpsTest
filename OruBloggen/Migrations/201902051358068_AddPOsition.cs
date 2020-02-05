namespace OruBloggen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPOsition : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "UserPosition", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "UserPosition");
        }
    }
}

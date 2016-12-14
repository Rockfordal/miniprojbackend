namespace Miniproj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class colortest_RGB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ColorTestModels", "RGB", c => c.String(nullable: false));
            AddColumn("dbo.ColorTestModels", "Name", c => c.String(nullable: false));
            DropColumn("dbo.ColorTestModels", "Color");
            DropColumn("dbo.ColorTestModels", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ColorTestModels", "Image", c => c.String(nullable: false));
            AddColumn("dbo.ColorTestModels", "Color", c => c.String(nullable: false));
            DropColumn("dbo.ColorTestModels", "Name");
            DropColumn("dbo.ColorTestModels", "RGB");
        }
    }
}

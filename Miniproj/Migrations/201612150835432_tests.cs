namespace Miniproj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tests : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ColorTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RGB = c.String(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SentenceTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SeparatorTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WordImageTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Word = c.String(nullable: false),
                        Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WordImageTests");
            DropTable("dbo.SeparatorTests");
            DropTable("dbo.SentenceTests");
            DropTable("dbo.ColorTests");
        }
    }
}

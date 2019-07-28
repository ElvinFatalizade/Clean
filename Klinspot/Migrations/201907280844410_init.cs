namespace Klinspot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutTexts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 300),
                        Slug = c.String(nullable: false, maxLength: 300),
                        Photo = c.String(maxLength: 100),
                        Text = c.String(storeType: "ntext"),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CategoryId = c.Int(nullable: false),
                        Photo = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(nullable: false, maxLength: 100),
                        Company = c.String(nullable: false, maxLength: 100),
                        Text = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(nullable: false, maxLength: 100),
                        Position = c.String(nullable: false, maxLength: 100),
                        Photo = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MembersLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Url = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderBy = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Option = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 100),
                        Url = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Slug = c.String(nullable: false, maxLength: 100),
                        Icon = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 100),
                        Pdf = c.String(maxLength: 100),
                        Doc = c.String(maxLength: 100),
                        Text = c.String(storeType: "ntext"),
                        IsPromo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logo = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        HeaderPhone = c.String(maxLength: 100),
                        ContactPhone = c.String(maxLength: 50),
                        VideoUrl = c.String(maxLength: 100),
                        Lat = c.Single(nullable: false),
                        Lng = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Desc = c.String(nullable: false, maxLength: 100),
                        BtnText = c.String(maxLength: 50),
                        Photo = c.String(maxLength: 100),
                        BtnUrl = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SocialLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OderBy = c.Int(nullable: false),
                        Icon = c.String(maxLength: 50),
                        Url = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MembersLinks", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Projects", "CategoryId", "dbo.Categories");
            DropIndex("dbo.MembersLinks", new[] { "MemberId" });
            DropIndex("dbo.Projects", new[] { "CategoryId" });
            DropTable("dbo.SocialLinks");
            DropTable("dbo.Slides");
            DropTable("dbo.Settings");
            DropTable("dbo.Services");
            DropTable("dbo.Partners");
            DropTable("dbo.Packages");
            DropTable("dbo.MembersLinks");
            DropTable("dbo.Members");
            DropTable("dbo.Clients");
            DropTable("dbo.Projects");
            DropTable("dbo.Categories");
            DropTable("dbo.Blogs");
            DropTable("dbo.AboutTexts");
        }
    }
}

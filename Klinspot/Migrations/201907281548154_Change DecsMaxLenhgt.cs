namespace Klinspot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDecsMaxLenhgt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Slides", "Desc", c => c.String(nullable: false, maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Slides", "Desc", c => c.String(nullable: false, maxLength: 100));
        }
    }
}

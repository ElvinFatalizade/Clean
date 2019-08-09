namespace Klinspot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class frfr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AboutTexts", "Title", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AboutTexts", "Title", c => c.String(maxLength: 100));
        }
    }
}

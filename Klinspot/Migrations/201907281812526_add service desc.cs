namespace Klinspot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addservicedesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Desc", c => c.String(storeType: "ntext"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Desc");
        }
    }
}

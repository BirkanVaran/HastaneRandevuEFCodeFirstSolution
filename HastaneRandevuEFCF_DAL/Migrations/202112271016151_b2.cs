namespace HastaneRandevuEFCF_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Doktorlar", "denemekolon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doktorlar", "denemekolon", c => c.Int(nullable: false));
        }
    }
}

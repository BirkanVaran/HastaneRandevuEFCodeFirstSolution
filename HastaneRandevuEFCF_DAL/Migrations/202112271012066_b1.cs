namespace HastaneRandevuEFCF_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doktorlar",
                c => new
                    {
                        DoktorId = c.Int(nullable: false, identity: true),
                        DoktorAdi = c.String(nullable: false, maxLength: 50),
                        DoktorSoyadi = c.String(nullable: false, maxLength: 50),
                        Brans = c.Byte(nullable: false),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TCNumarasi = c.String(nullable: false, maxLength: 11),
                        Telefon = c.String(maxLength: 11),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.DoktorId);
            
            CreateTable(
                "dbo.RandevuBilgileri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoktorId = c.Int(nullable: false),
                        HastaId = c.Int(nullable: false),
                        RandevuTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doktorlar", t => t.DoktorId, cascadeDelete: true)
                .ForeignKey("dbo.Hastalar", t => t.HastaId, cascadeDelete: true)
                .Index(t => t.DoktorId)
                .Index(t => t.HastaId);
            
            CreateTable(
                "dbo.Hastalar",
                c => new
                    {
                        HastaId = c.Int(nullable: false, identity: true),
                        HastaAdi = c.String(nullable: false, maxLength: 50),
                        HastaSoyadi = c.String(nullable: false, maxLength: 50),
                        TCNumarasi = c.String(nullable: false, maxLength: 11),
                        Telefon = c.String(maxLength: 11),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.HastaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RandevuBilgileri", "HastaId", "dbo.Hastalar");
            DropForeignKey("dbo.RandevuBilgileri", "DoktorId", "dbo.Doktorlar");
            DropIndex("dbo.RandevuBilgileri", new[] { "HastaId" });
            DropIndex("dbo.RandevuBilgileri", new[] { "DoktorId" });
            DropTable("dbo.Hastalar");
            DropTable("dbo.RandevuBilgileri");
            DropTable("dbo.Doktorlar");
        }
    }
}

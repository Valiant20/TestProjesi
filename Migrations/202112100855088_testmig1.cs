namespace TestProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Kullanici = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hakkimizdas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FotoUrl = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Iletisims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Mail = c.String(),
                        Konu = c.String(),
                        Mesaj = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Yorumlars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Mail = c.String(),
                        Yorum = c.String(),
                        UrunKategoriID = c.Int(nullable: false),
                        Urunler_UrunID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Urunlers", t => t.Urunler_UrunID)
                .Index(t => t.Urunler_UrunID);
            
            AddColumn("dbo.Urunlers", "UrunResimURL", c => c.String());
            AddColumn("dbo.Urunlers", "UrunKategoriId", c => c.String());
            AddColumn("dbo.Urunlers", "UrunDurum", c => c.Boolean(nullable: false));
            DropColumn("dbo.Urunlers", "AnasayfaResimURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunlers", "AnasayfaResimURL", c => c.String());
            DropForeignKey("dbo.Yorumlars", "Urunler_UrunID", "dbo.Urunlers");
            DropIndex("dbo.Yorumlars", new[] { "Urunler_UrunID" });
            DropColumn("dbo.Urunlers", "UrunDurum");
            DropColumn("dbo.Urunlers", "UrunKategoriId");
            DropColumn("dbo.Urunlers", "UrunResimURL");
            DropTable("dbo.Yorumlars");
            DropTable("dbo.Iletisims");
            DropTable("dbo.Hakkimizdas");
            DropTable("dbo.Admins");
        }
    }
}

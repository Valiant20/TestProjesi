namespace TestProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        UrunKategoriID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UrunKategoriID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kategoris");
        }
    }
}

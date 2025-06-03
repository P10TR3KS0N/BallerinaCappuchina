namespace BallerinaCappucina01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorias",
                c => new
                    {
                        IdKategoria = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdKategoria);
            
            CreateTable(
                "dbo.Produkties",
                c => new
                    {
                        IdProduktu = c.Int(nullable: false, identity: true),
                        NazwaProduktu = c.String(nullable: false),
                        KategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduktu)
                .ForeignKey("dbo.Kategorias", t => t.KategoriaId, cascadeDelete: true)
                .Index(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Skladnikis",
                c => new
                    {
                        IdSkladnika = c.Int(nullable: false, identity: true),
                        NazwaSkladnika = c.String(nullable: false),
                        Produkty_IdProduktu = c.Int(),
                    })
                .PrimaryKey(t => t.IdSkladnika)
                .ForeignKey("dbo.Produkties", t => t.Produkty_IdProduktu)
                .Index(t => t.Produkty_IdProduktu);
            
            CreateTable(
                "dbo.Zamowienias",
                c => new
                    {
                        IdZamowienia = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdZamowienia);
            
            CreateTable(
                "dbo.ZamowienieProdukts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZamowieniaId = c.Int(nullable: false),
                        ProduktyId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produkties", t => t.ProduktyId, cascadeDelete: true)
                .ForeignKey("dbo.Zamowienias", t => t.ZamowieniaId, cascadeDelete: true)
                .Index(t => t.ZamowieniaId)
                .Index(t => t.ProduktyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZamowienieProdukts", "ZamowieniaId", "dbo.Zamowienias");
            DropForeignKey("dbo.ZamowienieProdukts", "ProduktyId", "dbo.Produkties");
            DropForeignKey("dbo.Skladnikis", "Produkty_IdProduktu", "dbo.Produkties");
            DropForeignKey("dbo.Produkties", "KategoriaId", "dbo.Kategorias");
            DropIndex("dbo.ZamowienieProdukts", new[] { "ProduktyId" });
            DropIndex("dbo.ZamowienieProdukts", new[] { "ZamowieniaId" });
            DropIndex("dbo.Skladnikis", new[] { "Produkty_IdProduktu" });
            DropIndex("dbo.Produkties", new[] { "KategoriaId" });
            DropTable("dbo.ZamowienieProdukts");
            DropTable("dbo.Zamowienias");
            DropTable("dbo.Skladnikis");
            DropTable("dbo.Produkties");
            DropTable("dbo.Kategorias");
        }
    }
}

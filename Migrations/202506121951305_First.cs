namespace BallerinaCappucina01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zamowienias", "WartoscZamowienia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Zamowienias", "DataZamowienia", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zamowienias", "DataZamowienia");
            DropColumn("dbo.Zamowienias", "WartoscZamowienia");
        }
    }
}

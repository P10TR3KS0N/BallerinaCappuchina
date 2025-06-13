namespace BallerinaCappucina01.Migrations
{
    using BallerinaCappucina01.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BallerinaCappucina01.Models.BallerinaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BallerinaDbContext context)
        {
            // 1. Seed kategorii  
            var kategorie = new List<Kategoria>
                   {
                       new Kategoria("Kawy") { IdKategoria = 1 },
                       new Kategoria("Herbaty") { IdKategoria = 2 },
                       new Kategoria("Desery") { IdKategoria = 3 },
                       new Kategoria("Kanapki") { IdKategoria = 4 },
                       new Kategoria("Napoje zimne") { IdKategoria = 5 }
                   };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            // 2. Seed składników  
            var skladniki = new List<Skladniki>
                   {
                       new Skladniki("Ziarna kawy Arabica") { IdSkladnika = 1 },
                       new Skladniki("Mleko 3.2%") { IdSkladnika = 2 },
                       new Skladniki("Cukier biały") { IdSkladnika = 3 },
                       new Skladniki("Śmietanka 30%") { IdSkladnika = 4 },
                       new Skladniki("Syrop waniliowy") { IdSkladnika = 5 },
                       new Skladniki("Liście herbaty Earl Grey") { IdSkladnika = 6 },
                       new Skladniki("Czekolada mleczna") { IdSkladnika = 7 },
                       new Skladniki("Chleb żytni") { IdSkladnika = 8 },
                       new Skladniki("Szynka wiejska") { IdSkladnika = 9 },
                       new Skladniki("Ser Gouda") { IdSkladnika = 10 },
                       new Skladniki("Lód") { IdSkladnika = 11 },
                       new Skladniki("Woda mineralna") { IdSkladnika = 12 },
                       new Skladniki("Miód") { IdSkladnika = 13 },
                       new Skladniki("Cynamon") { IdSkladnika = 14 }
                   };
            skladniki.ForEach(s => context.Skladniki.AddOrUpdate(s));
            context.SaveChanges();

            // 3. Seed produktów  
            var produkty = new List<Produkty>
                   {
                       new Produkty("Espresso") { IdProduktu = 1, Kategoria = kategorie[0], KategoriaId = kategorie[0].IdKategoria },
                       new Produkty("Cappuccino") { IdProduktu = 2, Kategoria = kategorie[0], KategoriaId = kategorie[0].IdKategoria },
                       new Produkty("Latte Macchiato") { IdProduktu = 3, Kategoria = kategorie[0], KategoriaId = kategorie[0].IdKategoria },
                       new Produkty("Americano") { IdProduktu = 4, Kategoria = kategorie[0], KategoriaId = kategorie[0].IdKategoria },
                       new Produkty("Herbata Czarna") { IdProduktu = 5, Kategoria = kategorie[1], KategoriaId = kategorie[1].IdKategoria },
                       new Produkty("Herbata Owocowa") { IdProduktu = 6, Kategoria = kategorie[1], KategoriaId = kategorie[1].IdKategoria },
                       new Produkty("Ciasto Czekoladowe") { IdProduktu = 7, Kategoria = kategorie[2], KategoriaId = kategorie[2].IdKategoria },
                       new Produkty("Sernik") { IdProduktu = 8, Kategoria = kategorie[2], KategoriaId = kategorie[2].IdKategoria },
                       new Produkty("Kanapka z Szynką") { IdProduktu = 9, Kategoria = kategorie[3], KategoriaId = kategorie[3].IdKategoria },
                       new Produkty("Tost Serowy") { IdProduktu = 10, Kategoria = kategorie[3], KategoriaId = kategorie[3].IdKategoria },
                       new Produkty("Woda Mineralna") { IdProduktu = 11, Kategoria = kategorie[4], KategoriaId = kategorie[4].IdKategoria },
                       new Produkty("Mrożona Herbata") { IdProduktu = 12, Kategoria = kategorie[4], KategoriaId = kategorie[4].IdKategoria }
                   };

            produkty.ForEach(p => context.Produkty.AddOrUpdate(p));
            context.SaveChanges();

            // 4. Seed zamówień  
            var zamowienia = new List<Zamowienia>
                   {
                       new Zamowienia() { IdZamowienia = 1001 },
                       new Zamowienia() { IdZamowienia = 1002 },
                       new Zamowienia() { IdZamowienia = 1003 },
                       new Zamowienia() { IdZamowienia = 1004 },
                       new Zamowienia() { IdZamowienia = 1005 }
                   };

            foreach (var zamowienie in zamowienia)
            {
                context.Zamowienia.AddOrUpdate(zamowienie);
            }

            context.SaveChanges();
        }
    }
}

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

        protected override void Seed(BallerinaDbContext context) // Poprawiono typ parametru na BallerinaDbContext  
        {
            // 1. Seed kategorii  
            var kategorie = new List<Kategoria>
               {
                   new Kategoria { IdKategoria = 1, Name = "Kawy" },
                   new Kategoria { IdKategoria = 2, Name = "Herbaty" },
                   new Kategoria { IdKategoria = 3, Name = "Desery" },
                   new Kategoria { IdKategoria = 4, Name = "Kanapki" },
                   new Kategoria { IdKategoria = 5, Name = "Napoje zimne" }
               };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k)); // Użyto AddOrUpdate zamiast Add  
            context.SaveChanges();

            // 2. Seed składników  
            var skladniki = new List<Skladniki>
               {
                   new Skladniki { IdSkladnika = 1, NazwaSkladnika = "Ziarna kawy Arabica" },
                   new Skladniki { IdSkladnika = 2, NazwaSkladnika = "Mleko 3.2%" },
                   new Skladniki { IdSkladnika = 3, NazwaSkladnika = "Cukier biały" },
                   new Skladniki { IdSkladnika = 4, NazwaSkladnika = "Śmietanka 30%" },
                   new Skladniki { IdSkladnika = 5, NazwaSkladnika = "Syrop waniliowy" },
                   new Skladniki { IdSkladnika = 6, NazwaSkladnika = "Liście herbaty Earl Grey" },
                   new Skladniki { IdSkladnika = 7, NazwaSkladnika = "Czekolada mleczna" },
                   new Skladniki { IdSkladnika = 8, NazwaSkladnika = "Chleb żytni" },
                   new Skladniki { IdSkladnika = 9, NazwaSkladnika = "Szynka wiejska" },
                   new Skladniki { IdSkladnika = 10, NazwaSkladnika = "Ser Gouda" },
                   new Skladniki { IdSkladnika = 11, NazwaSkladnika = "Lód" },
                   new Skladniki { IdSkladnika = 12, NazwaSkladnika = "Woda mineralna" },
                   new Skladniki { IdSkladnika = 13, NazwaSkladnika = "Miód" },
                   new Skladniki { IdSkladnika = 14, NazwaSkladnika = "Cynamon" }
               };
            skladniki.ForEach(s => context.Skladniki.AddOrUpdate(s)); // Użyto AddOrUpdate zamiast Add  
            context.SaveChanges();

            // 3. Seed produktów  
            var produkty = new List<Produkty>
               {
                   new Produkty(1, "Espresso", kategorie[0]),
                   new Produkty(2, "Cappuccino", kategorie[0]),
                   new Produkty(3, "Latte Macchiato", kategorie[0]),
                   new Produkty(4, "Americano", kategorie[0]),
                   new Produkty(5, "Herbata Czarna", kategorie[1]),
                   new Produkty(6, "Herbata Owocowa", kategorie[1]),
                   new Produkty(7, "Ciasto Czekoladowe", kategorie[2]),
                   new Produkty(8, "Sernik", kategorie[2]),
                   new Produkty(9, "Kanapka z Szynką", kategorie[3]),
                   new Produkty(10, "Tost Serowy", kategorie[3]),
                   new Produkty(11, "Woda Mineralna", kategorie[4]),
                   new Produkty(12, "Mrożona Herbata", kategorie[4])
               };

            produkty.ForEach(p => context.Produkty.AddOrUpdate(p)); // Użyto AddOrUpdate zamiast Add  
            context.SaveChanges();

            // 4. Seed zamówień  
            var zamowienia = new List<Zamowienia>
               {
                   new Zamowienia(1001),
                   new Zamowienia(1002),
                   new Zamowienia(1003),
                   new Zamowienia(1004),
                   new Zamowienia(1005)
               };

            foreach (var zamowienie in zamowienia)
            {
                context.Zamowienia.AddOrUpdate(zamowienie); // Użyto AddOrUpdate zamiast Add  
            }

            context.SaveChanges();
        }
    }
}

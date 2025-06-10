//namespace BallerinaCappucina01.Migrations
//{
//    using BallerinaCappucina01.Models;
//    using System;
//    using System.Collections.Generic;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<BallerinaCappucina01.Models.BallerinaDbContext>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = false;
//        }

//        protected override void Seed(BallerinaCappucina01.Models.BallerinaDbContext context)
//        {
//            {
//                // Dodaj kategorie (AddOrUpdate zapobiega duplikatom)
//                context.Kategorie.AddOrUpdate(
//                    k => k.Name,
//                   // new Kategoria { Name = "Kawa" },
//                    //new Kategoria { Name = "Herbata" }
//                );

//                // Dodaj składniki
//                context.Skladniki.AddOrUpdate(
//                    s => s.NazwaSkladnika,
//                   // new Skladniki { NazwaSkladnika = "Mleko" },
//                    //new Skladniki { NazwaSkladnika = "Kawa" },
//                    //new Skladniki { NazwaSkladnika = "Woda" }
//                );

//                // Dodaj produkty
//                context.Produkty.AddOrUpdate(
//                    p => p.NazwaProduktu,
//                    new Produkty
//                    {
//                        NazwaProduktu = "Cappuccino",
//                        Kategoria = context.Kategorie.Single(k => k.Name == "Kawa"),
//                        Skladniki = new List<Skladniki>
//                        {
//                context.Skladniki.Single(s => s.NazwaSkladnika == "Woda"),
//                context.Skladniki.Single(s => s.NazwaSkladnika == "Kawa"),
//                context.Skladniki.Single(s => s.NazwaSkladnika == "Mleko")
//                        }
//                    }
//                );

//                // Na koniec zapisz zmiany (nie jest obowiązkowe, EF robi to automatycznie)
//                context.SaveChanges();
//            }
//        }
//    }
//}

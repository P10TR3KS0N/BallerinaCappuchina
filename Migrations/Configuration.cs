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

        protected override void Seed(BallerinaCappucina01.Models.BallerinaDbContext context)
        {
            {
                // Dodaj kategorie (AddOrUpdate zapobiega duplikatom)
                context.Kategorie.AddOrUpdate(
                    k => k.Name,
                    new Kategoria { Name = "Kawa" },
                    new Kategoria { Name = "Herbata" }
                );

                // Dodaj składniki
                context.Skladniki.AddOrUpdate(
                    s => s.NazwaSkladnika,
                    new Skladniki { NazwaSkladnika = "Mleko" },
                    new Skladniki { NazwaSkladnika = "Kawa" },
                    new Skladniki { NazwaSkladnika = "Woda" }
                );

                // Dodaj produkty
                context.Produkty.AddOrUpdate(
                    p => p.NazwaProduktu,
                    new Produkty
                    {
                        NazwaProduktu = "Cappuccino",
                        Kategoria = context.Kategorie.FirstOrDefault(k => k.Name == "Kawa"),
                        Skladniki = context.Skladniki.Where(s => s.NazwaSkladnika == "Woda" || s.NazwaSkladnika == "Kawa" || s.NazwaSkladnika == "Mleko").ToList()
                    }
                );

                // Dodaj użytkowników
                context.Uzytkownicy.AddOrUpdate(
                    u => u.Email,
                    new Uzytkownik { Imie = "Jan", Nazwisko = "Kowalski", Email = "jan.kowalski@example.com", Haslo = "test123" }
                );

                // Dodaj zamówienia
                var user = context.Uzytkownicy.FirstOrDefault(u => u.Email == "jan.kowalski@example.com");
                var produkt = context.Produkty.FirstOrDefault(p => p.NazwaProduktu == "Cappuccino");
                if (user != null && produkt != null)
                {
                    context.Zamowienia.AddOrUpdate(
                        z => z.Id,
                        new Zamowienie
                        {
                            Uzytkownik = user,
                            DataZamowienia = DateTime.Now,
                            Pozycje = new List<PozycjaZamowienia>
                            {
                                new PozycjaZamowienia { Produkt = produkt, Ilosc = 2 }
                            }
                        }
                    );
                }

                // Dodaj inne modele jeśli istnieją (np. Role, Oceny, itp.)
                // Przykład dla ról:
                context.Role.AddOrUpdate(
                    r => r.Nazwa,
                    new Rola { Nazwa = "Admin" },
                    new Rola { Nazwa = "User" }
                );

                context.SaveChanges();
            }
        }
    }
}

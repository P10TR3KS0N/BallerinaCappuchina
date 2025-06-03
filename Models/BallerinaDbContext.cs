using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class BallerinaDbContext : DbContext
    {
        public BallerinaDbContext() : base("BallerinaDbContext") { }

        public DbSet<Produkty> Produkty { get; set; }
        public DbSet<Skladniki> Skladniki { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienia> Zamowienia { get; set; }
        public DbSet<ZamowienieProdukt> ZamowienieProdukty { get; set; }
    }
}
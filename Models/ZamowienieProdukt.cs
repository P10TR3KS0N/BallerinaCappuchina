using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class ZamowienieProdukt
    {
        public ZamowienieProdukt()
        {
            // Constructor logic if needed
        }
        [Key]
        public int Id { get; set; }

        [ForeignKey("Zamowienia")]
        public int ZamowieniaId { get; set; }
        public virtual Zamowienia Zamowienia { get; set; }

        [ForeignKey("Produkt")]
        public int ProduktyId { get; set; }
        public virtual Produkty Produkt { get; set; }

        public int Ilosc { get; set; }
    }
}
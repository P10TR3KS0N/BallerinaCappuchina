using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public enum Status { przygotowywany, gotowy, wydany, anulowane }
    public class Zamowienia
    {
        [Key]
        public int IdZamowienia { get; set; }
        public decimal WartoscZamowienia { get; set; }
        public DateTime DataZamowienia { get; set; }

        public Status Status { get; set; }

        public virtual ICollection<ZamowienieProdukt> Produkty { get; set; }
        public Zamowienia()
        {
            ProduktyZamowienia = new List<ZamowienieProdukt>();
            Status = Status.przygotowywany;
        }
        public DodajProdukt(ZamowienieProdukt produkt)
        {
            Produkty.Add(produkt);
            WartoscZamowienia += produkt.Cena * produkt.Ilosc;
        }
        public void Gotowy()
        {
            Status = Status.gotowy;
        }
        public void Wydany()
        {
            Status = Status.wydany;
        }
        public void Anulowane()
        {
            Status = Status.anulowane;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
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
<<<<<<< Updated upstream
        //public Zamowienia()
        //{
        //    ProduktyZamowienia = new List<ZamowienieProdukt>();
        //    Status = Status.przygotowywany;
        //}
        //public void DodajProdukt(ZamowienieProdukt produkt)
        //{
        //    Produkty.Add(produkt);
        //    WartoscZamowienia += produkt.Cena * produkt.Ilosc;
        //}
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
        public decimal WyswietlWartosc()
        {
            return WartoscZamowienia;
=======
        
        public Zamowienia(int id)
        {
            IdZamowienia = id;
            WartoscZamowienia = 0;
            DataZamowienia = DateTime.Now;
            Status = Status.przygotowywany;
            Produkty = new List<ZamowienieProdukt>();
        }

        public void DodajProdukt(ZamowienieProdukt p)
        {
            Produkty.Add(p);
        }
        public void UsunProdukt(ZamowienieProdukt p)
        {
            Produkty.Remove(p);
        }
        public void ZmienStatus(Status s)
        {
            Status = s;
>>>>>>> Stashed changes
        }


    }
}

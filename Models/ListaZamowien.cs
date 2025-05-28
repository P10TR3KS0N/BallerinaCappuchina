using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class ListaZamowien
    {
        public List<Zamowienia> Zamowienia { get; set; }
        public ListaZamowien()
        {
            Zamowienia = new List<Zamowienia>();
        }

        // dodaj zamowienie
        //usun zamowienie
        // wyswietl zamowienia
    }
}
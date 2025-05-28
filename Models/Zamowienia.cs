using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public enum Status { przygotowywany, gotowy, wydany}
    public class Zamowienia
    {
        public int IdZamowienia { get; set; }
        public Dictionary<Produkty, int> ListaProduktow {get; set;}
        public Status Status { get; set; }

    }
}

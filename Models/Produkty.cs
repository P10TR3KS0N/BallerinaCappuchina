using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class Produkty
    {
        public int IdProduktu { get; set; }
        public string NazwaProduktu { get; set; }
        public List<Skladniki> Skladniki { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
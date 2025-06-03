using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public enum Status { przygotowywany, gotowy, wydany}
    public class Zamowienia
    {
        [Key]
        public int IdZamowienia { get; set; }

        public Status Status { get; set; }

        public virtual ICollection<ZamowienieProdukt> ProduktyZamowienia { get; set; }


    }
}

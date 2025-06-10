using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class Produkty
    {
        private int id;
        [Key]
        public int IdProduktu { get; set; }

        [Required]
        public string NazwaProduktu { get; set; }

        public virtual ICollection<Skladniki> Skladniki { get; set; }

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }
        public virtual Kategoria Kategoria { get; set; }

        public Produkty(string nazwaProduktu)
        {
            IdProduktu = id;
            id++;
            NazwaProduktu = nazwaProduktu;
            Skladniki = new List<Skladniki>();
        }
        public void DodajSkladnik(Skladniki skladnik)
        {

            Skladniki.Add(skladnik);
        }
        public void UsunSkladnik(Skladniki skladnik)
        {
            Skladniki.Remove(skladnik);
        }
        public void UsunProdukt()
        {
            Skladniki.Clear();
            NazwaProduktu = string.Empty;
            IdProduktu = 0;
            id = 0;
            KategoriaId = 0;
            Kategoria = null;
        }
        

    }
}
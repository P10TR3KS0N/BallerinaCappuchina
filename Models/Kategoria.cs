using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class Kategoria
    {
        private int id;
        [Key]
        public int IdKategoria { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Produkty> Produkty { get; set; }

        public Kategoria(string name)
        {
            IdKategoria = id;
            id++;
            Name = name;
            Produkty = new List<Produkty>();
        }
        public void DodajProdukt(Produkty produkt)
        {
            Produkty.Add(produkt);
        }
        public void UsunProdukt(Produkty produkt)
        {
            Produkty.Remove(produkt);
        }
        public void UsunKategorie()
        {
            Produkty.Clear();
            Name = string.Empty;
            IdKategoria = 0;
            id = 0;
        }
        
    }
}
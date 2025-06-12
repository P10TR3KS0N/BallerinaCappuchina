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


        
    }
}
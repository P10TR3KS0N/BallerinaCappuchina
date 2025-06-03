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
        [Key]
        public int IdProduktu { get; set; }

        [Required]
        public string NazwaProduktu { get; set; }

        public virtual ICollection<Skladniki> Skladniki { get; set; }

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }
        public virtual Kategoria Kategoria { get; set; }
    }
}
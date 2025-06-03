using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class Skladniki
    {
        [Key]
        public int IdSkladnika { get; set; }

        [Required]
        public string NazwaSkladnika { get; set; }

        int nowa;
    }
}
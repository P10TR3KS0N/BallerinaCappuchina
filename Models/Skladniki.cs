﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BallerinaCappucina01.Models
{
    public class Skladniki
    {
        private int id;
        [Key]
        public int IdSkladnika { get; set; }

        [Required]
        public string NazwaSkladnika { get; set; }

        public Skladniki(string nazwaSkladnika)
        {
            IdSkladnika = id;
            id++;

            NazwaSkladnika = nazwaSkladnika;
        }
        public void UsunSkladnik()
        {
            NazwaSkladnika = string.Empty;
            IdSkladnika = 0;
            id = 0;
        }
        
    }
}

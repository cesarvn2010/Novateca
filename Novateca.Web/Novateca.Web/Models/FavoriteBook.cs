﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novateca.Web.Models
{
    public class FavoriteBook
    {
       
        public int FavoriteBookID { get; set; }

        public int UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int BookID { get; set; }
        public virtual Book Book { get; set; }

        public DateTime FavoriteDate { get; set; }
        public bool FavoriteEnabled { get; set; }
    }
}

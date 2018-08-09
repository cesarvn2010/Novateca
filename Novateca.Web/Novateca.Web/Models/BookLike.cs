﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novateca.Web.Models
{
    public class BookLike
    {
        public int BookLikeID { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int BookID { get; set; }
        public virtual Book Book { get; set; }
    }
    
}

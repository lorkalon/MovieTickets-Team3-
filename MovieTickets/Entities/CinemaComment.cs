﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CinemaComment
    {
        public int? Id { get; set; }
        public string Comment { get; set; }

        public User User { get; set; }
        public Cinema Cinema { get; set; }
    }
}

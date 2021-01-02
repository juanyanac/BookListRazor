﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key] //primary key
        public int Id { get; set; }
        [Required] // not null
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}

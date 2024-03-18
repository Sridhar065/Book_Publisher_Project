using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DBfirst.Models
{
    public partial class Book
    {
        public int Book_id { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirsttName { get; set; }
        public decimal Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpFeatures.Lib
{
    public class Book
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public Book Sequel { get; set; }
        public string Publisher { get; set; }
    }
}

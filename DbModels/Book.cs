using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eticaret.DbModels
{
    public class Book
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PageNumber { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

    }
   
}
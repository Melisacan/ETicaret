using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eticaret.DbModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
    }
}
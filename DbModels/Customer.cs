using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eticaret.DbModels
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
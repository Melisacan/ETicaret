using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eticaret.Models
{
    public class Index
    {
        [Key]
        public string kitapresim { get; set; }
        public string kitapadi { get; set; }
        public int kitapfiyat { get; set; }
        public string kategori { get; set; }

    }
}
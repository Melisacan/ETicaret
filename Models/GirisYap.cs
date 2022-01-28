using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eticaret.Models
{
    public class GirisYap
    {
        [Key]
        public int MusteriMail { get; set; }
        public int Sifre { get; set; }
        public KayitOl KayitOl { get; set; }
    }
}
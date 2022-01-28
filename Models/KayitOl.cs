using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eticaret.Models
{
    public class KayitOl
    {
        [Key]
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string cinsiyet { get; set; }
        public int telno { get; set; }
        public string mail { get; set; }
        public string sifre { get; set; }
        public string sifretekrar { get; set; }
        public ICollection<GirisYap> GirisYaps { get; set; }
    }
}
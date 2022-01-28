using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace eticaret.Models
{
    public class Context : DbContext
    {
        public DbSet<Index> Indices { get; set; }
        public DbSet<GirisYap> GirisYaps { get; set; }
        public DbSet<KayitOl> KayitOls { get; set; }
        public DbSet<Sepetim> Sepetims { get; set; }
    }
}
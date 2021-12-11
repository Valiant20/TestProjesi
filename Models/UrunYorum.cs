using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProjesi.Models
{
    public class UrunYorum
    {
        public IEnumerable<Urunler> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Urunler> Deger3 { get; set; }
    }
}
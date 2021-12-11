using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProjesi.Models
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunBaslik { get; set; }
        public string  UrunKategoriID { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunResimURL { get; set; }
        public bool UrunDurum { get; set; }

    }
}
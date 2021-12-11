using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProjesi.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string KategoriAdi{ get; set; }
        public string KategoriTipi{ get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProjesi.Models
{
    public class Kategori
    {
        [Key]
        public int UrunKategoriID { get; set; }
        public string KategoriAdi { get; set; }
    }
}
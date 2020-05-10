using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_9_ViewToController.Models
{
    public class Urun
    {
        public int urunID { get; set; }
        public string urunAdi { get; set; }
        public decimal fiyat { get; set; }
        public short stokMiktari { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace LokaLBeer.Models
{
    public partial class kullanici_durum
    {
        public int kullanici_durum_id { get; set; }
        public int kullanici_id { get; set; }
        public string ip { get; set; }
        public Nullable<System.DateTime> giris_tarihi { get; set; }
        public Nullable<System.DateTime> cikis_tarihi { get; set; }
        public virtual kullanici kullanici { get; set; }
    }
}

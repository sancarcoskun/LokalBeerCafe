using System;
using System.Collections.Generic;

namespace LokaLBeer.Models
{
    public partial class kullanici
    {
        public kullanici()
        {
            this.kullanici_durum = new List<kullanici_durum>();
        }

        public int kullanici_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public bool admin { get; set; }
        public bool aktif { get; set; }
        public virtual ICollection<kullanici_durum> kullanici_durum { get; set; }
    }
}

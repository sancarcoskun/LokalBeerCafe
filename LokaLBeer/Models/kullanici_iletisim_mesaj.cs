using System;
using System.Collections.Generic;

namespace LokaLBeer.Models
{
    public partial class kullanici_iletisim_mesaj
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gsm { get; set; }
        public string mesaj { get; set; }
    }
}

using iskuriyer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iskuriyer.Models
{
    public class RegisterModel
    {
        public Kursiyer kursiyer{ get; set; }
        public Sirket sirket{ get; set; }
        public Kursiyer_Iletisim Kursiyer_iletisim{ get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iskuriyer.Models
{
    public class KRegisterModel
    {

        public string Adi{ get; set; }
        public string Soyadi{ get; set; }
        public string Eposta{ get; set; }
        public string  Sifre{ get; set; }

        public string TelefonNo{ get; set; }

        public DateTime DogumTarihi { get; set; }

    }
}
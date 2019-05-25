using iskuriyer.DataAccessLayer.EntityFramework;
using iskuriyer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskuriyer.BusinessLayer
{
 public   class KursiyerIletisimManagerBLL
    {
        Repository<Kursiyer_Iletisim> repo = new Repository<Kursiyer_Iletisim>();

        public void KursiyerIletisimInsert(Kursiyer_Iletisim ki)
        {
          
            repo.Insert(ki);
        }

    }
}

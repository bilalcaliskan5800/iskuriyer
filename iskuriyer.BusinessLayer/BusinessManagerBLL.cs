using iskuriyer.DataAccessLayer.EntityFramework;
using iskuriyer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskuriyer.BusinessLayer
{
    public class BusinessManagerBLL
    {
        Repository<Sirket> repo = new Repository<Sirket>();
        public void InsertBusiness(Sirket sirket)
        {
            repo.Insert(sirket);
        }
    }
}

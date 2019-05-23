using iskuriyer.DataAccessLayer.EntityFramework;
using iskuriyer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskuriyer.BusinessLayer
{
   public class KursiyerManagerBLL
    {
        Repository<Kursiyer> repo = new Repository<Kursiyer>();
        
        public void InsertKursiyer(Kursiyer kursiyer)
        {
            repo.Insert(kursiyer);
            

        } 
        

    }
}

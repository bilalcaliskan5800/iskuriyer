using iskuriyer.DataAccessLayer.EntityFramework;
using iskuriyer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskuriyer.BusinessLayer
{
    public class IllerManager
    {
        Repository<Iller> repo = new Repository<Iller>();

        public List<Iller> GetIller()
        {
            return repo.List();
        }
    }
}

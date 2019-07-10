using Nakliye.DAL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.BLL
{
   public class NakliyeciBLL
    {
        RepositoryPattern<Nakliyeciler> repo = new RepositoryPattern<Nakliyeciler>();
        public List<Nakliyeciler> GetNakliyecilers()
        {
            return repo.List();
        }

        public Nakliyeciler GetNakliyeci(int id)
        {
            return repo.Find(x => x.NakliyeciID == id);
        }
    }
}

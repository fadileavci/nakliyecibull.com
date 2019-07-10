using Nakliye.DAL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.BLL
{
   public class MusteriBLL
    {
        RepositoryPattern<Musteriler> repo = new RepositoryPattern<Musteriler>();

        public void AddCustomers(Musteriler musteri)
        {           
            repo.Add(musteri);
        }  
    }
}

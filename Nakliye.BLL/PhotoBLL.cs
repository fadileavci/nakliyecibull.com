using Nakliye.DAL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.BLL
{
    public class PhotoBLL
    {
        RepositoryPattern<Photo> repo = new RepositoryPattern<Photo>();

        public List<Photo> GetPhoto(int id)
        {
            return repo.List(x => x.NakliyeciID == id);
        }
    }
}

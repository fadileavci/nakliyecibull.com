using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Nakliye.DAL
{
   public class RepositoryPattern<T> where T:class
    {
        DataContext db = new DataContext();
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public List<T> List(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().Where(where).ToList();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }

        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
      
    }
}

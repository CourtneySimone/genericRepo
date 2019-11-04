using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace Repository
{
    //This is my Generic Repo
    public class Repository<C, T> :
   IRepository<T> where T : class where C : DbContext, new()
    {

        private C entity = new C();
        public C Context
        {

            get { return entity; }
            set { entity = value; }
        }

        public virtual List<T> GetAll()
        {
            return entity.Set<T>().AsEnumerable().ToList();
        }

        public T FindById(int Id)
        {
            return entity.Set<T>().Find(Id);
        }

        public virtual void Add(T entity)
        {
            this.entity.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            this.entity.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            this.entity.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            entity.SaveChanges();
        }
    }
}

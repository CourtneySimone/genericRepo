using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public interface IRepository<T> where T : class

    {
        List<T> GetAll();

        T FindById(int Id);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        void Save();

    }
}

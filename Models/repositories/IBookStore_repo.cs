using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.repositories
{
    interface IBookStore_repo<TEntity>
    {
        IList<TEntity> list();
        TEntity Find(int id);
        void add(TEntity entity);
        void update(int id,TEntity entity);
        void delete(int id);
    }
}

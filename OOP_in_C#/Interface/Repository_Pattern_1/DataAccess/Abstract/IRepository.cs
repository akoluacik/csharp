/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;*/

namespace Repository_Pattern_1.DataAccess.Abstract
{
    // Generic Interface
    public interface IRepository<TEntity> // does not matter what is written inside <>.
    {
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Create(TEntity entity);
        void Delete(int id);
    }
}
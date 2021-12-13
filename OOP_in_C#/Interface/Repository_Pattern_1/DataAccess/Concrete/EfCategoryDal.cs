using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository_Pattern_1.DataAccess.Abstract;
using Repository_Pattern_1.Entity;

namespace Repository_Pattern_1.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public Category GetById(int id)
        {
            return new Category(); // whatever it returns is not important for now
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category[] GetCategories()
        {
            throw new System.NotImplementedException();
        }

    }
}
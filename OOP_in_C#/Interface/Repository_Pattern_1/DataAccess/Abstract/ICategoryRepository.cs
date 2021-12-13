/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;*/
using Repository_Pattern_1.Entity;

namespace Repository_Pattern_1.DataAccess.Abstract
{
    /*public interface ICategoryRepository
    {
        Category GetById(int id);

        void Update(Category entity);

        void Create(Category entity);

        void Delete(int id);
    }*/
    public interface ICategoryRepository : IRepository<Category>
    {
        /*Category GetById(int id);
        void Update(Category entity);
        void Create(Category entity);
        void Delete(int id);*/
        // function prototypes are not mandatory, because they are already
        // given in IRepository, and in this file, we give IRepository<Category>
        // so Category will be given as argument to IRepository so the functions' prototypes
        // are done.

        Category[] GetCategories();
    }
}
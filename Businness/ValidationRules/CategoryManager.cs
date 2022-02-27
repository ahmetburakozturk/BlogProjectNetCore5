using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businness.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;

namespace Businness.ValidationRules
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void Add(Category entity)
        {
            efCategoryRepository.Add(entity);
        }

        public void Delete(Category entity)
        {
            efCategoryRepository.Delete(entity);
        }

        public Category Get(int id)
        {
            return efCategoryRepository.Get(id);
        }

        public List<Category> GetAll()
        {
            return efCategoryRepository.GetAll();
        }

        public void Update(Category entity)
        {
            efCategoryRepository.Update(entity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Businness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Businness.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void Add(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public Blog Get(int id)
        {
            return _blogDal.Get(id);
        }

        

        public List<Blog> GetListWithCategories()
        {
            return _blogDal.GetListWithCategories();
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }


        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public List<Blog> GetAll(Expression<Func<Blog, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}

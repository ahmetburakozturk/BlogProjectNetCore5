using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Businness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Businness.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public Comment Get(int id)
        {
            return _commentDal.Get(id);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllById(int id)
        {
            return _commentDal.GetAll(x => x.BlogID == id);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}

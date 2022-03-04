using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Businness.Abstract
{
    public interface ICommentService : ICommentDal
    {
        List<Comment> GetAllById(int id);
    }
}

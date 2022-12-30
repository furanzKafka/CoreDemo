using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _dal;

        public CommentManager(ICommentDal dal)
        {
            _dal = dal;
        }

        public void Add(Comment comment)
        {
            _dal.Add(comment);
        }

        public void Delete(Comment comment)
        {
            _dal.Delete(comment);
        }

        public Comment Get(int id)
        {
            return _dal.Get(id);
        }

        public List<Comment> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Comment> GetAll(int id)
        {
            return _dal.GetAll(x=>x.BlogId==id);
        }

        public void Update(Comment comment)
        {
            _dal.Update(comment);
        }
    }
}

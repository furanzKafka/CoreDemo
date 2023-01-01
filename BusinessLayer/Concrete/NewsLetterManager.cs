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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _dal;

        public NewsLetterManager(INewsLetterDal dal)
        {
            _dal = dal;
        }

        public void Add(NewsLetter newsLetter)
        {
            _dal.Add(newsLetter);
        }

        public void Delete(NewsLetter newsLetter)
        {
            _dal.Delete(newsLetter);
        }

        public NewsLetter Get(int id)
        {
            return _dal.Get(id);
        }

        public List<NewsLetter> GetAll()
        {
            return _dal.GetAll();
        }

        public void Update(NewsLetter newsLetter)
        {
            _dal.Update(newsLetter);
        }
    }
}

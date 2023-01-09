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
    public class WriterManager : IWriterService
    {
        IWriterDal _dal;

        public WriterManager(IWriterDal dal)
        {
            _dal = dal;
        }

        public void Add(Writer writer)
        {
            _dal.Add(writer);
        }

        public void Delete(Writer writer)
        {
            _dal.Delete(writer);
        }

        public Writer Get(int id)
        {
            return _dal.Get(id);
        }

        public List<Writer> GetAll()
        {
            return _dal.GetAll();
        }

        public Writer GetByMail(string mail)
        {
            return _dal.GetByMail(mail);
        }

        public void Update(Writer writer)
        {
            _dal.Update(writer);
        }
    }
}

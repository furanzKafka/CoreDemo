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
    public class AboutManager:IAboutService
    {
        IAboutDal _dal;
        public AboutManager(IAboutDal dal)
        {
            _dal = dal;
        }
        public void Add(About about)
        {
            _dal.Add(about);
        }
        public void Delete(About about)
        {
            _dal.Delete(about);
        }
        public void Update(About about)
        {
            _dal.Update(about);
        }
        public About Get(int id)
        {
            return _dal.Get(id);
        }
        public List<About> GetAll()
        {
            return _dal.GetAll();
        }
    }
}

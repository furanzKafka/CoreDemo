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
    public class AdminManager : IAdminService
    {
        IAdminDal _dal;

        public AdminManager(IAdminDal dal)
        {
            _dal = dal;
        }

        public void Add(Admin about)
        {
            _dal.Add(about);
        }
        public void Delete(Admin about)
        {
            _dal.Delete(about);
        }
        public void Update(Admin about)
        {
            _dal.Update(about);
        }
        public Admin Get(int id)
        {
            return _dal.Get(id);
        }
        public List<Admin> GetAll()
        {
            return _dal.GetAll();
        }
    }
}

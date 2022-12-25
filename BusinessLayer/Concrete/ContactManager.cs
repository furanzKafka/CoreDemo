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
    public class ContactManager : IContactService
    {
        IContactDal _dal;

        public ContactManager(IContactDal dal)
        {
            _dal = dal;
        }

        public void Add(Contact contact)
        {
            _dal.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _dal.Delete(contact);
        }

        public Contact Get(int id)
        {
            return _dal.Get(id);
        }

        public List<Contact> GetAll()
        {
            return _dal.GetAll();
        }

        public void Update(Contact contact)
        {
            _dal.Update(contact);
        }
    }
}

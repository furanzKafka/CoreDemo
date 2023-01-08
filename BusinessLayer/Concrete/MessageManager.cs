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
    public class MessageManager : IMessageService
    {
        IMessageDal _dal;

        public MessageManager(IMessageDal dal)
        {
            _dal = dal;
        }
        public void Add(Message model)
        {
            _dal.Add(model);
        }

        public void Delete(Message model)
        {
            _dal.Delete(model);
        }

        public Message Get(int id)
        {
            return _dal.Get(id);
        }

        public List<Message> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Message> GetAllByWriter(int param)
        {
            return _dal.GetAllWithMessageByWriter(param);            
        }

        public void Update(Message model)
        {
            _dal.Update(model);
        }
    }
}

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
    public class NotificationManager : INotificationService
    {
        INotificationDal _dal;

        public NotificationManager(INotificationDal dal)
        {
            _dal = dal;
        }
        public void Add(Notification model)
        {
            _dal.Add(model);
        }

        public void Delete(Notification model)
        {
            _dal.Delete(model);
        }

        public Notification Get(int id)
        {
            return _dal.Get(id);
        }

        public List<Notification> GetAll()
        {
            return _dal.GetAll();
        }

        public void Update(Notification model)
        {
            _dal.Update(model);
        }        
    }
}

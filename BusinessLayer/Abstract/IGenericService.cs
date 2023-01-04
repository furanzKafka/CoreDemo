using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T model);
        void Delete(T model);
        void Update(T model);
        List<T> GetAll();
        T Get(int id);
    }
}

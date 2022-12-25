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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _dal;

        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public void Add(Category category)
        {
            _dal.Add(category);
        }

        public void Delete(Category category)
        {
            _dal.Delete(category);
        }

        public Category Get(int id)
        {
            return _dal.Get(id);
        }

        public List<Category> GetAll()
        {
            return _dal.GetAll();
        }

        public void Update(Category category)
        {
            _dal.Update(category);
        }
    }
}

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
    public class BlogManager : IBlogService
    {
        IBlogDal _dal;

        public BlogManager(IBlogDal dal)
        {
            _dal = dal;
        }

        public void Add(Blog blog)
        {
            _dal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _dal.Delete(blog);
        }

        public Blog Get(int id)
        {
            return _dal.Get(id);
        }

        public List<Blog> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Blog> GetAllByWriter(int id)
        {
            return _dal.GetAll(x => x.WriterId == id);
        }

        public List<Blog> GetAllLastThree()
        {
            return _dal.GetAll().Take(3).ToList();
        }

        public List<Blog> GetAllWithCategory()
        {
            return _dal.GetAllWithCategory();
        }

        public List<Blog> GetAllWithCategoryByWriter(int id)
        {
            return _dal.GetAllWithCategoryByWriter(id);
        }

        public void Update(Blog blog)
        {
            _dal.Update(blog);
        }
    }
}

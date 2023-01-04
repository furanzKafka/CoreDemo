using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        //void Add(Blog blog);
        //void Delete(Blog blog);
        //void Update(Blog blog);
        //Blog Get(int id);
        //List<Blog> GetAll();
        List<Blog> GetAllLastThree();
        List<Blog> GetAllByWriter(int id);
        List<Blog> GetAllWithCategory();
    }
}

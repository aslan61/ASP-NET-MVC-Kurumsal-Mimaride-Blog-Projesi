using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogData _blogdata;
        public BlogManager(IBlogData blogdata)
        {
            _blogdata = blogdata;
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogdata.List(x => x.BlogID==id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogdata.List(x => x.AuthorID == id);
        }
        public List<Blog> GetBlogCategory(int id)
        {
            return _blogdata.List(x=>x.CategoryID==id);
        }
        public List<Blog> GetList()
        {
            return _blogdata.List();
        }

        public Blog GetByID(int id)
        {
            return _blogdata.GetByID(id);
        }
        public void TAdd(Blog t)
        {
            _blogdata.Insert(t);
        }

        public void TtDelete(Blog t)
        {
            _blogdata.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogdata.Update(t);
        }
    }
}

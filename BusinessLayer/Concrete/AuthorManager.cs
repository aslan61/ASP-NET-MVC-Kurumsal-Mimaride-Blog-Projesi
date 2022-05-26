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
    public class AuthorManager : IAuthorService
    {
        IAuthor _authordal;
        public AuthorManager(IAuthor authordal)
        {
            _authordal = authordal;
        }
        public List<Author> GetList()
        {
            return _authordal.List();
        }
        public Author GetByID(int id)
        {
            return _authordal.GetByID(id);
        }
        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Author t)
        {
            _authordal.Insert(t);
        }

        public void TtDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            _authordal.Update(t);
        }
    }
}

using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContact _contactdal;
        Repository<Contact> repocontact = new Repository<Contact>();

        public ContactManager(IContact contactdal)
        {
            _contactdal = contactdal;
        }
        public List<Contact> GetAll()
        {
            return repocontact.List();
        }

        public Contact GetByID(int id)
        {
            return _contactdal.Fİnd(x => x.ContactID == id);
        }
        public List<Contact> GetList()
        {
            return _contactdal.List();
        }

        public void TAdd(Contact t)
        {
            _contactdal.Insert(t);
        }

        public void TtDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}

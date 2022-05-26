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
    public class AboutManager : IAboutService
    {
        IAbautData _abautdata;
        Repository<About> repoabout = new Repository<About>();

        public AboutManager(IAbautData abautdata)
        {
            _abautdata = abautdata;
        }
        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _abautdata.List();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TtDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _abautdata.Update(t);
        }
    }

}

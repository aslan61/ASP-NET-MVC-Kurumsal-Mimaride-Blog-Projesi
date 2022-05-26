using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericService<T>
    {

            List<T> GetList();
            void TAdd(T t);
            T GetByID(int id);
            void TtDelete(T t);
            void TUpdate(T t);
    }
}

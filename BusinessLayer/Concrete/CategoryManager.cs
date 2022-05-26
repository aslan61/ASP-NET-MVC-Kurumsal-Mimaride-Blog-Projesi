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
    public class CategoryManager : ICategoryService
    {
        ICategory _categoryDal;

        public CategoryManager(ICategory categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryStatusFalseBl(int id)
        {
            Category category = _categoryDal.Fİnd(x => x.CategoryID == id);

            category.CategoryStatus = false;
            _categoryDal.Update(category);
        }
        public void CategoryStatusTrueBl(int id)
        {
            Category category = _categoryDal.Fİnd(x => x.CategoryID == id);

            category.CategoryStatus = true;
            _categoryDal.Update(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
        public Category GetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TtDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}

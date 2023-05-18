using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager()
        {
        }
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());

        }
        public IDataResult<Category> GetById(int categoryId)
        {

            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
            //var category = _categoryDal.GetById(categoryId);
            //if (category != null)
            //{
            //    return new SuccessDataResult<Category>(category);
            //}
            //else
            //{
            //    return new ErrorDataResult<Category>("Category not found");
            //}
        }
    }
}

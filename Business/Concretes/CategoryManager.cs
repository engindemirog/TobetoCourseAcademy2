using Business.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{

    public IList<Category> GetAll()
    {
        //iş kodları
        EfCategoryDal categoryDal = new EfCategoryDal();
        return categoryDal.GetList();
    }
}

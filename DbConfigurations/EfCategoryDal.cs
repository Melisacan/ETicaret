using eticaret.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eticaret.DbConfigurations
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ETicaretContext>, ICategoryDal
    {
    }
}
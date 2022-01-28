using eticaret.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eticaret.DbConfigurations
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
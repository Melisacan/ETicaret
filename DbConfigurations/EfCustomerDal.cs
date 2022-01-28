using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eticaret.DbModels;

namespace eticaret.DbConfigurations
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ETicaretContext>, ICustomerDal
    {
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eticaret.DbModels;

namespace eticaret.DbConfigurations
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}

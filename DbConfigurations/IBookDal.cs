using eticaret.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaret.DbConfigurations
{
    public interface IBookDal:IEntityRepository<Book>
    {
    }
}

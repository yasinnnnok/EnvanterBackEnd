using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.UrunRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.UrunRepository
{
    public class EfUrunDal : EfEntityRepositoryBase<Urun, SimpleContextDb>, IUrunDal
    {
    }
}

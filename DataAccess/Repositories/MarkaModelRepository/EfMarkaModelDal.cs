using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.MarkaModelRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.MarkaModelRepository
{
    public class EfMarkaModelDal : EfEntityRepositoryBase<MarkaModel, SimpleContextDb>, IMarkaModelDal
    {
    }
}

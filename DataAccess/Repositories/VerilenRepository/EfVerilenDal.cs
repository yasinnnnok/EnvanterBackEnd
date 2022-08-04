using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.VerilenRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.VerilenRepository
{
    public class EfVerilenDal : EfEntityRepositoryBase<Verilen, SimpleContextDb>, IVerilenDal
    {
    }
}

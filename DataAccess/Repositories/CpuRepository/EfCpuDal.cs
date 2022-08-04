using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.CpuRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.CpuRepository
{
    public class EfCpuDal : EfEntityRepositoryBase<Cpu, SimpleContextDb>, ICpuDal
    {
    }
}

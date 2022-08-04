using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.IsletimSistemiRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.IsletimSistemiRepository
{
    public class EfIsletimSistemiDal : EfEntityRepositoryBase<IsletimSistemi, SimpleContextDb>, IIsletimSistemiDal
    {
    }
}

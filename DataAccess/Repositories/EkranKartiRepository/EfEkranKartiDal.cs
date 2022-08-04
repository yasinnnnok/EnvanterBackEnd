using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.EkranKartiRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.EkranKartiRepository
{
    public class EfEkranKartiDal : EfEntityRepositoryBase<EkranKarti, SimpleContextDb>, IEkranKartiDal
    {
    }
}

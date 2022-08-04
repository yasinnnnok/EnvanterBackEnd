using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.KategoriRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.KategoriRepository
{
    public class EfKategoriDal : EfEntityRepositoryBase<Kategori, SimpleContextDb>, IKategoriDal
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Repositories.FirmaRepository
{
    public interface IFirmaDal : IEntityRepository<Firma>
    {
    }
}

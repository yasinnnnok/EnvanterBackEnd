using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.FirmaRepository
{
    public interface IFirmaService
    {
        Task<IResult> Add(Firma firma);
        Task<IResult> Update(Firma firma);
        Task<IResult> Delete(Firma firma);
        Task<IDataResult<List<Firma>>> GetList();
        Task<IDataResult<Firma>> GetById(int id);
    }
}

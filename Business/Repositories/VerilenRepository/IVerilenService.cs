using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.VerilenRepository
{
    public interface IVerilenService
    {
        Task<IResult> Add(Verilen verilen);
        Task<IResult> Update(Verilen verilen);
        Task<IResult> Delete(Verilen verilen);
        Task<IDataResult<List<Verilen>>> GetList();
        Task<IDataResult<Verilen>> GetById(int id);
    }
}

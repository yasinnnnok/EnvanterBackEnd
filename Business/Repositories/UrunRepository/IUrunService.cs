using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.UrunRepository
{
    public interface IUrunService
    {
        Task<IResult> Add(Urun urun);
        Task<IResult> Update(Urun urun);
        Task<IResult> Delete(Urun urun);
        Task<IDataResult<List<Urun>>> GetList();
        Task<IDataResult<Urun>> GetById(int id);
    }
}

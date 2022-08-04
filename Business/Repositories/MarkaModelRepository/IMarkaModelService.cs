using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.MarkaModelRepository
{
    public interface IMarkaModelService
    {
        Task<IResult> Add(MarkaModel markaModel);
        Task<IResult> Update(MarkaModel markaModel);
        Task<IResult> Delete(MarkaModel markaModel);
        Task<IDataResult<List<MarkaModel>>> GetList();
        Task<IDataResult<MarkaModel>> GetById(int id);
    }
}

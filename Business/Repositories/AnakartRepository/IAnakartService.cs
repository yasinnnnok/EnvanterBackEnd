using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.AnakartRepository
{
    public interface IAnakartService
    {
        Task<IResult> Add(Anakart anakart);
        Task<IResult> Update(Anakart anakart);
        Task<IResult> Delete(Anakart anakart);
        Task<IDataResult<List<Anakart>>> GetList();
        Task<IDataResult<Anakart>> GetById(int id);
    }
}

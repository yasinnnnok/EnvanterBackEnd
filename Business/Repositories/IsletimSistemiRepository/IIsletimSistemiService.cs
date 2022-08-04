using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.IsletimSistemiRepository
{
    public interface IIsletimSistemiService
    {
        Task<IResult> Add(IsletimSistemi ısletimSistemi);
        Task<IResult> Update(IsletimSistemi ısletimSistemi);
        Task<IResult> Delete(IsletimSistemi ısletimSistemi);
        Task<IDataResult<List<IsletimSistemi>>> GetList();
        Task<IDataResult<IsletimSistemi>> GetById(int id);
    }
}

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
        Task<IResult> Add(IsletimSistemi ─▒sletimSistemi);
        Task<IResult> Update(IsletimSistemi ─▒sletimSistemi);
        Task<IResult> Delete(IsletimSistemi ─▒sletimSistemi);
        Task<IDataResult<List<IsletimSistemi>>> GetList();
        Task<IDataResult<IsletimSistemi>> GetById(int id);
    }
}

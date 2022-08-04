using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.CpuRepository
{
    public interface ICpuService
    {
        Task<IResult> Add(Cpu cpu);
        Task<IResult> Update(Cpu cpu);
        Task<IResult> Delete(Cpu cpu);
        Task<IDataResult<List<Cpu>>> GetList();
        Task<IDataResult<Cpu>> GetById(int id);
    }
}

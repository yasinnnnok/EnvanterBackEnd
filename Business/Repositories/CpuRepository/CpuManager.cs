using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.CpuRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.CpuRepository.Validation;
using Business.Repositories.CpuRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.CpuRepository;

namespace Business.Repositories.CpuRepository
{
    public class CpuManager : ICpuService
    {
        private readonly ICpuDal _cpuDal;

        public CpuManager(ICpuDal cpuDal)
        {
            _cpuDal = cpuDal;
        }

        //[SecuredAspect()]
       // [ValidationAspect(typeof(CpuValidator))]
       // [RemoveCacheAspect("ICpuService.Get")]

        public async Task<IResult> Add(Cpu cpu)
        {
            await _cpuDal.Add(cpu);
            return new SuccessResult(CpuMessages.Added);
        }

       // [SecuredAspect()]
       // [ValidationAspect(typeof(CpuValidator))]
       // [RemoveCacheAspect("ICpuService.Get")]

        public async Task<IResult> Update(Cpu cpu)
        {
            await _cpuDal.Update(cpu);
            return new SuccessResult(CpuMessages.Updated);
        }

       // [SecuredAspect()]
       // [RemoveCacheAspect("ICpuService.Get")]

        public async Task<IResult> Delete(Cpu cpu)
        {
            await _cpuDal.Delete(cpu);
            return new SuccessResult(CpuMessages.Deleted);
        }

       // [SecuredAspect()]
      //  [CacheAspect()]
//[PerformanceAspect()]
        public async Task<IDataResult<List<Cpu>>> GetList()
        {
            return new SuccessDataResult<List<Cpu>>(await _cpuDal.GetAll());
        }

       // [SecuredAspect()]
        public async Task<IDataResult<Cpu>> GetById(int id)
        {
            return new SuccessDataResult<Cpu>(await _cpuDal.Get(p => p.Id == id));
        }

    }
}

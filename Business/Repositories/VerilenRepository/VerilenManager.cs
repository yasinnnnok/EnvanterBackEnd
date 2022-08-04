using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.VerilenRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.VerilenRepository.Validation;
using Business.Repositories.VerilenRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.VerilenRepository;

namespace Business.Repositories.VerilenRepository
{
    public class VerilenManager : IVerilenService
    {
        private readonly IVerilenDal _verilenDal;

        public VerilenManager(IVerilenDal verilenDal)
        {
            _verilenDal = verilenDal;
        }

       // [SecuredAspect()]
      //  [ValidationAspect(typeof(VerilenValidator))]
      //  [RemoveCacheAspect("IVerilenService.Get")]

        public async Task<IResult> Add(Verilen verilen)
        {
            await _verilenDal.Add(verilen);
            return new SuccessResult(VerilenMessages.Added);
        }

      //  [SecuredAspect()]
       // [ValidationAspect(typeof(VerilenValidator))]
      //  [RemoveCacheAspect("IVerilenService.Get")]

        public async Task<IResult> Update(Verilen verilen)
        {
            await _verilenDal.Update(verilen);
            return new SuccessResult(VerilenMessages.Updated);
        }

      //  [SecuredAspect()]
      //  [RemoveCacheAspect("IVerilenService.Get")]

        public async Task<IResult> Delete(Verilen verilen)
        {
            await _verilenDal.Delete(verilen);
            return new SuccessResult(VerilenMessages.Deleted);
        }

      //  [SecuredAspect()]
     //   [CacheAspect()]
     //   [PerformanceAspect()]
        public async Task<IDataResult<List<Verilen>>> GetList()
        {
            return new SuccessDataResult<List<Verilen>>(await _verilenDal.GetAll());
        }

      //  [SecuredAspect()]
        public async Task<IDataResult<Verilen>> GetById(int id)
        {
            return new SuccessDataResult<Verilen>(await _verilenDal.Get(p => p.Id == id));
        }

    }
}

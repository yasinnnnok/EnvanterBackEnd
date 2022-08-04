using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.UrunRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.UrunRepository.Validation;
using Business.Repositories.UrunRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.UrunRepository;

namespace Business.Repositories.UrunRepository
{
    public class UrunManager : IUrunService
    {
        private readonly IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

      //  [SecuredAspect()]
      //  [ValidationAspect(typeof(UrunValidator))]
       // [RemoveCacheAspect("IUrunService.Get")]

        public async Task<IResult> Add(Urun urun)
        {
            await _urunDal.Add(urun);
            return new SuccessResult(UrunMessages.Added);
        }

       // [SecuredAspect()]
      //  [ValidationAspect(typeof(UrunValidator))]
      //  [RemoveCacheAspect("IUrunService.Get")]

        public async Task<IResult> Update(Urun urun)
        {
            await _urunDal.Update(urun);
            return new SuccessResult(UrunMessages.Updated);
        }

       // [SecuredAspect()]
      //  [RemoveCacheAspect("IUrunService.Get")]

        public async Task<IResult> Delete(Urun urun)
        {
            await _urunDal.Delete(urun);
            return new SuccessResult(UrunMessages.Deleted);
        }

       // [SecuredAspect()]
      //  [CacheAspect()]
      //  [PerformanceAspect()]
        public async Task<IDataResult<List<Urun>>> GetList()
        {
            return new SuccessDataResult<List<Urun>>(await _urunDal.GetAll());
        }

      //  [SecuredAspect()]
        public async Task<IDataResult<Urun>> GetById(int id)
        {
            return new SuccessDataResult<Urun>(await _urunDal.Get(p => p.Id == id));
        }

    }
}

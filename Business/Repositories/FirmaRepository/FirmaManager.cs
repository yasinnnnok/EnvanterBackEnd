using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.FirmaRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.FirmaRepository.Validation;
using Business.Repositories.FirmaRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.FirmaRepository;

namespace Business.Repositories.FirmaRepository
{
    public class FirmaManager : IFirmaService
    {
        private readonly IFirmaDal _firmaDal;

        public FirmaManager(IFirmaDal firmaDal)
        {
            _firmaDal = firmaDal;
        }

      //  [SecuredAspect()]
      //  [ValidationAspect(typeof(FirmaValidator))]
      //  [RemoveCacheAspect("IFirmaService.Get")]

        public async Task<IResult> Add(Firma firma)
        {
            await _firmaDal.Add(firma);
            return new SuccessResult(FirmaMessages.Added);
        }

       // [SecuredAspect()]
       // [ValidationAspect(typeof(FirmaValidator))]
       // [RemoveCacheAspect("IFirmaService.Get")]

        public async Task<IResult> Update(Firma firma)
        {
            await _firmaDal.Update(firma);
            return new SuccessResult(FirmaMessages.Updated);
        }

       // [SecuredAspect()]
       // [RemoveCacheAspect("IFirmaService.Get")]

        public async Task<IResult> Delete(Firma firma)
        {
            await _firmaDal.Delete(firma);
            return new SuccessResult(FirmaMessages.Deleted);
        }

       // [SecuredAspect()]
       // [CacheAspect()]
//[PerformanceAspect()]
        public async Task<IDataResult<List<Firma>>> GetList()
        {
            return new SuccessDataResult<List<Firma>>(await _firmaDal.GetAll());
        }

        //[SecuredAspect()]
        public async Task<IDataResult<Firma>> GetById(int id)
        {
            return new SuccessDataResult<Firma>(await _firmaDal.Get(p => p.Id == id));
        }

    }
}

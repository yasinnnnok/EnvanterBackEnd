using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.EkranKartiRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.EkranKartiRepository.Validation;
using Business.Repositories.EkranKartiRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.EkranKartiRepository;

namespace Business.Repositories.EkranKartiRepository
{
    public class EkranKartiManager : IEkranKartiService
    {
        private readonly IEkranKartiDal _ekranKartiDal;

        public EkranKartiManager(IEkranKartiDal ekranKartiDal)
        {
            _ekranKartiDal = ekranKartiDal;
        }

      //  [SecuredAspect()]
       // [ValidationAspect(typeof(EkranKartiValidator))]
//[RemoveCacheAspect("IEkranKartiService.Get")]

        public async Task<IResult> Add(EkranKarti ekranKarti)
        {
            await _ekranKartiDal.Add(ekranKarti);
            return new SuccessResult(EkranKartiMessages.Added);
        }

      //  [SecuredAspect()]
        //[ValidationAspect(typeof(EkranKartiValidator))]
       // [RemoveCacheAspect("IEkranKartiService.Get")]

        public async Task<IResult> Update(EkranKarti ekranKarti)
        {
            await _ekranKartiDal.Update(ekranKarti);
            return new SuccessResult(EkranKartiMessages.Updated);
        }

       // [SecuredAspect()]
       // [RemoveCacheAspect("IEkranKartiService.Get")]

        public async Task<IResult> Delete(EkranKarti ekranKarti)
        {
            await _ekranKartiDal.Delete(ekranKarti);
            return new SuccessResult(EkranKartiMessages.Deleted);
        }

       // [SecuredAspect()]
       // [CacheAspect()]
       // [PerformanceAspect()]
        public async Task<IDataResult<List<EkranKarti>>> GetList()
        {
            return new SuccessDataResult<List<EkranKarti>>(await _ekranKartiDal.GetAll());
        }

       // [SecuredAspect()]
        public async Task<IDataResult<EkranKarti>> GetById(int id)
        {
            return new SuccessDataResult<EkranKarti>(await _ekranKartiDal.Get(p => p.Id == id));
        }

    }
}

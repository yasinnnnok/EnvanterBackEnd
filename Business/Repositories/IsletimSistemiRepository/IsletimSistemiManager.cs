using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.IsletimSistemiRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.IsletimSistemiRepository.Validation;
using Business.Repositories.IsletimSistemiRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.IsletimSistemiRepository;

namespace Business.Repositories.IsletimSistemiRepository
{
    public class IsletimSistemiManager : IIsletimSistemiService
    {
        private readonly IIsletimSistemiDal _ısletimSistemiDal;

        public IsletimSistemiManager(IIsletimSistemiDal ısletimSistemiDal)
        {
            _ısletimSistemiDal = ısletimSistemiDal;
        }

        //[SecuredAspect()]
        //[ValidationAspect(typeof(IsletimSistemiValidator))]
       // [RemoveCacheAspect("IIsletimSistemiService.Get")]

        public async Task<IResult> Add(IsletimSistemi ısletimSistemi)
        {
            await _ısletimSistemiDal.Add(ısletimSistemi);
            return new SuccessResult(IsletimSistemiMessages.Added);
        }

      //  [SecuredAspect()]
      //  [ValidationAspect(typeof(IsletimSistemiValidator))]
     //   [RemoveCacheAspect("IIsletimSistemiService.Get")]

        public async Task<IResult> Update(IsletimSistemi ısletimSistemi)
        {
            await _ısletimSistemiDal.Update(ısletimSistemi);
            return new SuccessResult(IsletimSistemiMessages.Updated);
        }

       // [SecuredAspect()]
      //  [RemoveCacheAspect("IIsletimSistemiService.Get")]

        public async Task<IResult> Delete(IsletimSistemi ısletimSistemi)
        {
            await _ısletimSistemiDal.Delete(ısletimSistemi);
            return new SuccessResult(IsletimSistemiMessages.Deleted);
        }

       // [SecuredAspect()]
       // [CacheAspect()]
       // [PerformanceAspect()]
        public async Task<IDataResult<List<IsletimSistemi>>> GetList()
        {
            return new SuccessDataResult<List<IsletimSistemi>>(await _ısletimSistemiDal.GetAll());
        }

       // [SecuredAspect()]
        public async Task<IDataResult<IsletimSistemi>> GetById(int id)
        {
            return new SuccessDataResult<IsletimSistemi>(await _ısletimSistemiDal.Get(p => p.Id == id));
        }

    }
}

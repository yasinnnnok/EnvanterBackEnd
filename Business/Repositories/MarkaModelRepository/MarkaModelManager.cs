using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.MarkaModelRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.MarkaModelRepository.Validation;
using Business.Repositories.MarkaModelRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.MarkaModelRepository;

namespace Business.Repositories.MarkaModelRepository
{
    public class MarkaModelManager : IMarkaModelService
    {
        private readonly IMarkaModelDal _markaModelDal;

        public MarkaModelManager(IMarkaModelDal markaModelDal)
        {
            _markaModelDal = markaModelDal;
        }

       // [SecuredAspect()]
      //  [ValidationAspect(typeof(MarkaModelValidator))]
      //  [RemoveCacheAspect("IMarkaModelService.Get")]

        public async Task<IResult> Add(MarkaModel markaModel)
        {
            await _markaModelDal.Add(markaModel);
            return new SuccessResult(MarkaModelMessages.Added);
        }

       // [SecuredAspect()]
       // [ValidationAspect(typeof(MarkaModelValidator))]
//[RemoveCacheAspect("IMarkaModelService.Get")]

        public async Task<IResult> Update(MarkaModel markaModel)
        {
            await _markaModelDal.Update(markaModel);
            return new SuccessResult(MarkaModelMessages.Updated);
        }

    //    [SecuredAspect()]
     //   [RemoveCacheAspect("IMarkaModelService.Get")]

        public async Task<IResult> Delete(MarkaModel markaModel)
        {
            await _markaModelDal.Delete(markaModel);
            return new SuccessResult(MarkaModelMessages.Deleted);
        }

      //  [SecuredAspect()]
      //  [CacheAspect()]
      //  [PerformanceAspect()]
        public async Task<IDataResult<List<MarkaModel>>> GetList()
        {
            return new SuccessDataResult<List<MarkaModel>>(await _markaModelDal.GetAll());
        }

       // [SecuredAspect()]
        public async Task<IDataResult<MarkaModel>> GetById(int id)
        {
            return new SuccessDataResult<MarkaModel>(await _markaModelDal.Get(p => p.Id == id));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.KategoriRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.KategoriRepository.Validation;
using Business.Repositories.KategoriRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.KategoriRepository;

namespace Business.Repositories.KategoriRepository
{
    public class KategoriManager : IKategoriService
    {
        private readonly IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

       // [SecuredAspect()]
       // [ValidationAspect(typeof(KategoriValidator))]
       // [RemoveCacheAspect("IKategoriService.Get")]

        public async Task<IResult> Add(Kategori kategori)
        {
            await _kategoriDal.Add(kategori);
            return new SuccessResult(KategoriMessages.Added);
        }

       // [SecuredAspect()]
        //[ValidationAspect(typeof(KategoriValidator))]
       // [RemoveCacheAspect("IKategoriService.Get")]

        public async Task<IResult> Update(Kategori kategori)
        {
            await _kategoriDal.Update(kategori);
            return new SuccessResult(KategoriMessages.Updated);
        }

      //  [SecuredAspect()]
       // [RemoveCacheAspect("IKategoriService.Get")]

        public async Task<IResult> Delete(Kategori kategori)
        {
            await _kategoriDal.Delete(kategori);
            return new SuccessResult(KategoriMessages.Deleted);
        }

       // [SecuredAspect()]
       // [CacheAspect()]
       // [PerformanceAspect()]
        public async Task<IDataResult<List<Kategori>>> GetList()
        {
            return new SuccessDataResult<List<Kategori>>(await _kategoriDal.GetAll());
        }

       // [SecuredAspect()]
        public async Task<IDataResult<Kategori>> GetById(int id)
        {
            return new SuccessDataResult<Kategori>(await _kategoriDal.Get(p => p.Id == id));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.AnakartRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.AnakartRepository.Validation;
using Business.Repositories.AnakartRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.AnakartRepository;
using Core.Utilities.Business;

namespace Business.Repositories.AnakartRepository
{
    public class AnakartManager : IAnakartService
    {
        private readonly IAnakartDal _anakartDal;

        public AnakartManager(IAnakartDal anakartDal)
        {
            _anakartDal = anakartDal;
        }

        //[SecuredAspect()]
        //[ValidationAspect(typeof(AnakartValidator))]
        // [RemoveCacheAspect("IAnakartService.Get")]

        public async Task<IResult> Add(Anakart anakart)
        {
            IResult result = BusinessRules.Run(await IsNameExistForAdd(anakart.AnakartAdi));
            if (result != null)
            {
                return result;
            }


            await _anakartDal.Add(anakart);
            return new SuccessResult(AnakartMessages.Added);
        }

        //   [SecuredAspect()]
        //[ValidationAspect(typeof(AnakartValidator))]
        //[RemoveCacheAspect("IAnakartService.Get")]

        public async Task<IResult> Update(Anakart anakart)
        {
            IResult result = BusinessRules.Run(await IsNameExistForUpdate(anakart));
            if (result!= null)
            {
                return result;
            }
            //null geliyorsa problem yok demektir.
            await _anakartDal.Update(anakart);
            return new SuccessResult(AnakartMessages.Updated);
        }

        // [SecuredAspect()]
        //  [RemoveCacheAspect("IAnakartService.Get")]

        public async Task<IResult> Delete(Anakart anakart)
        {
            await _anakartDal.Delete(anakart);
            return new SuccessResult(AnakartMessages.Deleted);
        }

        // [SecuredAspect()]
        //  [CacheAspect()]
        //[PerformanceAspect()]
        public async Task<IDataResult<List<Anakart>>> GetList()
        {
            return new SuccessDataResult<List<Anakart>>(await _anakartDal.GetAll());
        }

        // [SecuredAspect()]
        public async Task<IDataResult<Anakart>> GetById(int id)
        {
            return new SuccessDataResult<Anakart>(await _anakartDal.Get(p => p.Id == id));
        }

        private async Task<IResult> IsNameExistForAdd(string anakartadi)
        {
            var result = await _anakartDal.Get(p => p.AnakartAdi == anakartadi);
            if (result != null)
            {
                return new ErrorResult(AnakartMessages.AnakartadiIsNotAvaible);
            }
            return new SuccessResult();
        }


        private async Task<IResult> IsNameExistForUpdate(Anakart anakart)
        {
            //Bu id yi bul.
            var currentAnakart = await _anakartDal.Get(p=> p.Id == anakart.Id);

            //vt dekinden farklý ise iþleme devam et.
            if (currentAnakart.AnakartAdi != anakart.AnakartAdi)
            {                
                var result = await _anakartDal.Get(p=>p.AnakartAdi == anakart.AnakartAdi);
             //yeni girilen anakart adý daha önce girildimi . birþey dönüyorsa(nulldan farklý ise kullanýlmýþ diye belirt)
                if (result!=null)
                {
                    return new ErrorResult(AnakartMessages.AnakartadiIsNotAvaible);
                }
            }
            //yeni girilen anakart adý yok demekki. Baþarýlý dön
            return new SuccessResult();
        }


    }
}

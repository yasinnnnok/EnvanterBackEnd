using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.EkranKartiRepository
{
    public interface IEkranKartiService
    {
        Task<IResult> Add(EkranKarti ekranKarti);
        Task<IResult> Update(EkranKarti ekranKarti);
        Task<IResult> Delete(EkranKarti ekranKarti);
        Task<IDataResult<List<EkranKarti>>> GetList();
        Task<IDataResult<EkranKarti>> GetById(int id);
    }
}

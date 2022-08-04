using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.KategoriRepository
{
    public interface IKategoriService
    {
        Task<IResult> Add(Kategori kategori);
        Task<IResult> Update(Kategori kategori);
        Task<IResult> Delete(Kategori kategori);
        Task<IDataResult<List<Kategori>>> GetList();
        Task<IDataResult<Kategori>> GetById(int id);
    }
}

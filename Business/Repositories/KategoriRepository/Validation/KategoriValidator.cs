using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.KategoriRepository.Validation
{
    public class KategoriValidator : AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.UrunRepository.Validation
{
    public class UrunValidator : AbstractValidator<Urun>
    {
        public UrunValidator()
        {
        }
    }
}

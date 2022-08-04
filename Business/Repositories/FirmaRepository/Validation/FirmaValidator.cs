using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.FirmaRepository.Validation
{
    public class FirmaValidator : AbstractValidator<Firma>
    {
        public FirmaValidator()
        {
        }
    }
}

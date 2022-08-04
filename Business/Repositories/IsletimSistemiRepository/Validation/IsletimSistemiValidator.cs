using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.IsletimSistemiRepository.Validation
{
    public class IsletimSistemiValidator : AbstractValidator<IsletimSistemi>
    {
        public IsletimSistemiValidator()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.AnakartRepository.Validation
{
    public class AnakartValidator : AbstractValidator<Anakart>
    {
        public AnakartValidator()
        {
        }
    }
}

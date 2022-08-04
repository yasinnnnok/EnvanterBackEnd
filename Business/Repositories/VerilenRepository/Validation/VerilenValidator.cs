using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.VerilenRepository.Validation
{
    public class VerilenValidator : AbstractValidator<Verilen>
    {
        public VerilenValidator()
        {
        }
    }
}

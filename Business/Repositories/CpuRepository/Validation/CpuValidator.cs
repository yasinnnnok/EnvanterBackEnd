using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.CpuRepository.Validation
{
    public class CpuValidator : AbstractValidator<Cpu>
    {
        public CpuValidator()
        {
        }
    }
}

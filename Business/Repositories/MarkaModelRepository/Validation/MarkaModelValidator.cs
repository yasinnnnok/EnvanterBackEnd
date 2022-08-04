using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.MarkaModelRepository.Validation
{
    public class MarkaModelValidator : AbstractValidator<MarkaModel>
    {
        public MarkaModelValidator()
        {
        }
    }
}
